using System.Collections.Generic;
using UnityEngine;

public class NumberSetter : MonoBehaviour
{
	public enum DateType
	{
		DAYS = 0,
		YEARS = 1,
		MONTHS = 2
	}

	public NumberButton ButtonPrefab;

	public Scroller ButtonParent;

	public AgeGateScreen ParentAgeGateScreen;

	public float ButtonStart;

	public float ButtonHeight;

	private NumberButton[] AllButtons;

	public NumberMenu parentMenu;

	public NumberSetter dayNumberSetter;

	public DateType dateType;

	private List<UiElement> selectableObjects;

	public UiElement backButton;

	private UiElement defaultButton;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetData(NumberButton selected)
	{
	}

	public void UpdateDays()
	{
	}

	private int GetDaysInMonth()
	{
		return 0;
	}

	private void UpdateButtons()
	{
	}

	private void TryDestroyExistingButtons()
	{
	}
}
