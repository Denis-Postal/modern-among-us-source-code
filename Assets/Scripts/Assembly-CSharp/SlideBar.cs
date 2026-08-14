using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class SlideBar : PassiveUiElement
{
	[Space(20f)]
	public TextMeshPro Title;

	public SpriteRenderer Bar;

	public SpriteRenderer Dot;

	public FloatRange Range = new FloatRange(-1f, 1f);

	public bool Vertical;

	public float Value;

	public UnityEvent OnValueChange;

	private float sliderSegmentIncrement = 0.1f;

	private bool handleDrag;

	public override bool HandleDrag => handleDrag;

	protected override void OnEnable()
	{
		base.OnEnable();
		handleDrag = true;
		SetEnabledColors();
	}

	public void ReEnable()
	{
		handleDrag = true;
		SetEnabledColors();
	}

	protected override void OnDisable()
	{
		base.OnDisable();
		handleDrag = false;
		SetDisabledColors();
	}

	public override void ReceiveClickDrag(Vector2 dragDelta)
	{
		if (Dot == null || Bar == null || Range == null || DestroyableSingleton<PassiveButtonManager>.Instance == null)
		{
			return;
		}
		Vector3 localPosition = Dot.transform.localPosition;
		Vector2 vector = DestroyableSingleton<PassiveButtonManager>.Instance.controller.DragPosition - (Vector2)Bar.transform.position;
		if (Vertical)
		{
			localPosition.y = Range.Clamp(vector.y);
			Value = Range.ReverseLerp(localPosition.y);
		}
		else
		{
			localPosition.x = Range.Clamp(vector.x);
			Value = Range.ReverseLerp(localPosition.x);
		}
		UpdateValue();
		OnValueChange?.Invoke();
	}

	public void UpdateValue()
	{
		if (Dot == null || Range == null)
		{
			return;
		}
		Vector3 localPosition = Dot.transform.localPosition;
		if (Vertical)
		{
			localPosition.y = Range.Lerp(Value);
		}
		else
		{
			localPosition.x = Range.Lerp(Value);
		}
		Dot.transform.localPosition = localPosition;
	}

	public void SetValue(float newValue)
	{
		Value = Mathf.Clamp01(newValue);
		UpdateValue();
	}

	public void ControllerIncrease()
	{
		Value = Mathf.Clamp01(Value + sliderSegmentIncrement);
		UpdateValue();
		OnValueChange?.Invoke();
	}

	public void ControllerDecrease()
	{
		Value = Mathf.Clamp01(Value - sliderSegmentIncrement);
		UpdateValue();
		OnValueChange?.Invoke();
	}

	private void OnValidate()
	{
		UpdateValue();
	}

	public void SetEnabledColors()
	{
		if (Title != null)
		{
			Title.color = Color.white;
		}
		if (Bar != null)
		{
			Bar.color = Color.white;
		}
		if (Dot != null)
		{
			Dot.color = Color.white;
		}
		UpdateValue();
	}

	public void SetDisabledColors()
	{
		if (Title != null)
		{
			Title.color = Color.gray;
		}
		if (Bar != null)
		{
			Bar.color = Color.gray;
		}
		if (Dot != null)
		{
			Dot.color = Color.gray;
		}
	}
}
