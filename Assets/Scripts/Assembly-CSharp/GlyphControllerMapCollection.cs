using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PEW/GlyphControllerMapCollection")]
public class GlyphControllerMapCollection : ScriptableObject
{
	[Serializable]
	public class GlyphControllerMap
	{
		public string controllerName;

		public string glyphCollectionPath;
	}

	public List<GlyphControllerMap> nameToGlyphCollectionList;

	private Dictionary<string, string> nameToGlyphCollectionDict;

	private static GlyphControllerMapCollection _instance;

	public static GlyphControllerMapCollection Instance => null;

	public void Initialize()
	{
	}

	public GlyphCollection TryGetGlyphCollectionForController(string controllerName)
	{
		return null;
	}
}
