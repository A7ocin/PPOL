using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;


// Manages the measure lens data for the CinemaSuite Camera Tool.
// Loads lens data from file, and saves user project settings.
public class ProCamsLensDataTable 
{
	// Singleton interface
	private static ProCamsLensDataTable _singleton;
	public static ProCamsLensDataTable Instance
	{
		get
		{
			if(_singleton == null)
			{
				_singleton = new ProCamsLensDataTable();
				_singleton.LoadData();
			}
			return _singleton;
		}
	}
	
	
	// Populated list of supported film formats and measured data
	private List<FilmFormatData> _filmFormats;
	public List<FilmFormatData>.Enumerator FilmFormatDataEmumerator { get { return _filmFormats.GetEnumerator(); } }
	
	// Number of film formats currently loaded
	public int NumFilmFormats { get { return _filmFormats.Count; } }
	
	
	// Return a film format with specified name
	public FilmFormatData GetFilmFormat(string formatName)
	{
		int numFormats = _filmFormats.Count;
		for(int i = 0; i < numFormats; ++i)
		{
			if(_filmFormats[i]._formatName == formatName)
			{
				return _filmFormats[i];
			}
		}
        if (numFormats > 0)
        {
            return _filmFormats[0];
        }
		return null;
	}

    public ScreenSize GetScreenSize(FilmFormatData format, string screenSizeName)
    {
        if (format != null)
        {
            foreach (ScreenSize ss in format._screenSizes)
            {
                if (ss.name == screenSizeName)
                {
                    return ss;
                }
            }
        }
        return new ScreenSize();
    }

	// Load lens and user data
	public void LoadData()
	{
		LoadLensData();
	}
	
	public void LoadLensData()
	{
		_filmFormats = new List<FilmFormatData>();
		
		// Load in the data from Resources/CinemaSuite_LensData.txt
		TextAsset textAsset = (TextAsset)(Resources.Load("CinemaSuite_LensData", typeof(TextAsset)));
		if(textAsset == null)
		{
			Debug.LogError("File 'CinemaSuite_LensData.txt' is not found in Resources folder. Unable to load lens data.");
			return;
		}
		
		FilmFormatData currentFormat = null;
		
		string[] lines = textAsset.text.Split("\n"[0]);
		int numLines = lines.Length;
		for(int i = 0; i < numLines; ++i)
		{
			//Debug.Log("Line: " + i + "= " + lines[i]);
			
			string line = lines[i].Trim();
			if(line.StartsWith("#"))
			{
				continue;	
			}
			
			int length = line.Length;
			
			if(currentFormat == null)
			{
				// Look for "Name="
				if(line.StartsWith("Name="))
				{
					// New section

					int index = line.IndexOf("=") + 1;
					if(index < length)
					{
						string name = line.Substring(index).Trim();
						if(name.Length != 0)
						{
							// Create new film format with valid name
							currentFormat = new FilmFormatData();
							currentFormat._formatName = name;
						}
					}
				}
				else if(length != 0)
				{
					Debug.LogError("Invalid data at line: " + i);
				}
			}
			else
			{
				// Look for film format section entries
				
				if(length == 0)
				{
					// End of section
					_filmFormats.Add(currentFormat);
					//Debug.Log ("Added film format " + currentFormat._formatName);
					currentFormat = null;
				}
				else if(line.StartsWith("Aspect="))
				{
					int index = line.IndexOf("=") + 1;
					if(index < length)
					{
						string strAspect = line.Substring(index).Trim();
						int colon = strAspect.IndexOf(":");
						if(colon > 0 && colon < length)
						{
							string first = strAspect.Substring(0, colon).Trim();
							string second = strAspect.Substring(colon + 1).Trim();
							float w = 0;
							float h = 0;
							
							if(!float.TryParse(first, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out w) || w <= 0)
							{
								Debug.LogError("Invalid number: " + first + " at line " + (i + 1));
								return;
							}
							if(!float.TryParse(second, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out h) || h <= 0)
							{
								Debug.LogError("Invalid number: " + second + " at line " + (i + 1));
								return;
							}
							currentFormat._aspect = w / h;
							//Debug.Log ("Aspect: " + currentFormat._aspect);
						}
					}
				}
				else if(line.StartsWith("ScreenSize"))
				{
					int index = line.IndexOf("=") + 1;
					if(index < length)
					{
						// ScreenSize=DI,1024
						string[] strSizes = line.Substring(index).Split(","[0]);
						if(strSizes == null || strSizes.Length != 2)
						{
							Debug.LogError("Invalid screen size entry at line " + (i + 1));
							return;
						}
						
						string sizeName = strSizes[0].Trim();
						int sizeValue = 0;
						if(!int.TryParse(strSizes[1].Trim(), System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out sizeValue) || sizeValue <= 0)
						{
							Debug.LogError("Invalid screen size at line " + (i + 1));
							return;
						}
						currentFormat._screenSizes.Add(new ScreenSize(sizeName, sizeValue));
						//Debug.Log ("Screensize: " + sizeName + ", " + sizeValue);
					}
				}
				else if(line.StartsWith("FocalLength"))
				{
					int index = line.IndexOf("=") + 1;
					if(index < length)
					{
						// FocalLength=Cooke S4/i - T2,12mm,4.980,00.000,00.000
						string[] strData = line.Substring(index).Split(","[0]);
						if(strData == null || strData.Length != 5)
						{
							Debug.LogError("Invalid data for focal length at line " + (i + 1));
							return;
						}
						
						string lensKit = strData[0].Trim();
						if(lensKit.Length == 0)
						{
							Debug.LogError("Invalid lens kit name at line " + (i + 1));
							return;
						}
						
						int focal = 0;
						if(!int.TryParse(strData[1].TrimEnd('m'), System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out focal) || focal <= 0)
						{
							Debug.LogError("Invalid focal length at line " + (i + 1));
							return;
						}
						
						float nodal = 0;
						if(!float.TryParse(strData[2].Trim(), System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out nodal) || nodal < 0)
						{
							Debug.LogError("Invalid nodal offset at line " + (i + 1));
							return;
						}
						
						float realFOV = 0;
						if(!float.TryParse(strData[3].Trim(), System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out realFOV) || realFOV <= 0)
						{
							Debug.LogError("Invalid real FOV at line " + (i + 1));
							return;
						}
						
						float unityFOV = 0;
						if(!float.TryParse(strData[4].Trim(), System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out unityFOV) || unityFOV <= 0)
						{
							Debug.LogError("Invalid Unity FOV at line " + (i + 1));
							return;
						}
						
						currentFormat.AddFocalLengthData(lensKit, focal, nodal, realFOV, unityFOV);
						//Debug.Log ("Focal Data: " + lensKit + ", " + focal + ", " + nodal + ", " + realFOV + ", " + unityFOV);
					}
				}
			}
		}
	}
	
	
	////////////////////////////////////////////////////////////////////////////////
	// Data structures for measured Lens Data
	
	// Focal Length measurement data.
	public class FOVData
	{
		// The focal length
		public int _focalLength;
		
		// Nodal point offset
		public float _nodalOffset;
		
		// Real world horizontal FOV
		public float _realHFOV;
		
		// Unity measured vertical FOV
		public float _unityVFOV;
		
		public FOVData(int focalLength, float nodalOffset, float realFOV, float unityFOV)
		{
			_focalLength = focalLength;
			_nodalOffset = nodalOffset;
			_realHFOV = realFOV;
			_unityVFOV = unityFOV;
		}
	}
	
	// Each lens kit contains measured data for a set of focal lengths.
	public class LensKitData
	{
		public string _lensKit;
		
		// Data for different focal lengths
		public List<FOVData> _fovDataset = new List<FOVData>();
	}
	
	// Measurement data for each film format.
	// Contains aspect ratio, screen sizes, and field of view data for a set of focal lengths.
	public class FilmFormatData
	{
		// Name of film format aperture
		public string _formatName;
		
		// Film format aspect ratio
		public float _aspect;
		
		// List of supported screen sizes
		public List<ScreenSize> _screenSizes = new List<ScreenSize>();
		
		// List of lens kits and focal length / field of view data
		public List<LensKitData> _lensKits = new List<LensKitData>();
		
		// Add focal length data for a particular lens kit and focal length
		public void AddFocalLengthData(string lensKit, int focalLength, float nodalOffset, float realFOV, float unityFOV)
		{
			// Find the lens kit
			LensKitData lensData = null;
			int numLens = _lensKits.Count;
			for(int i = 0; i < numLens; ++i)
			{
				if(_lensKits[i]._lensKit.Equals(lensKit))
				{
					lensData = _lensKits[i];
					break;
				}
			}
			if(lensData == null)
			{
				// Create new one if it doesn't exist
				lensData = new LensKitData();
				lensData._lensKit = lensKit;
				_lensKits.Add(lensData);
			}
			// Add focal length data
			lensData._fovDataset.Add(new FOVData(focalLength, nodalOffset, realFOV, unityFOV));
		}
		
		// Returns lens kit data structure for specified index
		public LensKitData GetLensKitData(int index)
		{
			if(index >= 0 && index < _lensKits.Count)
			{
				return _lensKits[index];
			}
			return null;
		}
		
		// Returns FOV data structure for specified lens kit and lens
		public FOVData GetFOVData(int lensKitIndex, int lensIndex)
		{
			LensKitData lensKit = GetLensKitData(lensKitIndex);
			if(lensKit != null && lensIndex >= 0 && lensIndex < lensKit._fovDataset.Count)
			{
				return lensKit._fovDataset[lensIndex];
			}
			return null;
		}
	}
}
