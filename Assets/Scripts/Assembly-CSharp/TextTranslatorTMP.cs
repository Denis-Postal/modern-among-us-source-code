using UnityEngine;
using UnityEngine.Events;

public class TextTranslatorTMP : MonoBehaviour, ITranslatedText
{
	public StringNames TargetText;

	public string defaultStr;

	public bool ToUpper;

	public bool ResetOnlyWhenNoDefault;

	public UnityEvent OnTranslate;

	public void ResetText()
	{
	}

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}
}
