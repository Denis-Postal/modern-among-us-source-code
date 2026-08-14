using Assets.InnerNet;
using TMPro;
using UnityEngine;

public class AnnouncementPanel : MonoBehaviour
{
	public PassiveButton PassiveButton;

	[SerializeField]
	private TextMeshPro TitleText;

	[SerializeField]
	private TextMeshPro DateText;

	[SerializeField]
	private SpriteRenderer Background;

	[SerializeField]
	private SpriteRenderer RightBorder;

	[SerializeField]
	private SpriteRenderer NewIcon;

	private Announcement announcement;

	private Color32 ReadColor;

	private Color32 SelectedColor;

	public int AnnouncementNumber => 0;

	public void SetUp(Announcement announcement)
	{
	}

	public void Select()
	{
	}

	public void UnSelect()
	{
	}

	public void MarkAsRead()
	{
	}
}
