using UnityEngine;

public class MapFilterButton : MonoBehaviour
{
	public MapNames MapId;

	public PassiveButton Button;

	[SerializeField]
	private SpriteRenderer Icon;

	[SerializeField]
	private SpriteRenderer ButtonCheck;

	[SerializeField]
	private SpriteRenderer ButtonOutline;

	[SerializeField]
	private SpriteRenderer ButtonImage;

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void SetFlipped(bool flipped)
	{
	}

	public void SetSelected(bool selected)
	{
	}
}
