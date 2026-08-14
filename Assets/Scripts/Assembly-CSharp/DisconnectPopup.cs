using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisconnectPopup : DestroyableSingleton<DisconnectPopup>
{
	[SerializeField]
	private TextMeshPro _textArea;

	[SerializeField]
	private TransitionOpen transitionOpen;

	private static readonly Dictionary<DisconnectReasons, StringNames> ErrorMessages;

	private static readonly Dictionary<SanctionReasons, StringNames> SanctionMessages;

	private StringNames[] QuickChatNames;

	public UiElement BackButton;

	private List<SelectableHyperLink> selectableHyperLinks;

	public void Start()
	{
	}

	public void Show()
	{
	}

	private void DoShow()
	{
	}

	public void RegainUIControl()
	{
	}

	private void SetText(string text)
	{
	}

	public void ShowCustom(string message)
	{
	}

	public void Close()
	{
	}

	private void OnTextChanged()
	{
	}

	private void OnDisable()
	{
	}
}
