using System.Collections.Generic;
using InnerNet;
using UnityEngine;

public class BanMenu : MonoBehaviour
{
	public BanButton BanButtonPrefab;

	public SpriteRenderer Background;

	public PassiveButton MenuButton;

	public SpriteRenderer BanButton;

	public SpriteRenderer KickButton;

	public SpriteRenderer ReportButton;

	public GameObject ContentParent;

	public ReportReasonScreen ReportReason;

	public int selectedClientId;

	public List<BanButton> allButtons;

	private List<ClientData> recentClients;

	[SerializeField]
	[Header("Alignment Settings")]
	private float backgroundTailWidth;

	[SerializeField]
	private float backgroundBaseWidth;

	[SerializeField]
	private float backgroundBaseHeight;

	[SerializeField]
	private float borderPadding;

	[SerializeField]
	private float heightPerButton;

	[SerializeField]
	private float widthPerCol;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	public void SetVisible(bool show)
	{
	}

	private void Update()
	{
	}

	public void Show()
	{
	}

	[ContextMenu("AlignAllButtons")]
	private void AlignAllButtons()
	{
	}

	public void Hide()
	{
	}

	public bool CanSelect(int clientId)
	{
		return false;
	}

	public void Select(int clientId)
	{
	}

	public void Kick(bool ban)
	{
	}

	public void PickReportReason()
	{
	}

	public void ReportPlayer(ReportReasons reason)
	{
	}
}
