using UnityEngine;

public class TabGroup : MonoBehaviour
{
	public SpriteRenderer Button;

	public ButtonRolloverHandler Rollover;

	public GameObject Content;

	internal void Close()
	{
		if (Button != null)
		{
			Button.color = Color.white;
		}
		if (Rollover != null)
		{
			Rollover.OutColor = Color.white;
		}
		if (Content != null)
		{
			Content.SetActive(value: false);
		}
	}

	internal void Open()
	{
		if (Button != null)
		{
			Button.color = Color.green;
		}
		if (Rollover != null)
		{
			Rollover.OutColor = Color.green;
		}
		if (Content != null)
		{
			Content.SetActive(value: true);
		}
	}
}
