using UnityEngine;

public class LobbyTimerExtensionUI : MonoBehaviour
{
	[SerializeField]
	private TimerTextTMP timerText;

	[SerializeField]
	private InfoTextBox popup;

	[SerializeField]
	private TimerTextTMP popupTimerText;

	[SerializeField]
	private AudioClip lobbyTimerPopUpSound;

	private string timerTextTemplate;

	private string popupTitleText;

	private string popupBodyTextTemplate;

	private void Awake()
	{
	}

	public void HideAll()
	{
	}

	public void ShowLobbyTimer(int timeRemainingSeconds)
	{
	}

	public void ShowLobbyTimerPopup(int timeRemainingSeconds, int timeGrantedSeconds)
	{
	}

	private void HideLobbyTimer()
	{
	}
}
