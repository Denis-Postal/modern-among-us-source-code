using UnityEngine;

public class Scrollbar : PassiveUiElement
{
	[SerializeField]
	private Scroller parent;

	[SerializeField]
	private SpriteRenderer graphic;

	[SerializeField]
	private SpriteRenderer trackGraphic;

	[SerializeField]
	private bool horizontal;

	[SerializeField]
	private float dragSpeed;

	private bool dragable;

	public override bool HandleDrag => true;

	public void Toggle(bool on)
	{
		dragable = on;
		if (graphic != null)
		{
			graphic.enabled = on;
		}
		if (trackGraphic != null)
		{
			trackGraphic.enabled = on;
		}
	}

	public void UpdatePosition(Vector3 position)
	{
		transform.localPosition = position;
	}

	public override void ReceiveClickDrag(Vector2 dragDelta)
	{
		if (!dragable || parent == null)
		{
			return;
		}
		Vector3 localPosition = transform.localPosition + (Vector3)(dragDelta * (dragSpeed > 0f ? dragSpeed : 1f));
		if (horizontal)
		{
			parent.ScrollToScrollbarPositionX(localPosition);
		}
		else
		{
			parent.ScrollToScrollbarPositionY(localPosition);
		}
	}
}
