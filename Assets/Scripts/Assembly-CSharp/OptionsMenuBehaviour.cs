using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OptionsMenuBehaviour : MonoBehaviour, ITranslatedText
{
	private const string ControlTypeKey = "Options.ControlType";

	private const string JoystickSizeKey = "Options.JoystickSize";

	private const string SfxVolumeKey = "Options.SfxVolume";

	private const string MusicVolumeKey = "Options.MusicVolume";

	private const string CensorChatKey = "Options.CensorChat";

	private const string MouseMovementKey = "Options.MouseMovement";

	private const string FriendInvitesKey = "Options.FriendInvites";

	private const string StreamerModeKey = "Options.StreamerMode";

	private const string ColorBlindKey = "Options.ColorBlind";

	public SpriteRenderer Background;

	public SpriteRenderer JoystickButton;

	public SpriteRenderer TouchButton;

	public SlideBar JoystickSizeSlider;

	public FloatRange JoystickSizes = new FloatRange(0.5f, 1.5f);

	public SlideBar SoundSlider;

	public SlideBar MusicSlider;

	public ToggleButtonBehaviour CensorChatButton;

	public ToggleButtonBehaviour DisableMouseMovement;

	public ToggleButtonBehaviour EnableFriendInvitesButton;

	public ToggleButtonBehaviour ColorBlindButton;

	public GameObject KeyboardOptions;

	public GameObject MouseAndKeyboardOptions;

	public ToggleButtonBehaviour StreamerModeButton;

	public GameObject TermsOfUsePlayStationPopup;

	public TextMeshPro TermsOfUsePlayStationEULAText;

	public BugReportPopup bugReportPopup;

	public bool Toggle = true;

	public TabGroup[] Tabs;

	public PassiveButton MenuButton;

	private bool grabbedControllerButtons;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	public List<UiElement> IgnoreControllerSelection;

	private bool couldMove;

	private float lastOpenTime = -1f;

	public bool IsOpen => base.gameObject.activeInHierarchy;

	public void OpenTabGroup(int index)
	{
		if (Tabs == null || Tabs.Length == 0)
		{
			return;
		}
		index = Mathf.Clamp(index, 0, Tabs.Length - 1);
		OpenTabGroup(Tabs[index]);
	}

	public void OpenTabGroup(TabGroup selected)
	{
		if (selected == null || Tabs == null)
		{
			return;
		}
		selected.Open();
		for (int i = 0; i < Tabs.Length; i++)
		{
			TabGroup tabGroup = Tabs[i];
			if (tabGroup != null && tabGroup != selected)
			{
				tabGroup.Close();
			}
		}
	}

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			Close();
		}
	}

	public void Start()
	{
		if (DestroyableSingleton<TranslationController>.InstanceExists)
		{
			DestroyableSingleton<TranslationController>.Instance.ActiveTexts.Add(this);
		}
		GrabControllerButtons();
		UpdateButtons();
	}

	private void GrabControllerButtons()
	{
		if (grabbedControllerButtons)
		{
			return;
		}
		grabbedControllerButtons = true;
		if (ControllerSelectable == null)
		{
			ControllerSelectable = new List<UiElement>();
		}
		foreach (UiElement uiElement in GetComponentsInChildren<UiElement>(true))
		{
			if (uiElement == null || uiElement == BackButton || ControllerSelectable.Contains(uiElement))
			{
				continue;
			}
			if (IgnoreControllerSelection != null && IgnoreControllerSelection.Contains(uiElement))
			{
				continue;
			}
			ControllerSelectable.Add(uiElement);
		}
	}

	private void OnDisable()
	{
		if ((bool)PlayerControl.LocalPlayer && !PlayerControl.LocalPlayer.moveable)
		{
			PlayerControl.LocalPlayer.moveable = couldMove;
		}
	}

	public void OnDestroy()
	{
		if (DestroyableSingleton<TranslationController>.InstanceExists)
		{
			DestroyableSingleton<TranslationController>.Instance.ActiveTexts.Remove(this);
		}
	}

	public void ResetText()
	{
		if (CensorChatButton != null)
		{
			CensorChatButton.ResetText();
		}
		if (DisableMouseMovement != null)
		{
			DisableMouseMovement.ResetText();
		}
		if (EnableFriendInvitesButton != null)
		{
			EnableFriendInvitesButton.ResetText();
		}
		if (ColorBlindButton != null)
		{
			ColorBlindButton.ResetText();
		}
		if (StreamerModeButton != null)
		{
			StreamerModeButton.ResetText();
		}
	}

	public void Open()
	{
		ResetText();
		if (base.gameObject.activeSelf)
		{
			if (Time.unscaledTime - lastOpenTime < 0.1f)
			{
				return;
			}
			if (Toggle)
			{
				TransitionOpen transitionOpen = GetComponent<TransitionOpen>();
				if (transitionOpen != null)
				{
					transitionOpen.Close();
				}
				else
				{
					Close();
				}
			}
			return;
		}
		lastOpenTime = Time.unscaledTime;
		if ((bool)PlayerControl.LocalPlayer)
		{
			couldMove = PlayerControl.LocalPlayer.moveable;
			PlayerControl.LocalPlayer.moveable = false;
		}
		if (Tabs != null && Tabs.Length > 0)
		{
			OpenTabGroup(0);
		}
		UpdateButtons();
		base.gameObject.SetActive(value: true);
		GrabControllerButtons();
		if (ControllerManager.Instance != null && DefaultButtonSelected != null)
		{
			ControllerManager.Instance.SetCurrentSelected(DefaultButtonSelected);
		}
	}

	public void SetControlType(int i)
	{
		PlayerPrefs.SetInt(ControlTypeKey, i);
		PlayerPrefs.Save();
		UpdateButtons();
		if (DestroyableSingleton<HudManager>.InstanceExists)
		{
			DestroyableSingleton<HudManager>.Instance.SetTouchType((ControlTypes)i);
		}
	}

	public void UpdateJoystickSize()
	{
		if (JoystickSizeSlider == null || JoystickSizes == null)
		{
			return;
		}
		float joystickSize = JoystickSizes.Lerp(JoystickSizeSlider.Value);
		PlayerPrefs.SetFloat(JoystickSizeKey, joystickSize);
		PlayerPrefs.Save();
		if (DestroyableSingleton<HudManager>.InstanceExists)
		{
			DestroyableSingleton<HudManager>.Instance.SetJoystickSize(joystickSize);
		}
	}

	public void UpdateSfxVolume()
	{
		if (SoundSlider == null)
		{
			return;
		}
		PlayerPrefs.SetFloat(SfxVolumeKey, SoundSlider.Value);
		PlayerPrefs.Save();
		AudioListener.volume = Mathf.Clamp01(Mathf.Max(SoundSlider.Value, GetMusicVolume()));
	}

	public void UpdateMusicVolume()
	{
		if (MusicSlider == null)
		{
			return;
		}
		PlayerPrefs.SetFloat(MusicVolumeKey, MusicSlider.Value);
		PlayerPrefs.Save();
		AudioListener.volume = Mathf.Clamp01(Mathf.Max(MusicSlider.Value, GetSfxVolume()));
	}

	public void OpenPrivacyPolicy()
	{
		Constants.OpenURL(Constants.PrivacyPolicyURL);
	}

	public void OpenTermsOfUse()
	{
		if (TermsOfUsePlayStationPopup != null)
		{
			TermsOfUsePlayStationPopup.SetActive(value: true);
		}
		else
		{
			ReallyOpenTermsOfUse();
		}
	}

	public void ReallyOpenTermsOfUse()
	{
		if (TermsOfUsePlayStationPopup != null)
		{
			TermsOfUsePlayStationPopup.SetActive(value: false);
		}
		Constants.OpenURL(Constants.TermsOfUseURL);
	}

	public void TogglePersonalizedAd()
	{
		PlayerPrefs.SetInt("Options.PersonalizedAds", PlayerPrefs.GetInt("Options.PersonalizedAds", 1) == 1 ? 0 : 1);
		PlayerPrefs.Save();
		UpdateButtons();
	}

	public void ToggleCensorChat()
	{
		SetBool(CensorChatKey, !GetBool(CensorChatKey, true));
		UpdateButtons();
	}

	public void ToggleFriendsListInvites()
	{
		SetBool(FriendInvitesKey, !GetBool(FriendInvitesKey, true));
		UpdateButtons();
	}

	public void ToggleMouseMovement()
	{
		SetBool(MouseMovementKey, !GetBool(MouseMovementKey, false));
		UpdateButtons();
	}

	public void ToggleStreamerMode()
	{
		SetBool(StreamerModeKey, !GetBool(StreamerModeKey, false));
		UpdateButtons();
	}

	public void ToggleColorBlind()
	{
		SetBool(ColorBlindKey, !GetBool(ColorBlindKey, false));
		UpdateButtons();
	}

	public void OpenBugReportPopup()
	{
		if (bugReportPopup != null)
		{
			bugReportPopup.gameObject.SetActive(value: true);
		}
	}

	public void UpdateButtons()
	{
		int controlType = PlayerPrefs.GetInt(ControlTypeKey, (int)ControlTypes.Keyboard);
		bool touchMode = controlType == (int)ControlTypes.VirtualJoystick || controlType == (int)ControlTypes.ScreenJoystick;
		SetSelected(JoystickButton, touchMode);
		SetSelected(TouchButton, !touchMode);
		if (KeyboardOptions != null)
		{
			KeyboardOptions.SetActive(!touchMode);
		}
		if (MouseAndKeyboardOptions != null)
		{
			MouseAndKeyboardOptions.SetActive(!touchMode);
		}
		if (JoystickSizeSlider != null)
		{
			JoystickSizeSlider.enabled = touchMode;
			if (touchMode)
			{
				JoystickSizeSlider.ReEnable();
			}
			else
			{
				JoystickSizeSlider.SetDisabledColors();
			}
			float joystickSize = PlayerPrefs.GetFloat(JoystickSizeKey, 1f);
			JoystickSizeSlider.Value = JoystickSizes != null ? JoystickSizes.ReverseLerp(joystickSize) : joystickSize;
			JoystickSizeSlider.UpdateValue();
		}
		if (SoundSlider != null)
		{
			SoundSlider.Value = GetSfxVolume();
			SoundSlider.UpdateValue();
		}
		if (MusicSlider != null)
		{
			MusicSlider.Value = GetMusicVolume();
			MusicSlider.UpdateValue();
		}
		if (CensorChatButton != null)
		{
			CensorChatButton.UpdateText(GetBool(CensorChatKey, true));
		}
		if (DisableMouseMovement != null)
		{
			DisableMouseMovement.UpdateText(GetBool(MouseMovementKey, false));
		}
		if (EnableFriendInvitesButton != null)
		{
			EnableFriendInvitesButton.UpdateText(GetBool(FriendInvitesKey, true));
		}
		if (StreamerModeButton != null)
		{
			StreamerModeButton.UpdateText(GetBool(StreamerModeKey, false));
		}
		if (ColorBlindButton != null)
		{
			ColorBlindButton.UpdateText(GetBool(ColorBlindKey, false));
		}
	}

	public void Close()
	{
		if ((bool)PlayerControl.LocalPlayer && !PlayerControl.LocalPlayer.moveable)
		{
			PlayerControl.LocalPlayer.moveable = couldMove;
		}
		base.gameObject.SetActive(value: false);
	}

	private static void SetSelected(SpriteRenderer spriteRenderer, bool selected)
	{
		if (spriteRenderer != null)
		{
			spriteRenderer.color = selected ? new Color32(0, byte.MaxValue, 42, byte.MaxValue) : Color.white;
		}
	}

	private static bool GetBool(string key, bool defaultValue)
	{
		return PlayerPrefs.GetInt(key, defaultValue ? 1 : 0) != 0;
	}

	private static void SetBool(string key, bool value)
	{
		PlayerPrefs.SetInt(key, value ? 1 : 0);
		PlayerPrefs.Save();
	}

	private static float GetSfxVolume()
	{
		return PlayerPrefs.GetFloat(SfxVolumeKey, 0.6f);
	}

	private static float GetMusicVolume()
	{
		return PlayerPrefs.GetFloat(MusicVolumeKey, 0.6f);
	}
}
