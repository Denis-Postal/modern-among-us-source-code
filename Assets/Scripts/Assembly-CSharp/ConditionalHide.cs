using UnityEngine;

public class ConditionalHide : MonoBehaviour
{
	public RuntimePlatform[] HideForPlatforms;

	public RuntimePlatform[] OnlyShowForPlatforms;

	public bool ShowIfXboxTouchEnabled;

	private void Awake()
	{
	}

	public void Hide()
	{
	}
}
