using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SwitchCDNCache : IPlatformCDNCache
{
	private const string CACHE_NAME = "AmongUsCache";

	private const string CACHE_NAME_DIR = "AmongUsCache:/";

	private const string CATALOG_DIR = "Catalog";

	private Hash128 latestHashUsed;

	private string latestNameUsed;

	private Dictionary<string, byte[]> savedBundlesBytes;

	private static readonly Logger logger;

	public void InitCache(string cacheDir)
	{
	}

	public void SaveCatalog(string json, string localDataPath, string remoteHashValue)
	{
	}

	public void RemoveCatalog(string path)
	{
	}

	public UnityWebRequest BundleDownload(string url, CachedAssetBundle cachedAssetBundle)
	{
		return null;
	}

	public void SaveBundleCache(byte[] data)
	{
	}

	public void LoadBundleFromCache(Action<AssetBundle> callback, byte[] data = null)
	{
	}

	public bool CheckLocalCatalog(string path)
	{
		return false;
	}

	public string LoadLocalCatalog(string path)
	{
		return null;
	}

	private void DeleteDirectory(string path)
	{
	}

	private void Load(ref byte[] outputData, string filename)
	{
	}

	private void Save(byte[] dataByteArray, string fileDir)
	{
	}

	private bool CheckFileExists(string path)
	{
		return false;
	}
}
