using System.Collections;
using InnerNet;
using PowerTools;
using UnityEngine;

public class HostLocalGameButton : MonoBehaviour, IConnectButton
{
	public AudioClip IntroMusic;

	public string targetScene = "OnlineGame";

	public SpriteRenderer FillScreen;

	public SpriteAnim connectIcon;

	public AnimationClip connectClip;

	public NetworkModes NetworkMode;

	public void Start()
	{
		if (DestroyableSingleton<MatchMaker>.InstanceExists)
		{
			DestroyableSingleton<MatchMaker>.Instance.NotConnecting();
		}
	}

	public void OnClick()
	{
		if (NetworkMode != NetworkModes.FreePlay && NameTextBehaviour.Instance != null && NameTextBehaviour.Instance.ShakeIfInvalid())
		{
			return;
		}
		if (NetworkMode == NetworkModes.FreePlay)
		{
			StartIcon();
			StartCoroutine(CoStartGame());
			return;
		}
		if (DestroyableSingleton<MatchMaker>.InstanceExists)
		{
			if (DestroyableSingleton<MatchMaker>.Instance.Connecting(this))
			{
				StartCoroutine(CoStartGame());
			}
			return;
		}
		StartIcon();
		StartCoroutine(CoStartGame());
	}

	private void FinishConnecting()
	{
		if (DestroyableSingleton<MatchMaker>.InstanceExists)
		{
			DestroyableSingleton<MatchMaker>.Instance.NotConnecting();
			return;
		}
		StopIcon();
	}

	public void StartIcon()
	{
		if ((bool)connectIcon)
		{
			connectIcon.Play(connectClip);
		}
	}

	public void StopIcon()
	{
		if ((bool)connectIcon)
		{
			connectIcon.Stop();
			SpriteRenderer component = connectIcon.GetComponent<SpriteRenderer>();
			if ((bool)component)
			{
				component.sprite = null;
			}
		}
	}

	public void ClickHideNSeek()
	{
		OnClick();
	}

	private IEnumerator CoStartGame()
	{
		if (SoundManager.Instance != null)
		{
			SoundManager.Instance.StopAllSound();
		}
		AmongUsClient.Instance.NetworkMode = NetworkMode;
		switch (NetworkMode)
		{
		case NetworkModes.LocalGame:
			StartLocalServerIfNeeded();
			AmongUsClient.Instance.SetEndpoint("127.0.0.1", 22023, false);
			AmongUsClient.Instance.MainMenuScene = "MatchMaking";
			break;
		case NetworkModes.OnlineGame:
			AmongUsClient.Instance.MainMenuScene = "MMOnline";
			break;
		case NetworkModes.FreePlay:
			AmongUsClient.Instance.MainMenuScene = "MainMenu";
			break;
		}
		yield return new WaitForSeconds(0.1f);
		if ((bool)FillScreen)
		{
			if (SoundManager.Instance != null)
			{
				SoundManager.Instance.CrossFadeSound("MainBG", null, 0.5f);
			}
			FillScreen.gameObject.SetActive(true);
			for (float time = 0f; time < 0.25f; time += Time.deltaTime)
			{
				FillScreen.color = Color.Lerp(Color.clear, Color.black, time / 0.25f);
				yield return null;
			}
			FillScreen.color = Color.black;
		}
		AmongUsClient.Instance.OnlineScene = NetworkMode == NetworkModes.FreePlay ? "Tutorial" : (string.IsNullOrEmpty(targetScene) ? "OnlineGame" : targetScene);
		AmongUsClient.Instance.Connect(MatchMakerModes.HostAndClient, null);
		yield return AmongUsClient.Instance.WaitForConnectionOrFail();
		FinishConnecting();
		if (AmongUsClient.Instance.mode != MatchMakerModes.None)
		{
			yield break;
		}
		if ((bool)FillScreen)
		{
			if (SoundManager.Instance != null)
			{
				SoundManager.Instance.CrossFadeSound("MainBG", IntroMusic, 0.5f);
			}
			for (float time2 = 0f; time2 < 0.25f; time2 += Time.deltaTime)
			{
				FillScreen.color = Color.Lerp(Color.black, Color.clear, time2 / 0.25f);
				yield return null;
			}
			FillScreen.color = Color.clear;
		}
		if (NetworkMode != NetworkModes.FreePlay && DestroyableSingleton<DisconnectPopup>.InstanceExists)
		{
			DestroyableSingleton<DisconnectPopup>.Instance.Show();
		}
	}

	private static void StartLocalServerIfNeeded()
	{
		try
		{
			DestroyableSingleton<InnerNetServer>.Instance.StartAsServer();
		}
		catch (System.Exception exception)
		{
			Debug.LogWarning("[Match] Local server could not start; continuing with host connect.");
			Debug.LogException(exception);
		}
	}
}
