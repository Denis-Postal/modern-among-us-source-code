using System.Collections.Generic;
using UnityEngine;

public class TranslationController : DestroyableSingleton<TranslationController>
{
	private static readonly StringNames[] SystemTypesToStringNames;

	private static readonly StringNames[] TaskTypesToStringNames;

	public List<ITranslatedText> ActiveTexts;

	public Dictionary<SupportedLangs, string> dateFormats;

	private LanguageUnit currentLanguage;

	private LanguageUnit fallbackLanguage;

	public Dictionary<SupportedLangs, TranslatedImageSet> Languages { get; private set; }

	static TranslationController()
	{
	}

	public void Initialize()
	{
	}

	public void SetLanguage(SupportedLangs language)
	{
	}

	public Sprite GetImage(ImageNames id)
	{
		return null;
	}

	public string GetString(StringNames id, params object[] parts)
	{
		return null;
	}

	public string GetString(string id, string defaultStr, params object[] parts)
	{
		return null;
	}

	public string GetStringWithDefault(StringNames id, string defaultStr, params object[] parts)
	{
		return null;
	}

	public string GetString(SystemTypes room)
	{
		return null;
	}

	public string GetString(TaskTypes task)
	{
		return null;
	}

	public string GetMonthStringViaNumber(int monthNum)
	{
		return null;
	}

	public StringNames GetTaskName(TaskTypes task)
	{
		return default(StringNames);
	}

	public StringNames GetSystemName(SystemTypes room)
	{
		return default(StringNames);
	}

	internal static uint SelectDefaultLanguage()
	{
		return 0u;
	}

	public static bool TryParseLanguage(string language, out SupportedLangs output)
	{
		output = default(SupportedLangs);
		return false;
	}

	public static bool DoesLanguageSupportBold(SupportedLangs language)
	{
		return false;
	}
}
