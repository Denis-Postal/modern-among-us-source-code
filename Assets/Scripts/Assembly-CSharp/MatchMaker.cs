using System.Collections;
using InnerNet;
using UnityEngine;

public class MatchMaker : DestroyableSingleton<MatchMaker>
{
	public TextBoxTMP GameIdText;

	private MonoBehaviour Connecter;

	public void Start()
	{
		if ((bool)GameIdText && AmongUsClient.Instance != null)
		{
			GameIdText.SetText(GameCode.IntToGameName(AmongUsClient.Instance.GameId) ?? string.Empty);
		}
	}

	public bool Connecting<T>(T button) where T : MonoBehaviour, IConnectButton
	{
		if (!(bool)Connecter)
		{
			Connecter = button;
			((IConnectButton)Connecter).StartIcon();
			return true;
		}
		IEnumerator routine = Effects.SwayX(Connecter.transform);
		if (routine != null)
		{
			StartCoroutine(routine);
		}
		return false;
	}

	public void NotConnecting()
	{
		if ((bool)Connecter)
		{
			((IConnectButton)Connecter).StopIcon();
			Connecter = null;
		}
	}
}
