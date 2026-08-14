using AmongUs.GameOptions;
using TMPro;
using UnityEngine;

public class ToggleOption : OptionBehaviour
{
	public TextMeshPro TitleText;

	public SpriteRenderer CheckMark;

	private bool oldValue;

	private BoolOptionNames boolOptionName;

	public override void SetUpFromData(BaseGameSetting data, int maskLayer)
	{
		base.SetUpFromData(data, maskLayer);
		if ((bool)TitleText)
		{
			TitleText.text = DestroyableSingleton<TranslationController>.InstanceExists ? DestroyableSingleton<TranslationController>.Instance.GetString(data.Title) : data.Title.ToString();
		}
		CheckboxGameSetting checkboxGameSetting = data as CheckboxGameSetting;
		if (checkboxGameSetting != null)
		{
			boolOptionName = checkboxGameSetting.OptionName;
		}
		Initialize();
	}

	private void Start()
	{
	}

	public override void Initialize()
	{
		IGameOptions options = GameOptionsManager.Instance != null ? GameOptionsManager.Instance.GameHostOptions : null;
		oldValue = options != null && boolOptionName != BoolOptionNames.Invalid && options.GetBool(boolOptionName);
		UpdateValue();
	}

	private void FixedUpdate()
	{
	}

	public void Toggle()
	{
		oldValue = !oldValue;
		UpdateValue();
		OnValueChanged?.Invoke(this);
	}

	public override bool GetBool()
	{
		return oldValue;
	}

	private void UpdateValue()
	{
		if ((bool)CheckMark)
		{
			CheckMark.gameObject.SetActive(oldValue);
		}
		SyncTextRenderers();
	}
}
