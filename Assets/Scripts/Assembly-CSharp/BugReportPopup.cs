using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BugReportPopup : MonoBehaviour
{
	[SerializeField]
	[Header("Buttons")]
	private PassiveButton[] closeButtons;

	[SerializeField]
	private PassiveButton submitButton;

	[SerializeField]
	[Header("Form")]
	private DropdownButton categoryDropdown;

	[SerializeField]
	private TextBoxTMP descriptionField;

	[SerializeField]
	private PassiveButton descriptionFieldButton;

	[SerializeField]
	private Checkbox attachScreenshotCheckbox;

	[Header("Feedback & Validation")]
	[SerializeField]
	private TextMeshPro descriptionCharacterCount;

	[SerializeField]
	private TextMeshPro submittedText;

	[Header("Console Controller Navigation")]
	[SerializeField]
	private UiElement backButton;

	[SerializeField]
	private UiElement defaultButtonSelected;

	[SerializeField]
	private List<UiElement> controllerSelectable;

	private bool descriptionEntered;

	private StringNames selectedCategory;

	private void Start()
	{
	}

	private void FocusDescription()
	{
	}

	private void UpdateSelectedCategory(int selectedIndex)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void SubmitReport()
	{
	}

	private void ValidateDescription()
	{
	}
}
