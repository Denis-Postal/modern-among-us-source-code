using UnityEngine;

public class LoadingBarManager : DestroyableSingleton<LoadingBarManager>
{
	[SerializeField]
	private AmongUsLoadingBar loadingBar;

	public void ToggleLoadingBar(bool on)
	{
	}

	public void SetLoadingPercent(float percent, StringNames loadText)
	{
	}
}
