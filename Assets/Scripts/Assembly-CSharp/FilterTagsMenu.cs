using System.Collections.Generic;
using InnerNet;
using TMPro;
using UnityEngine;

public class FilterTagsMenu : MonoBehaviour
{
	[SerializeField]
	private CreateOptionsPicker Parent;

	[SerializeField]
	private ObjectPoolBehavior ButtonPool;

	[SerializeField]
	private TextMeshPro ButtonText;

	[SerializeField]
	private GameObject Content;

	[SerializeField]
	[Header("Console Controller Navigation")]
	private UiElement BackButton;

	private List<UiElement> controllerSelectable;

	private GameFilterOptions targetOpts;

	public void Open()
	{
	}

	public void ChooseOption(ChatLanguageButton button, string filter)
	{
	}

	public void Close()
	{
	}

	private void Start()
	{
	}

	private void UpdateButtonText()
	{
	}
}
