using System;
using System.Collections.Generic;
using Rewired;
using UnityEngine;

[CreateAssetMenu(menuName = "PEW/GlyphCollection")]
public class GlyphCollection : ScriptableObject
{
	[Serializable]
	public class GlyphMap
	{
		public string elementIdentifier;

		public string alternateElementIdentifier;

		public Sprite glyph;
	}

	public enum ErrorCode
	{
		None = 0,
		NoController = 1,
		NoGlyphFound = 2,
		NoElementsBoundToAction = 3
	}

	public string controllerType;

	public List<GlyphMap> glyphMaps;

	public Dictionary<string, GlyphMap> glyphDict;

	private static List<ActionElementMap> mapResults;

	private static GlyphCollection defaultGlyphCollection;

	private static Dictionary<string, GlyphCollection> otherGlyphCollections;

	private static HashSet<string> controllersWithNoValidGlyphCollection;

	private static string GlyphPath => null;

	public void Initialize()
	{
	}

	public static Sprite FindGlyph(int actionName, out ErrorCode error)
	{
		error = default(ErrorCode);
		return null;
	}
}
