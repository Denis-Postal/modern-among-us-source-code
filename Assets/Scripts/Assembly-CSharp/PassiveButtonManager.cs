using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PassiveButtonManager : DestroyableSingleton<PassiveButtonManager>
{
	private enum ButtonStates
	{
		Up = 0,
		Down = 1,
		Drag = 2
	}

	private class DepthComparer : IComparer<PassiveUiElement>
	{
		public static readonly DepthComparer Instance = new DepthComparer();

		public int Compare(PassiveUiElement x, PassiveUiElement y)
		{
			if (x == null)
			{
				return 1;
			}
			if (y == null)
			{
				return -1;
			}
			return x.CachedZ.CompareTo(y.CachedZ);
		}
	}

	public List<PassiveUiElement> Buttons = new List<PassiveUiElement>();

	private List<IFocusHolder> FocusHolders = new List<IFocusHolder>();

	private PassiveUiElement currentOver;

	public Controller controller = new Controller();

	private ButtonStates currentState;

	private Collider2D[] results;

	public void RegisterOne(PassiveUiElement button)
	{
		if (button != null && !Buttons.Contains(button))
		{
			Buttons.Add(button);
		}
	}

	public void RemoveOne(PassiveUiElement passiveButton)
	{
		Buttons.Remove(passiveButton);
		if (currentOver == passiveButton)
		{
			currentOver = null;
		}
	}

	public void RegisterOne(IFocusHolder focusHolder)
	{
		if (focusHolder != null && !FocusHolders.Contains(focusHolder))
		{
			FocusHolders.Add(focusHolder);
		}
	}

	public void RemoveOne(IFocusHolder focusHolder)
	{
		FocusHolders.Remove(focusHolder);
	}

	public void Update()
	{
		if (!Application.isFocused)
		{
			return;
		}
		controller.Update();
		for (int i = 0; i < Buttons.Count; i++)
		{
			PassiveUiElement passiveUiElement = Buttons[i];
			if (!passiveUiElement)
			{
				Buttons.RemoveAt(i);
				i--;
			}
			else if (passiveUiElement.transform.hasChanged)
			{
				passiveUiElement.CachedZ = passiveUiElement.transform.position.z;
				passiveUiElement.transform.hasChanged = false;
			}
		}
		for (int j = 1; j < Buttons.Count; j++)
		{
			if (DepthComparer.Instance.Compare(Buttons[j - 1], Buttons[j]) > 0)
			{
				Buttons.Sort(DepthComparer.Instance);
				break;
			}
		}
		HandleMouseOut();
		for (int k = 0; k < Buttons.Count; k++)
		{
			PassiveUiElement passiveUiElement2 = Buttons[k];
			if (!passiveUiElement2 || !passiveUiElement2.isActiveAndEnabled)
			{
				continue;
			}
			if (passiveUiElement2.ClickMask)
			{
				Controller.TouchState touch = controller.GetTouch(0);
				if (touch.IsDown && !passiveUiElement2.ClickMask.OverlapPoint(touch.Position))
				{
					continue;
				}
			}
			for (int l = 0; l < passiveUiElement2.Colliders.Length; l++)
			{
				Collider2D collider2D = passiveUiElement2.Colliders[l];
				if (!collider2D || !collider2D.isActiveAndEnabled)
				{
					continue;
				}
				HandleMouseOver(passiveUiElement2, collider2D);
				switch (controller.CheckDrag(collider2D))
				{
				case DragState.TouchStart:
					currentState = ButtonStates.Down;
					if (passiveUiElement2.HandleDown)
					{
						passiveUiElement2.ReceiveClickDown();
					}
					if (passiveUiElement2.HandleDownClickGraphic)
					{
						passiveUiElement2.ReceiveClickDownGraphic();
					}
					break;
				case DragState.Holding:
					if (passiveUiElement2.HandleRepeat)
					{
						passiveUiElement2.ReceiveRepeatDown();
					}
					break;
				case DragState.Dragging:
					currentState = ButtonStates.Drag;
					if (passiveUiElement2.HandleDrag)
					{
						Vector2 dragDelta = controller.DragPosition - controller.DragStartPosition;
						passiveUiElement2.ReceiveClickDrag(dragDelta);
						controller.ResetDragPosition();
					}
					else if (passiveUiElement2.HandleRepeat)
					{
						passiveUiElement2.ReceiveRepeatDown();
					}
					else if (Buttons.Any((PassiveUiElement b) => b.HandleDrag && b.isActiveAndEnabled && b.transform.position.z > collider2D.transform.position.z))
					{
						controller.ClearTouch();
					}
					break;
				case DragState.Released:
					currentState = ButtonStates.Up;
					if (passiveUiElement2.HandleUp)
					{
						passiveUiElement2.ReceiveClickUp();
					}
					if (passiveUiElement2.HandleUpClickGraphic)
					{
						passiveUiElement2.ReceiveClickUpGraphic();
					}
					if (passiveUiElement2.HandleRepeat)
					{
						passiveUiElement2.ReleaseButton();
					}
					break;
				}
			}
		}
		if (controller.AnyTouchDown)
		{
			HandleFocus(GetTouch(getDownTouch: true));
		}
	}

	private void HandleFocus(Vector2 pt)
	{
		bool flag = false;
		for (int i = 0; i < FocusHolders.Count; i++)
		{
			IFocusHolder focusHolder = FocusHolders[i];
			if (!(focusHolder as MonoBehaviour))
			{
				FocusHolders.RemoveAt(i);
				i--;
			}
			else if (focusHolder.CheckCollision(pt))
			{
				flag = true;
				focusHolder.GiveFocus();
				for (int j = 0; j < FocusHolders.Count; j++)
				{
					if (j != i)
					{
						FocusHolders[j].LoseFocus();
					}
				}
				break;
			}
		}
		if (!flag)
		{
			for (int k = 0; k < FocusHolders.Count; k++)
			{
				FocusHolders[k].LoseFocus();
			}
		}
	}

	public void LoseFocusForAll()
	{
		for (int i = 0; i < FocusHolders.Count; i++)
		{
			FocusHolders[i].LoseFocus();
		}
	}

	private void HandleMouseOut()
	{
		if (!currentOver)
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < controller.Touches.Length; i++)
		{
			Controller.TouchState touch = controller.GetTouch(i);
			if (touch.active && currentOver.Colliders.Any((Collider2D c) => c && c.OverlapPoint(touch.Position)))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			currentOver.ReceiveMouseOut();
			currentOver = null;
		}
	}

	private void HandleMouseOver(PassiveUiElement button, Collider2D col)
	{
		if (!button.HandleOverOut || button == currentOver)
		{
			return;
		}
		if (button.ClickMask)
		{
			Vector2 position = controller.GetTouch(0).Position;
			if (!button.ClickMask.OverlapPoint(position))
			{
				return;
			}
		}
		if (currentOver && button.transform.position.z > currentOver.transform.position.z)
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < controller.Touches.Length; i++)
		{
			if (controller.Touches[i].active && col.OverlapPoint(controller.GetTouch(i).Position))
			{
				flag = true;
			}
		}
		if (flag)
		{
			if (currentOver && currentOver != button)
			{
				currentOver.ReceiveMouseOut();
			}
			currentOver = button;
			currentOver.ReceiveMouseOver();
		}
	}

	private Vector2 GetTouch(bool getDownTouch)
	{
		for (int i = 0; i < controller.Touches.Length; i++)
		{
			if ((getDownTouch && controller.Touches[i].TouchStart) || (!getDownTouch && controller.Touches[i].TouchEnd))
			{
				return controller.Touches[i].Position;
			}
		}
		return new Vector2(-5000f, -5000f);
	}
}
