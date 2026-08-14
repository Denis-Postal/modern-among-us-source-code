using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AskToMergeGuest : MonoBehaviour
{
	public PassiveButton GoAheadButton;

	public PassiveButton NotRightNowButton;

	public TextMeshPro InfoText;

	private List<SelectableHyperLink> selectableHyperLinks;

	private bool accountIDShow;

	public void OnClose()
	{
	}

	public void Start()
	{
	}

	public void OnTextUpdated()
	{
	}
}
