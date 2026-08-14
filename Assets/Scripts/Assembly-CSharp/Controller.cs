using UnityEngine;

public class Controller
{
	public class TouchState
	{
		public Vector2 ScreenDownAt;

		public Vector2 ScreenPosition;

		public Vector2 DownAt;

		public Vector2 Position;

		public bool WasDown;

		public bool IsDown;

		public bool TouchStart;

		public bool TouchEnd;

		public DragState dragState;

		public bool active;

		public int FingerId;
	}

	public enum TouchType
	{
		Joystick = 0,
		Mouse = 1,
		Touch = 2
	}

	private const int maxTouchCount = 4;

	private const int mainTouchIndex = 0;

	public readonly TouchState[] Touches;

	private Collider2D amTouching;

	private int touchId;

	private static Vector3 oldMousePos;

	public static TouchType currentTouchType
	{
		get
		{
			if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
			{
				return TouchType.Touch;
			}
			return TouchType.Mouse;
		}
	}

	public Vector2 HoverPosition
	{
		get
		{
			for (int i = Touches.Length - 1; i >= 0; i--)
			{
				if (Touches[i].active)
				{
					return Touches[i].Position;
				}
			}
			return Vector2.zero;
		}
	}

	public bool AnyTouch => Touches[0].IsDown || Touches[1].IsDown;

	public bool AnyTouchDown => Touches[0].TouchStart || Touches[1].TouchStart;

	public bool AnyTouchUp => Touches[0].TouchEnd || Touches[1].TouchEnd;

	public bool FirstDown => Touches[0].TouchStart;

	public Vector2 DragPosition
	{
		get
		{
			if (touchId < 0)
			{
				return Vector2.zero;
			}
			return Touches[touchId].Position;
		}
	}

	public Vector2 DragStartPosition
	{
		get
		{
			if (touchId < 0)
			{
				return Vector2.zero;
			}
			return Touches[touchId].DownAt;
		}
	}

	public Camera mainCam { get; set; }

	public Controller()
	{
		Touches = new TouchState[maxTouchCount];
		for (int i = 0; i < Touches.Length; i++)
		{
			Touches[i] = new TouchState();
		}
		touchId = -1;
	}

	public bool CheckHover(Collider2D coll)
	{
		if (!coll)
		{
			return false;
		}
		for (int i = 0; i < Touches.Length; i++)
		{
			TouchState touchState = Touches[i];
			if (touchState.active && coll.OverlapPoint(touchState.Position))
			{
				return true;
			}
		}
		return false;
	}

	public DragState CheckDrag(Collider2D coll)
	{
		if (!coll)
		{
			return DragState.NoTouch;
		}
		if (touchId > -1 && (!amTouching || !amTouching.isActiveAndEnabled))
		{
			touchId = -1;
			amTouching = null;
		}
		if (touchId > -1)
		{
			if (coll != amTouching)
			{
				return DragState.NoTouch;
			}
			TouchState touchState = Touches[touchId];
			if (touchState.IsDown)
			{
				if (Vector2.Distance(touchState.ScreenDownAt, touchState.ScreenPosition) > 10f || touchState.dragState == DragState.Dragging)
				{
					touchState.dragState = DragState.Dragging;
					return DragState.Dragging;
				}
				touchState.dragState = DragState.Holding;
				return DragState.Holding;
			}
			amTouching = null;
			touchId = -1;
			touchState.dragState = DragState.Released;
			return DragState.Released;
		}
		for (int i = 0; i < Touches.Length; i++)
		{
			TouchState touchState2 = Touches[i];
			if (touchState2.TouchStart && coll.OverlapPoint(touchState2.Position))
			{
				amTouching = coll;
				touchId = i;
				touchState2.dragState = DragState.TouchStart;
				return DragState.TouchStart;
			}
		}
		return DragState.NoTouch;
	}

	public void ResetDragPosition()
	{
		if (touchId >= 0)
		{
			Touches[touchId].DownAt = Touches[touchId].Position;
			Touches[touchId].ScreenDownAt = Touches[touchId].ScreenPosition;
		}
	}

	public void ClearTouch()
	{
		if (touchId >= 0)
		{
			TouchState touchState = Touches[touchId];
			touchState.dragState = DragState.NoTouch;
			touchState.TouchStart = true;
			amTouching = null;
			touchId = -1;
		}
	}

	public void Update()
	{
		if (!mainCam)
		{
			mainCam = Camera.main;
		}
		if (!mainCam)
		{
			return;
		}
		if (currentTouchType == TouchType.Touch)
		{
			UpdateTouchInput();
		}
		else if (currentTouchType == TouchType.Mouse)
		{
			UpdateMouseInput();
		}
		else
		{
			UpdateJoystickInput();
		}
	}

	public void Reset()
	{
		for (int i = 0; i < Touches.Length; i++)
		{
			Touches[i] = new TouchState();
		}
		touchId = -1;
		amTouching = null;
	}

	public TouchState GetTouch(int i)
	{
		return Touches[i];
	}

	private void UpdateTouchInput()
	{
		for (int i = 0; i < Touches.Length; i++)
		{
			TouchState touchState = Touches[i];
			touchState.WasDown = touchState.IsDown;
			touchState.IsDown = false;
			touchState.active = false;
			touchState.TouchStart = false;
			touchState.TouchEnd = false;
		}
		for (int j = 0; j < Input.touchCount && j < Touches.Length; j++)
		{
			Touch touch = Input.GetTouch(j);
			TouchState touchState2 = Touches[j];
			touchState2.ScreenPosition = touch.position;
			touchState2.Position = mainCam.ScreenToWorldPoint(touch.position);
			touchState2.IsDown = true;
			touchState2.active = true;
			touchState2.FingerId = touch.fingerId;
		}
		for (int k = 0; k < Touches.Length; k++)
		{
			TouchState touchState3 = Touches[k];
			touchState3.TouchStart = !touchState3.WasDown && touchState3.IsDown;
			if (touchState3.TouchStart)
			{
				touchState3.ScreenDownAt = touchState3.ScreenPosition;
				touchState3.DownAt = touchState3.Position;
			}
			touchState3.TouchEnd = touchState3.WasDown && !touchState3.IsDown;
		}
	}

	private void UpdateMouseInput()
	{
		TouchState touchState = Touches[mainTouchIndex];
		bool mouseButton = Input.GetMouseButton(0);
		touchState.ScreenPosition = Input.mousePosition;
		touchState.Position = mainCam.ScreenToWorldPoint(Input.mousePosition);
		touchState.TouchStart = !touchState.IsDown && mouseButton;
		if (touchState.TouchStart)
		{
			touchState.ScreenDownAt = touchState.ScreenPosition;
			touchState.DownAt = touchState.Position;
		}
		touchState.TouchEnd = touchState.IsDown && !mouseButton;
		touchState.WasDown = touchState.IsDown;
		touchState.IsDown = mouseButton;
		touchState.active = true;
		oldMousePos = Input.mousePosition;
	}

	private void UpdateJoystickInput()
	{
		TouchState touchState = Touches[mainTouchIndex];
		touchState.TouchStart = false;
		touchState.TouchEnd = false;
		touchState.IsDown = false;
		touchState.active = false;
	}
}
