using AmongUs.GameOptions;
using TMPro;
using UnityEngine;

public class StringOption : OptionBehaviour
{
	public TextMeshPro TitleText;

	public TextMeshPro ValueText;

	public StringNames[] Values;

	public int Value;

	private int oldValue;

	private Int32OptionNames stringOptionName;

	[SerializeField]
	private GameOptionButton PlusBtn;

	[SerializeField]
	private GameOptionButton MinusBtn;

	public override void SetUpFromData(BaseGameSetting data, int maskLayer)
	{
		base.SetUpFromData(data, maskLayer);
		if ((bool)TitleText)
		{
			TitleText.text = DestroyableSingleton<TranslationController>.InstanceExists ? DestroyableSingleton<TranslationController>.Instance.GetString(data.Title) : data.Title.ToString();
		}
		StringGameSetting stringSetting = data as StringGameSetting;
		if (stringSetting != null)
		{
			stringOptionName = stringSetting.OptionName;
			Values = stringSetting.Values;
		}
		Initialize();
	}

	private void Start()
	{
	}

	public override void Initialize()
	{
		IGameOptions options = GameOptionsManager.Instance != null ? GameOptionsManager.Instance.GameHostOptions : null;
		Value = options != null && stringOptionName != Int32OptionNames.Invalid ? options.GetInt(stringOptionName) : 0;
		if (Values != null && Values.Length > 0)
		{
			Value = Mathf.Clamp(Value, 0, Values.Length - 1);
		}
		oldValue = Value;
		UpdateValue();
	}

	private void FixedUpdate()
	{
	}

	public void Increase()
	{
		int max = Values != null && Values.Length > 0 ? Values.Length - 1 : 100;
		Value = Mathf.Clamp(Value + 1, 0, max);
		UpdateValue();
		OnValueChanged?.Invoke(this);
	}

	public void Decrease()
	{
		int max = Values != null && Values.Length > 0 ? Values.Length - 1 : 100;
		Value = Mathf.Clamp(Value - 1, 0, max);
		UpdateValue();
		OnValueChanged?.Invoke(this);
	}

	public override int GetInt()
	{
		return Value;
	}

	private void UpdateValue()
	{
		if ((bool)ValueText)
		{
			ValueText.text = GetValueString(Value);
		}
		AdjustButtonsActiveState();
		SyncTextRenderers();
	}

	private void AdjustButtonsActiveState()
	{
		int max = Values != null && Values.Length > 0 ? Values.Length - 1 : 100;
		if ((bool)MinusBtn)
		{
			MinusBtn.SetInteractable(Value > 0);
		}
		if ((bool)PlusBtn)
		{
			PlusBtn.SetInteractable(Value < max);
		}
	}
}
