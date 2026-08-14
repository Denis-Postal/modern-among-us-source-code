using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class GameSettingMenu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoSelectDefault_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameSettingMenu _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCoSelectDefault_003Ed__18(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public static GameSettingMenu Instance;

	[SerializeField]
	private PassiveButton GamePresetsButton;

	[SerializeField]
	private PassiveButton GameSettingsButton;

	[SerializeField]
	private PassiveButton RoleSettingsButton;

	[SerializeField]
	private GamePresetsTab PresetsTab;

	[SerializeField]
	private GameOptionsMenu GameSettingsTab;

	[SerializeField]
	private RolesSettingsMenu RoleSettingsTab;

	[SerializeField]
	private TextMeshPro MenuDescriptionText;

	[SerializeField]
	private GameObject LeftSideDarkener;

	[SerializeField]
	private GameObject RightSideDarkener;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	public void Close()
	{
		if ((bool)PlayerControl.LocalPlayer)
		{
			PlayerControl.LocalPlayer.moveable = true;
		}
		if (Instance == this)
		{
			Instance = null;
		}
		CleanupMenu();
		Destroy(base.gameObject);
	}

	private void Start()
	{
		DestroyDuplicateMenus();
		Instance = this;
		InstallTextRenderers();
		ChangeTab(1, previewOnly: false);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Close();
		}
	}

	private void OnEnable()
	{
		Instance = this;
		InstallTextRenderers();
	}

	private void OnDisable()
	{
		CleanupMenu();
		if (Instance == this)
		{
			Instance = null;
		}
	}

	private void OnDestroy()
	{
		CleanupMenu();
		if (Instance == this)
		{
			Instance = null;
		}
	}

	[IteratorStateMachine(typeof(_003CCoSelectDefault_003Ed__18))]
	private IEnumerator CoSelectDefault()
	{
		return null;
	}

	public void ChangeTab(int tabNum, bool previewOnly)
	{
		if (previewOnly)
		{
			return;
		}
		bool presets = tabNum == 0;
		bool settings = tabNum == 1;
		bool roles = tabNum == 2;
		if ((bool)PresetsTab)
		{
			PresetsTab.gameObject.SetActive(presets);
			if (presets)
			{
				PresetsTab.OpenMenu();
			}
		}
		if ((bool)GameSettingsTab)
		{
			GameSettingsTab.gameObject.SetActive(settings);
			if (settings)
			{
				GameSettingsTab.OpenMenu();
			}
		}
		if ((bool)RoleSettingsTab)
		{
			RoleSettingsTab.gameObject.SetActive(roles);
		}
		ToggleLeftSideDarkener(!settings);
		ToggleRightSideDarkener(!roles);
	}

	private void ToggleLeftSideDarkener(bool on)
	{
		if ((bool)LeftSideDarkener)
		{
			LeftSideDarkener.SetActive(on);
		}
	}

	private void ToggleRightSideDarkener(bool on)
	{
		if ((bool)RightSideDarkener)
		{
			RightSideDarkener.SetActive(on);
		}
	}

	public void CloseTab()
	{
		ChangeTab(1, previewOnly: false);
	}

	private void InstallTextRenderers()
	{
		TMP_Text[] texts = GetComponentsInChildren<TMP_Text>(true);
		for (int i = 0; i < texts.Length; i++)
		{
			TMP_Text textMeshPro = texts[i];
			if (textMeshPro == null)
			{
				continue;
			}
			TMPTextRendererBridge bridge = textMeshPro.GetComponent<TMPTextRendererBridge>();
			if (bridge == null)
			{
				bridge = textMeshPro.gameObject.AddComponent<TMPTextRendererBridge>();
			}
			bridge.Source = textMeshPro;
			bridge.Font = TextRenderer.TextFont.MainMenuOutline;
			bridge.SizeMultiplier = 1f;
			bridge.CharacterSpacing = 0.02f;
			bridge.ForceSync();
		}
	}

	private void DestroyDuplicateMenus()
	{
		GameSettingMenu[] menus = Resources.FindObjectsOfTypeAll<GameSettingMenu>();
		for (int i = 0; i < menus.Length; i++)
		{
			if (menus[i] != null && menus[i] != this && menus[i].gameObject.scene.IsValid())
			{
				menus[i].CleanupMenu();
				Destroy(menus[i].gameObject);
			}
		}
	}

	private void CleanupMenu()
	{
		if ((bool)GameSettingsTab)
		{
			GameSettingsTab.CleanupGeneratedSettings();
		}
		if ((bool)PresetsTab)
		{
			PresetsTab.CloseMenu();
		}
		if ((bool)RoleSettingsTab)
		{
			RoleSettingsTab.gameObject.SetActive(false);
		}
	}
}
