using UnityEngine;
using UnityEngine.Serialization;

public class Scroller : PassiveUiElement
{
	public delegate void ScrollHandler(float value);

	public Transform Inner;

	public bool allowY;

	public bool showY;

	[SerializeField]
	[FormerlySerializedAs("YBounds")]
	private FloatRange ContentYBounds;

	[FormerlySerializedAs("ScrollerYRange")]
	public FloatRange ScrollbarYBounds;

	[FormerlySerializedAs("ScrollerY")]
	public Scrollbar ScrollbarY;

	public bool allowX;

	public bool showX;

	[FormerlySerializedAs("XBounds")]
	[SerializeField]
	private FloatRange ContentXBounds;

	[FormerlySerializedAs("ScrollerXRange")]
	public FloatRange ScrollbarXBounds;

	[FormerlySerializedAs("ScrollerX")]
	public Scrollbar ScrollbarX;

	public float DragScrollSpeed;

	public float ScrollWheelSpeed;

	public bool MouseMustBeOverToScroll;

	private Vector2 velocity;

	private bool active;

	private bool mouseOver;

	public ScrollHandler OnScrollXEvent;

	public ScrollHandler OnScrollYEvent;

	public override bool HandleUp => false;

	public override bool HandleDown => false;

	public override bool HandleDrag => true;

	public override bool HandleOverOut => true;

	public FloatRange YBounds
	{
		get
		{
			return ContentYBounds ?? (ContentYBounds = new FloatRange(0f, 0f));
		}
		set
		{
			ContentYBounds = value ?? new FloatRange(0f, 0f);
			ClampContentPosition();
			UpdateScrollBars();
		}
	}

	public FloatRange XBounds
	{
		get
		{
			return ContentXBounds ?? (ContentXBounds = new FloatRange(0f, 0f));
		}
		set
		{
			ContentXBounds = value ?? new FloatRange(0f, 0f);
			ClampContentPosition();
			UpdateScrollBars();
		}
	}

	public Collider2D HitBox
	{
		get
		{
			return Hitbox;
		}
		set
		{
			ClickMask = value;
		}
	}

	public bool AtTop => Inner == null || Inner.localPosition.y <= YBounds.min + 0.25f;

	public bool AtBottom => Inner == null || Inner.localPosition.y >= YBounds.max - 0.25f;

	public bool AtLeft => Inner == null || Inner.localPosition.x <= XBounds.min + 0.25f;

	public bool AtRight => Inner == null || Inner.localPosition.x >= XBounds.max - 0.25f;

	public Collider2D Hitbox
	{
		get
		{
			if (ClickMask != null)
			{
				return ClickMask;
			}
			return Colliders != null && Colliders.Length > 0 ? Colliders[0] : GetComponent<Collider2D>();
		}
	}

	public void SetBounds(FloatRange yBounds, FloatRange xBounds)
	{
		YBounds = yBounds;
		XBounds = xBounds;
	}

	public void CalculateAndSetYBounds(float amount, float numPerRow, float numRowsVisible, float spacing)
	{
		if (numPerRow <= 0f)
		{
			SetYBoundsMax(0f);
			return;
		}
		float rows = Mathf.Ceil(amount / numPerRow);
		SetYBoundsMax(Mathf.Max(0f, (rows - numRowsVisible) * Mathf.Abs(spacing)));
	}

	public void SetBoundsMax(float yMax, float xMax)
	{
		YBounds.max = yMax;
		XBounds.max = xMax;
		ClampContentPosition();
		UpdateScrollBars();
	}

	public void SetYBoundsMax(float yMax)
	{
		YBounds.max = yMax;
		ClampContentPosition();
		UpdateScrollBars();
	}

	public void SetBoundsMin(float yMin, float xMin)
	{
		YBounds.min = yMin;
		XBounds.min = xMin;
		ClampContentPosition();
		UpdateScrollBars();
	}

	public void SetYBoundsMin(float yMin)
	{
		YBounds.min = yMin;
		ClampContentPosition();
		UpdateScrollBars();
	}

	public FloatRange GetYBounds()
	{
		return YBounds;
	}

	public FloatRange GetXBounds()
	{
		return XBounds;
	}

	protected override void Update()
	{
		base.Update();
		if (Inner == null)
		{
			return;
		}
		if (!MouseMustBeOverToScroll || mouseOver)
		{
			Vector2 scroll = Input.mouseScrollDelta;
			if (scroll.sqrMagnitude > 0f)
			{
				ScrollRelative(new Vector2(0f - scroll.x, 0f - scroll.y) * (ScrollWheelSpeed > 0f ? ScrollWheelSpeed : 1f));
			}
		}
		if (active && velocity.sqrMagnitude > 0.0001f)
		{
			ScrollRelative(velocity * Time.deltaTime);
			velocity = Vector2.Lerp(velocity, Vector2.zero, Time.deltaTime * 12f);
		}
	}

	public void ScrollDown()
	{
		ScrollRelative(new Vector2(0f, DragScrollSpeed > 0f ? DragScrollSpeed : 1f));
	}

	public void ScrollUp()
	{
		ScrollRelative(new Vector2(0f, DragScrollSpeed > 0f ? 0f - DragScrollSpeed : -1f));
	}

	public float GetScrollPercY()
	{
		return YBounds.Width == 0f || Inner == null ? 0f : YBounds.ReverseLerp(Inner.localPosition.y);
	}

	public float GetScrollPercX()
	{
		return XBounds.Width == 0f || Inner == null ? 0f : XBounds.ReverseLerp(Inner.localPosition.x);
	}

	public void ScrollPercentY(float p)
	{
		if (Inner == null)
		{
			return;
		}
		Vector3 localPosition = Inner.localPosition;
		localPosition.y = YBounds.Lerp(Mathf.Clamp01(p));
		Inner.localPosition = localPosition;
		UpdateScrollBars();
		OnScrollYEvent?.Invoke(localPosition.y);
	}

	public void ScrollPercentX(float p)
	{
		if (Inner == null)
		{
			return;
		}
		Vector3 localPosition = Inner.localPosition;
		localPosition.x = XBounds.Lerp(Mathf.Clamp01(p));
		Inner.localPosition = localPosition;
		UpdateScrollBars();
		OnScrollXEvent?.Invoke(localPosition.x);
	}

	public override void ReceiveClickDown()
	{
		active = true;
	}

	public override void ReceiveClickUp()
	{
		active = false;
	}

	public override void ReceiveClickDrag(Vector2 dragDelta)
	{
		ScrollRelative(dragDelta * (DragScrollSpeed > 0f ? DragScrollSpeed : 1f));
	}

	public void ScrollToScrollbarPositionY(Vector3 newScrollbarPosition)
	{
		EnsureBounds();
		if (ScrollbarYBounds.Width == 0f)
		{
			return;
		}
		ScrollPercentY(1f - ScrollbarYBounds.ReverseLerp(newScrollbarPosition.y));
	}

	public void ScrollToScrollbarPositionX(Vector3 newScrollbarPosition)
	{
		EnsureBounds();
		if (ScrollbarXBounds.Width == 0f)
		{
			return;
		}
		ScrollPercentX(ScrollbarXBounds.ReverseLerp(newScrollbarPosition.x));
	}

	public void ScrollRelative(Vector2 dragDelta)
	{
		if (Inner == null)
		{
			return;
		}
		if (!allowX)
		{
			dragDelta.x = 0f;
		}
		if (!allowY)
		{
			dragDelta.y = 0f;
		}
		Vector3 localPosition = Inner.localPosition + (Vector3)dragDelta;
		localPosition.x = XBounds.Clamp(localPosition.x);
		localPosition.y = YBounds.Clamp(localPosition.y);
		Inner.localPosition = localPosition;
		UpdateScrollBars();
		OnScrollXEvent?.Invoke(localPosition.x);
		OnScrollYEvent?.Invoke(localPosition.y);
	}

	public void UpdateScrollBars()
	{
		EnsureBounds();
		float scrollPercY = GetScrollPercY();
		if (ScrollbarY != null)
		{
			ScrollbarY.Toggle(showY && allowY && YBounds.Width > 0f);
			Vector3 localPosition = ScrollbarY.transform.localPosition;
			localPosition.y = ScrollbarYBounds.Lerp(1f - scrollPercY);
			ScrollbarY.UpdatePosition(localPosition);
		}
		float scrollPercX = GetScrollPercX();
		if (ScrollbarX != null)
		{
			ScrollbarX.Toggle(showX && allowX && XBounds.Width > 0f);
			Vector3 localPosition2 = ScrollbarX.transform.localPosition;
			localPosition2.x = ScrollbarXBounds.Lerp(scrollPercX);
			ScrollbarX.UpdatePosition(localPosition2);
		}
	}

	public void ScrollToTop()
	{
		ScrollPercentY(0f);
	}

	public override void ReceiveMouseOver()
	{
		base.ReceiveMouseOver();
		mouseOver = true;
	}

	public override void ReceiveMouseOut()
	{
		base.ReceiveMouseOut();
		mouseOver = false;
		active = false;
	}

	private void ClampContentPosition()
	{
		if (Inner == null)
		{
			return;
		}
		Vector3 localPosition = Inner.localPosition;
		localPosition.x = XBounds.Clamp(localPosition.x);
		localPosition.y = YBounds.Clamp(localPosition.y);
		Inner.localPosition = localPosition;
	}

	private void EnsureBounds()
	{
		if (ContentYBounds == null)
		{
			ContentYBounds = new FloatRange(0f, 0f);
		}
		if (ContentXBounds == null)
		{
			ContentXBounds = new FloatRange(0f, 0f);
		}
		if (ScrollbarYBounds == null)
		{
			ScrollbarYBounds = new FloatRange(0f, 0f);
		}
		if (ScrollbarXBounds == null)
		{
			ScrollbarXBounds = new FloatRange(0f, 0f);
		}
	}
}
