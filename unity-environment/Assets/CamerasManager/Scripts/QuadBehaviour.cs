using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadBehaviour : MonoBehaviour {

	public Texture2D mainTexture;

	public int mainTexWidth;
	public int mainTexHeight;
	public int squaresX;
	public int squaresY;
	public int blockWidth;
	public int blockHeight;
	public Color32[] colour0Arr;
	public Color32[] colour1Arr;
	public Color32 colour0;
	public Color32 colour1;

	// Use this for initialization
	void Start () {

		SetMainTextureSize();
		ConvertColourToArray (6);
		CreatePattern();

	}

	void SetMainTextureSize()
	{
		mainTexture = new Texture2D(mainTexWidth, mainTexHeight);
	}

	void CreatePattern()
	{
		for (int i=0; i< squaresX; i++)
		{
			for (int j = 0; j < squaresY; j++)
			{
				if (( (i+j) % 2 ) == 1)
				{
					mainTexture.SetPixels32(i * blockWidth , j * blockHeight , blockWidth, blockHeight, colour0Arr);
				}
				else
				{
					mainTexture.SetPixels32(i * blockWidth, j * blockHeight , blockWidth, blockHeight, colour1Arr);
				}
			}
		}
		mainTexture.Apply();
		GetComponent<Renderer> ().material.mainTexture = mainTexture;
		mainTexture.wrapMode = TextureWrapMode.Clamp;
		mainTexture.filterMode = FilterMode.Point;

	}

	void ConvertColourToArray (int arrSize)
	{
		colour0Arr = new Color32[arrSize];
		colour1Arr = new Color32[arrSize];

		for (int a = 0; a < arrSize; a++) {
			colour0Arr [a] = colour0;
			colour1Arr [a] = colour1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
