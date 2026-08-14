using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshPro))]
public class PlatformTextTranslationTMP : MonoBehaviour, ITranslatedText
{
	public StringNames DefaultTargetText;

	public StringNames SwitchTargetText;

	public StringNames XboxTargetText;

	public StringNames PlaystationTargetText;

	public StringNames MobileTargetText;

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
