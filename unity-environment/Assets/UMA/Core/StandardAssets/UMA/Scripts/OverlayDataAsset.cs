using UnityEngine;
using System.Collections;
using System;

namespace UMA
{
	/// <summary>
	/// Contains the immutable data shared between overlays of the same type.
	/// </summary>
	[System.Serializable]
	public partial class OverlayDataAsset : ScriptableObject, ISerializationCallbackReceiver
	{
	    public string overlayName;
		[System.NonSerialized]
		public int nameHash;

		public enum OverlayType
		{
			Normal = 0,
			Cutout = 1,
		}
		/// <summary>
		/// How should this overlay be processed.
		/// </summary>
		public OverlayType overlayType;
		/// <summary>
		/// Destination rectangle for drawing overlay textures.
		/// </summary>
		public Rect rect;
		/// <summary>
		/// Optional Alpha mask, if alpha mask is not set the texture[0].alpha is used instead.
		/// Using a alpha mask also allows you to write alpha values from the texture[0] to cut holes
		/// </summary>
		public Texture alphaMask;
		/// <summary>
		/// Array of textures required for the overlay material.
		/// </summary>
	    public Texture[] textureList;
        /// <summary>
        /// Use this to identify what kind of overlay this is and what it fits
        /// Eg. BaseMeshSkin, BaseMeshOverlays, GenericPlateArmor01
        /// </summary>
        public string[] tags;

		/// <summary>
		/// The UMA material.
		/// </summary>
		/// <remarks>
		/// The UMA material contains both a reference to the Unity material
		/// used for drawing and information needed for matching the textures
		/// and colors to the various material properties.
		/// </remarks>
		[UMAAssetFieldVisible]
		public UMAMaterial material;

		/// <summary>
		/// The number of textures in the texture array.
		/// </summary>
		public int textureCount
		{
			get
			{
				if (material.IsProcedural())
				{
					int count = 0;
					for (int i = 0; i < material.channels.Length; i++)
					{
						if (material.channels[i].channelType != UMAMaterial.ChannelType.MaterialColor)
							count++;
					}

					return count;
				}
				else if (textureList == null)
					return 0;
				
				return textureList.Length;
			}
		}

		/// <summary>
		/// Occlusion Entries for occluding triangles, currently only supported by powertools.
		/// </summary>
		[System.Serializable]
		public class OcclusionEntry
		{
			/// <summary>
			/// This entry works only on one particular slot identified by it's hash
			/// </summary>
			public int slotNameHash;
			/// <summary>
			/// each of the slots submeshes has an array of UInt32 that contains a boolean mask for which triangles this overlay occludes. The triangle masks are ascending (1,2,4...)
			/// </summary>
			public SubMeshOcclusion[] occlusion;
			[System.Serializable]
			public struct SubMeshOcclusion
			{
				public System.Int32[] occlusion;
			}

			public class OcclusionEntryComparer : IComparer
			{
				static OcclusionEntryComparer _instance;
				private OcclusionEntryComparer() { }
				public static OcclusionEntryComparer Instance
				{
					get
					{
						if (_instance == null) _instance = new OcclusionEntryComparer();
						return _instance;
					}
				}

				public int Compare(object x, object y)
				{
					var xo = (x as OcclusionEntry);
					var xv = (xo == null) ? (int)x : xo.slotNameHash;

					var yo = (y as OcclusionEntry);
					var yv = (yo == null) ? (int)y : yo.slotNameHash;

					if (xv < yv)
						return -1;
					if (xv > yv)
						return 1;
					return 0;
				}
			}
		}
		/// <summary>
		/// Occlusion Entries for occluding triangles, currently only supported by powertools.
		/// It is important that the OcclusionEntries be sorted by slotNameHash ascending to allow fast binary lookup
		/// </summary>
		public OcclusionEntry[] OcclusionEntries;

		public OverlayDataAsset()
	    {

	    }

		public void OnAfterDeserialize()
		{
			nameHash = UMAUtils.StringToHash(overlayName);
		}
		public void OnBeforeSerialize()	{ }

		public Texture GetAlphaMask()
		{
			return alphaMask != null ? alphaMask : textureList[0];
		}

		public void SortOcclusion()
		{
			if (OcclusionEntries != null)
			{
				System.Array.Sort(OcclusionEntries, OcclusionEntry.OcclusionEntryComparer.Instance);
#if UNITY_EDITOR
				UnityEditor.EditorUtility.SetDirty(this);
#endif
			}
		}
	}
}