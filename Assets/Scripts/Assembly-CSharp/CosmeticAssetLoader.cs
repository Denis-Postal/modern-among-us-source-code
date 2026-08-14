using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

#if UNITY_EDITOR
using UnityEditor;
#endif

public static class CosmeticAssetLoader
{
	private static readonly Dictionary<Type, object> s_allAssetsCache = new Dictionary<Type, object>();
	private static readonly Dictionary<Type, Dictionary<string, UnityEngine.Object>> s_namedAssetsCache = new Dictionary<Type, Dictionary<string, UnityEngine.Object>>();

	public static T[] LoadAll<T>() where T : UnityEngine.Object
	{
		Type assetType = typeof(T);
		if (s_allAssetsCache.TryGetValue(assetType, out object cachedAssets))
		{
			return (T[])cachedAssets;
		}

		List<T> assets = new List<T>();
#if UNITY_EDITOR
		string[] guids = AssetDatabase.FindAssets("t:" + assetType.Name);
		for (int i = 0; i < guids.Length; i++)
		{
			T asset = AssetDatabase.LoadAssetAtPath<T>(AssetDatabase.GUIDToAssetPath(guids[i]));
			if (asset != null)
			{
				assets.Add(asset);
			}
		}
#else
		assets.AddRange(Resources.FindObjectsOfTypeAll<T>());
#endif

		T[] result = assets.ToArray();
		s_allAssetsCache[assetType] = result;
		return result;
	}

	public static T LoadReference<T>(AssetReference reference) where T : UnityEngine.Object
	{
		return LoadReference<T>(reference, null);
	}

	public static T LoadReference<T>(AssetReference reference, string fallbackName) where T : UnityEngine.Object
	{
		if (reference != null)
		{
			if (!string.IsNullOrEmpty(reference.AssetGUID))
			{
#if UNITY_EDITOR
				T asset = AssetDatabase.LoadAssetAtPath<T>(AssetDatabase.GUIDToAssetPath(reference.AssetGUID));
				if (asset != null)
				{
					return asset;
				}
#else
				T asset = LoadByName<T>(reference.SubObjectName);
				if (asset != null)
				{
					return asset;
				}
#endif
			}

			if (!string.IsNullOrEmpty(reference.SubObjectName))
			{
				T asset = LoadByName<T>(reference.SubObjectName);
				if (asset != null)
				{
					return asset;
				}
			}
		}

		if (!string.IsNullOrEmpty(fallbackName))
		{
			return LoadByName<T>(fallbackName);
		}

		return null;
	}

	public static T LoadByName<T>(string objectName) where T : UnityEngine.Object
	{
		if (string.IsNullOrEmpty(objectName))
		{
			return null;
		}

		Type assetType = typeof(T);
		if (!s_namedAssetsCache.TryGetValue(assetType, out Dictionary<string, UnityEngine.Object> namedAssets))
		{
			namedAssets = new Dictionary<string, UnityEngine.Object>(StringComparer.OrdinalIgnoreCase);
			s_namedAssetsCache[assetType] = namedAssets;
		}

		if (namedAssets.TryGetValue(objectName, out UnityEngine.Object cachedAsset))
		{
			return cachedAsset as T;
		}

		List<string> names = new List<string>();
		names.Add(objectName);
		if (!objectName.EndsWith("View", StringComparison.OrdinalIgnoreCase))
		{
			names.Add(objectName + "View");
		}
		if (objectName.EndsWith("View", StringComparison.OrdinalIgnoreCase))
		{
			names.Add(objectName.Substring(0, objectName.Length - 4));
		}

		T[] assets = LoadAll<T>();
		for (int i = 0; i < assets.Length; i++)
		{
			if (assets[i] == null)
			{
				continue;
			}
			if (!namedAssets.ContainsKey(assets[i].name))
			{
				namedAssets[assets[i].name] = assets[i];
			}
		}

		for (int i = 0; i < names.Count; i++)
		{
			string candidateName = names[i];
			if (string.IsNullOrEmpty(candidateName))
			{
				continue;
			}
			if (namedAssets.TryGetValue(candidateName, out UnityEngine.Object match))
			{
				return match as T;
			}
		}

		return null;
	}
}
