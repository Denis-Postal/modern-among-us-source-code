using InnerNet;
using TMPro;
using UnityEngine;

public class ReportReasonScreen : MonoBehaviour
{
	public BanMenu Parent;

	public ButtonRolloverHandler[] Buttons;

	public TextMeshPro NameText;

	public SpriteRenderer PlayerIcon;

	private ReportReasons? currentReason;

	public ReportNotification ConfirmScreen;

	private string playerName;

	private int colorId;

	public void Show(string playerName, int colorId)
	{
	}

	public void SelectReason(ReportReason reason)
	{
	}

	public void Submit()
	{
	}

	public void Hide()
	{
	}
}
