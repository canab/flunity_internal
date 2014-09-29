﻿#if UNITY_EDITOR
using System;
using UnityEditor;

namespace Flunity.Unity
{
	internal class AssetsListener : AssetPostprocessor
	{
		public static DateTime timeStamp = DateTime.UtcNow;

		static void OnPostprocessAllAssets(string[] importedAssets, String[] deletedAssets, String[] movedAssets, String[] movedFromAssetPaths)
		{
			timeStamp = DateTime.UtcNow;
		}
	}
}
#endif