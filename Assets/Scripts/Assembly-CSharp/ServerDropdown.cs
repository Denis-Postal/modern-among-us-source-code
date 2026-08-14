using System;
using System.Collections.Generic;
using UnityEngine;

public class ServerDropdown : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer background;

	[SerializeField]
	private ObjectPoolBehavior ButtonPool;

	[SerializeField]
	private PassiveButton firstOption;

	[SerializeField]
	private float initialYPos;

	[SerializeField]
	private float y_posButton;

	private const float INITIAL_HEIGHT = 1.2f;

	private const float YOFFSET = -0.3f;

	private const float HEIGHT_INCREASE = 0.6f;

	private const float YOFFSET_BUTTON = -0.55f;

	private Action<string> serverSetAction;

	private Action closeAction;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	private UiElement defaultButtonSelected;

	private List<UiElement> controllerSelectable;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void Initialize(Action<string> setCallback, Action closeCallback)
	{
	}

	private void FillServerOptions()
	{
	}

	private void ChooseOption(IRegionInfo region)
	{
	}

	public void OnDisable()
	{
	}

	public void Close()
	{
	}
}
