using UnityEngine;

public class WaitForHostPopup : DestroyableSingleton<WaitForHostPopup>
{
	public GameObject Content;

	[Header("Console Controller Navigation")]
	public UiElement DefaultButtonSelected;

	public void Show()
	{
	}

	public void ExitGame()
	{
	}

	public void Hide()
	{
	}
}
