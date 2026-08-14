using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class LanguageUnit
{
	private static StringBuilder builder;

	public bool IsEnglish;

	public SupportedLangs languageID;

	private Dictionary<string, string> AllStrings;

	private Dictionary<ImageNames, Sprite> AllImages;

	public LanguageUnit(TranslatedImageSet locSet)
	{
	}

	public static bool TryParseTsvLine(string line, out string key, out string text)
	{
		key = null;
		text = null;
		return false;
	}

	public static void ParseTSV(string tsvText, Dictionary<string, string> allStrings)
	{
	}

	public static string UnescapeCodes(string src, int startAt)
	{
		return null;
	}

	public string GetString(string idString, params object[] parts)
	{
		return null;
	}

	public Sprite GetImage(ImageNames id)
	{
		return null;
	}
}
