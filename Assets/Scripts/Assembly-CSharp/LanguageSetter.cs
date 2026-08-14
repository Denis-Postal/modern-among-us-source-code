using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LanguageSetter : MonoBehaviour
{
	public LanguageButton ButtonPrefab;

	public Scroller ButtonParent;

	public float ButtonStart;

	public float ButtonHeight;

	private LanguageButton[] AllButtons;

	public TextMeshPro parentLangButton;

	private List<UiElement> selectableButtons;

	public UiElement backButton;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Start()
	{
	}

	public void SetLanguage(LanguageButton selected)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}
}
