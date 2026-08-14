using AmongUs.GameOptions;
using TMPro;
using UnityEngine;

public class NumberOption : OptionBehaviour
{
	public TextMeshPro TitleText;

	public TextMeshPro ValueText;

	public float Value;

	private float oldValue;

	public float Increment;

	public FloatRange ValidRange;

	public string FormatString;

	public bool ZeroIsInfinity;

	public NumberSuffixes SuffixType;

	private FloatOptionNames floatOptionName;

	private Int32OptionNames intOptionName;

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
		FloatGameSetting floatSetting = data as FloatGameSetting;
		IntGameSetting intSetting = data as IntGameSetting;
		if (floatSetting != null)
		{
			floatOptionName = floatSetting.OptionName;
			Increment = floatSetting.Increment == 0f ? 1f : floatSetting.Increment;
			ValidRange = floatSetting.ValidRange ?? new FloatRange(0f, 100f);
			FormatString = floatSetting.FormatString;
			ZeroIsInfinity = floatSetting.ZeroIsInfinity;
			SuffixType = floatSetting.SuffixType;
		}
		else if (intSetting != null)
		{
			intOptionName = intSetting.OptionName;
			Increment = intSetting.Increment == 0 ? 1f : intSetting.Increment;
			ValidRange = new FloatRange(intSetting.ValidRange != null ? intSetting.ValidRange.min : 0, intSetting.ValidRange != null ? intSetting.ValidRange.max : 100);
			FormatString = intSetting.FormatString;
			ZeroIsInfinity = intSetting.ZeroIsInfinity;
			SuffixType = intSetting.SuffixType;
		}
		Initialize();
	}

	private void Start()
	{
	}

	public override void Initialize()
	{
		IGameOptions options = GameOptionsManager.Instance != null ? GameOptionsManager.Instance.GameHostOptions : null;
		if (options != null && floatOptionName != FloatOptionNames.Invalid)
		{
			Value = options.GetFloat(floatOptionName);
		}
		else if (options != null && intOptionName != Int32OptionNames.Invalid)
		{
			Value = options.GetInt(intOptionName);
		}
		oldValue = Value;
		UpdateValue();
	}

	private void FixedUpdate()
	{
	}

	public void Increase()
	{
		Value = ValidRange != null ? ValidRange.Clamp(Value + Increment) : Value + Increment;
		UpdateValue();
		OnValueChanged?.Invoke(this);
	}

	public void Decrease()
	{
		Value = ValidRange != null ? ValidRange.Clamp(Value - Increment) : Value - Increment;
		UpdateValue();
		OnValueChanged?.Invoke(this);
	}

	public override float GetFloat()
	{
		return Value;
	}

	public override int GetInt()
	{
		return Mathf.RoundToInt(Value);
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
		if (ValidRange == null)
		{
			return;
		}
		if ((bool)MinusBtn)
		{
			MinusBtn.SetInteractable(Value > ValidRange.min);
		}
		if ((bool)PlusBtn)
		{
			PlusBtn.SetInteractable(Value < ValidRange.max);
		}
	}
}
