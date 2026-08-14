using UnityEngine;
using UnityEngine.Events;

public abstract class UiElement : MonoBehaviour
{
	public UnityEvent OnMouseOver;

	public UnityEvent OnMouseOut;

	public ControllerNavigation ControllerNav;

	public virtual void ReceiveMouseOut()
	{
	}

	public virtual void ReceiveMouseOver()
	{
	}
}
