using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PassiveButton : PassiveUiElement
{
	public Button.ButtonClickedEvent OnClick = new Button.ButtonClickedEvent();

	public AudioClip ClickSound;

	public AudioClip HoverSound;

	public bool OnUp = true;

	public bool OnDown;

	public bool OnRepeat;

	public bool OnUpGraphic;

	public bool OnDownGraphic;

	public float RepeatDuration;

	[Header("Hold to Use")]
	public SpriteRenderer HeldButtonSprite;

	public ActionButton TargetActionButton;

	public bool HoldToUse;

	private bool beingHeldDown;

	private float repeatTimer;

	private float totalHeldTime;

	private bool checkedClickEvent;

	private bool selected;

	[Header("States")]
	[SerializeField]
	private GameObject selectedSprites;

	[SerializeField]
	private GameObject activeSprites;

	[SerializeField]
	private GameObject inactiveSprites;

	[SerializeField]
	private GameObject disabledSprites;

	[SerializeField]
	private GameObject selectedInactiveSprites;

	[SerializeField]
	private GameObject onClickSprites;

	[SerializeField]
	private bool forceInactiveSpritesMobile;

	[SerializeField]
	private bool forceClickGraphicMobile;

	[Space(10f)]
	[SerializeField]
	private TextMeshPro buttonText;

	[SerializeField]
	private Color selectedTextColor = Color.white;

	[SerializeField]
	private Color activeTextColor = Color.white;

	[SerializeField]
	private Color inactiveTextColor = Color.white;

	[SerializeField]
	private Color disabledTextColor = Color.gray;

	[SerializeField]
	private Color selectedInactiveTextColor = Color.white;

	private static readonly int STENCIL_COMP = Shader.PropertyToID("_StencilComp");

	private static readonly int STENCIL = Shader.PropertyToID("_Stencil");

	public override bool HandleUp => OnUp && enabled;

	public override bool HandleDown => (OnDown || OnRepeat || HoldToUse || OnDownGraphic) && enabled;

	public override bool HandleRepeat => (OnRepeat || HoldToUse) && enabled;

	public override bool HandleUpClickGraphic => OnUpGraphic && enabled;

	public override bool HandleDownClickGraphic => OnDownGraphic && enabled;

	public override bool HandleOverOut => true;

	private void Awake()
	{
		if (OnClick == null)
		{
			OnClick = new Button.ButtonClickedEvent();
		}
		if (OnMouseOver == null)
		{
			OnMouseOver = new UnityEngine.Events.UnityEvent();
		}
		if (OnMouseOut == null)
		{
			OnMouseOut = new UnityEngine.Events.UnityEvent();
		}
	}

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
		if (beingHeldDown && HoldToUse)
		{
			totalHeldTime += Time.deltaTime;
		}
	}

	protected override void OnDisable()
	{
		base.OnDisable();
		ReleaseButton();
	}

	protected override void OnEnable()
	{
		base.OnEnable();
	}

	public override void ReceiveClickDown()
	{
		if (!enabled)
		{
			return;
		}
		beingHeldDown = true;
		repeatTimer = 0f;
		totalHeldTime = 0f;
		SetPassiveButtonClickState(clicked: true);
		if (OnDown)
		{
			DoClick();
		}
	}

	public override void ReceiveRepeatDown()
	{
		if (!enabled)
		{
			return;
		}
		if (HoldToUse && TargetActionButton != null)
		{
			totalHeldTime += Time.deltaTime;
		}
		if (!OnRepeat)
		{
			return;
		}
		repeatTimer -= Time.deltaTime;
		if (repeatTimer <= 0f)
		{
			repeatTimer = Mathf.Max(RepeatDuration, 0.01f);
			DoClick();
		}
	}

	public override void ReceiveClickUp()
	{
		if (!enabled)
		{
			return;
		}
		SetPassiveButtonClickState(clicked: false);
		if (OnUp)
		{
			DoClick();
		}
		beingHeldDown = false;
	}

	public void SetButtonEnableState(bool enabled)
	{
		this.enabled = enabled;
		if (!enabled)
		{
			SetPassiveButtonDisabledState();
		}
	}

	public void AddOnClickListeners(params Action[] callbacks)
	{
		if (OnClick == null)
		{
			OnClick = new Button.ButtonClickedEvent();
		}
		for (int i = 0; i < callbacks.Length; i++)
		{
			Action callback = callbacks[i];
			if (callback != null)
			{
				OnClick.AddListener(() => callback());
			}
		}
	}

	public override void ReleaseButton()
	{
		beingHeldDown = false;
		repeatTimer = 0f;
		totalHeldTime = 0f;
		SetPassiveButtonClickState(clicked: false);
	}

	public override void ReceiveMouseOut()
	{
		base.ReceiveMouseOut();
		if (OnMouseOut != null)
		{
			OnMouseOut.Invoke();
		}
		SetPassiveButtonHoverStateInactive();
	}

	public override void ReceiveMouseOver()
	{
		base.ReceiveMouseOver();
		if (OnMouseOver != null)
		{
			OnMouseOver.Invoke();
		}
		SetPassiveButtonHoverStateActive();
		if (HoverSound)
		{
			SoundManager soundManager = SoundManager.Instance;
			if (soundManager != null)
			{
				soundManager.PlaySound(HoverSound, loop: false);
			}
		}
	}

	public override void ReceiveClickUpGraphic()
	{
		SetPassiveButtonClickState(clicked: false);
	}

	public override void ReceiveClickDownGraphic()
	{
		SetPassiveButtonClickState(clicked: true);
	}

	private void SetPassiveButtonClickState(bool clicked)
	{
		SetActiveSafe(onClickSprites, clicked || forceClickGraphicMobile);
	}

	public void SetPassiveButtonHoverStateActive()
	{
		if (!enabled)
		{
			SetPassiveButtonDisabledState();
			return;
		}
		SetActiveSafe(selectedSprites, selected);
		SetActiveSafe(activeSprites, !selected);
		SetActiveSafe(inactiveSprites, false);
		SetActiveSafe(disabledSprites, false);
		SetActiveSafe(selectedInactiveSprites, false);
		SetTextColor(selected ? selectedTextColor : activeTextColor);
	}

	public void SetPassiveButtonHoverStateInactive()
	{
		if (!enabled)
		{
			SetPassiveButtonDisabledState();
			return;
		}
		bool forceInactive = forceInactiveSpritesMobile && Controller.currentTouchType == Controller.TouchType.Touch;
		SetActiveSafe(selectedSprites, false);
		SetActiveSafe(activeSprites, false);
		SetActiveSafe(inactiveSprites, !selected || forceInactive);
		SetActiveSafe(disabledSprites, false);
		SetActiveSafe(selectedInactiveSprites, selected);
		SetTextColor(selected ? selectedInactiveTextColor : inactiveTextColor);
	}

	private void SetPassiveButtonDisabledState()
	{
		SetActiveSafe(selectedSprites, false);
		SetActiveSafe(activeSprites, false);
		SetActiveSafe(inactiveSprites, false);
		SetActiveSafe(disabledSprites, true);
		SetActiveSafe(selectedInactiveSprites, false);
		SetPassiveButtonClickState(clicked: false);
		SetTextColor(disabledTextColor);
	}

	public void SelectButton(bool isSelected)
	{
		selected = isSelected;
		SetPassiveButtonHoverStateInactive();
	}

	public void ChangeButtonText(string s)
	{
		if (buttonText != null)
		{
			buttonText.text = s;
		}
	}

	public bool IsSelected()
	{
		return selected;
	}

	public void SetMaskLayer(int maskID)
	{
		SetMaskLayer(selectedSprites, maskID);
		SetMaskLayer(activeSprites, maskID);
		SetMaskLayer(inactiveSprites, maskID);
		SetMaskLayer(disabledSprites, maskID);
		SetMaskLayer(selectedInactiveSprites, maskID);
		SetMaskLayer(onClickSprites, maskID);
		if (buttonText != null)
		{
			SetMaskLayer(buttonText.renderer, maskID);
		}
	}

	public void DoClick()
	{
		if (!enabled)
		{
			return;
		}
		if (ClickSound)
		{
			SoundManager soundManager = SoundManager.Instance;
			if (soundManager != null)
			{
				soundManager.PlaySound(ClickSound, loop: false);
			}
		}
		if (OnClick == null)
		{
			OnClick = new Button.ButtonClickedEvent();
		}
		OnClick.Invoke();
		checkedClickEvent = true;
	}

	private void SetActiveSafe(GameObject obj, bool active)
	{
		if (obj != null && obj.activeSelf != active)
		{
			obj.SetActive(active);
		}
	}

	private void SetTextColor(Color color)
	{
		if (buttonText != null)
		{
			buttonText.color = color;
		}
	}

	private void SetMaskLayer(GameObject obj, int maskID)
	{
		if (obj == null)
		{
			return;
		}
		SpriteRenderer[] componentsInChildren = obj.GetComponentsInChildren<SpriteRenderer>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			SetMaskLayer(componentsInChildren[i], maskID);
		}
		TextMeshPro[] componentsInChildren2 = obj.GetComponentsInChildren<TextMeshPro>(true);
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			SetMaskLayer(componentsInChildren2[j].renderer, maskID);
		}
	}

	private void SetMaskLayer(Renderer renderer, int maskID)
	{
		if (renderer == null)
		{
			return;
		}
#if UNITY_EDITOR
		if (UnityEditor.EditorUtility.IsPersistent(renderer))
		{
			return;
		}
#endif
		Material material = renderer.gameObject.scene.IsValid() ? renderer.material : renderer.sharedMaterial;
		if (material != null)
		{
			material.SetFloat(STENCIL_COMP, 3f);
			material.SetFloat(STENCIL, maskID);
		}
	}
}
