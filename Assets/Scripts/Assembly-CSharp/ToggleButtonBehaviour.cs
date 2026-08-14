using TMPro;
using UnityEngine;

public class ToggleButtonBehaviour : MonoBehaviour, ITranslatedText
{
	public StringNames BaseText;

	public TextMeshPro Text;

	public SpriteRenderer Background;

	public ButtonRolloverHandler Rollover;

	private bool onState;

	public void Start()
	{
		TranslationController translationController = DestroyableSingleton<TranslationController>.InstanceExists ? DestroyableSingleton<TranslationController>.Instance : null;
		if (translationController != null && translationController.ActiveTexts != null)
		{
			translationController.ActiveTexts.Add(this);
		}
		ResetText();
	}

	public void OnDestroy()
	{
		TranslationController translationController = DestroyableSingleton<TranslationController>.InstanceExists ? DestroyableSingleton<TranslationController>.Instance : null;
		if (translationController != null && translationController.ActiveTexts != null)
		{
			translationController.ActiveTexts.Remove(this);
		}
	}

	public void ResetText()
	{
		if (Text == null)
		{
			return;
		}
		string baseText = BaseText.ToString();
		string stateText = onState ? "On" : "Off";
		TranslationController translationController = DestroyableSingleton<TranslationController>.InstanceExists ? DestroyableSingleton<TranslationController>.Instance : null;
		if (translationController != null)
		{
			baseText = translationController.GetString(BaseText) ?? baseText;
			stateText = translationController.GetString(onState ? StringNames.SettingsOn : StringNames.SettingsOff) ?? stateText;
		}
		Text.text = baseText + ": " + stateText;
	}

	public void UpdateText(bool on)
	{
		onState = on;
		Color color = on ? new Color(0f, 1f, 14f / 85f, 1f) : Color.white;
		if (Background != null)
		{
			Background.color = color;
		}
		if (Rollover != null)
		{
			Rollover.OutColor = color;
		}
		ResetText();
	}
}
