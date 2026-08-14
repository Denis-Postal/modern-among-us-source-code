using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LanguagePicker : MonoBehaviour
{
	[SerializeField]
	private ObjectPoolBehavior ButtonPool;

	[SerializeField]
	private TextMeshPro label;

	public Action<bool> callbackTooltip;

	public Action<uint> callbackLang;

	private const float INITIAL_X_POS = 0f;

	private const float INITIAL_Y_POS = 0f;

	private const float XOFFSET = 2.1f;

	private const float YOFFSET = -0.65f;

	private const string OTHER_STRING = "Other";

	private const int NUM_COLUMNS = 3;

	private List<LanguageOption> langOptions;

	private const int MASK_LAYER = 51;

	private static readonly int STENCIL_COMP;

	private static readonly int STENCIL;

	public void SetupLanguageButtons(uint sel)
	{
	}

	public List<LanguageOption> GetLangButtons()
	{
		return null;
	}

	private void ChooseOption(uint lang)
	{
	}

	public void SetupMaskLayer()
	{
	}
}
