using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AmongUs.GameOptions;
using TMPro;
using UnityEngine;

public class CreateGameOptions : MonoBehaviour, IConnectButton
{
	[CompilerGenerated]
	private sealed class _003CCoHide_003Ed__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CreateGameOptions _003C_003E4__this;

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
		public _003CCoHide_003Ed__99(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoShow_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CreateGameOptions _003C_003E4__this;

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
		public _003CCoShow_003Ed__65(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CContinueCoStart_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CreateGameOptions _003C_003E4__this;

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
		public _003CContinueCoStart_003Ed__107(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003COpenConfirmPopupCo_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CreateGameOptions _003C_003E4__this;

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
		public _003COpenConfirmPopupCo_003Ed__102(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CSetTooltipCo_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CreateGameOptions _003C_003E4__this;

		public int index;

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
		public _003CSetTooltipCo_003Ed__77(int _003C_003E1__state)
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

	[SerializeField]
	private GameObject AprilFoolsToggle;

	[SerializeField]
	private MainMenuManager mainMenuManager;

	[SerializeField]
	private GameObject content;

	[SerializeField]
	private SpriteRenderer foreground;

	[SerializeField]
	private TextMeshPro tooltip;

	[SerializeField]
	private Transform crewmatesContainer;

	[SerializeField]
	private GameObject[] skeldCrewSprites;

	[SerializeField]
	private GameObject[] polusCrewSprites;

	[SerializeField]
	private GameObject[] miraCrewSprites;

	[SerializeField]
	private GameObject[] airshipCrewSprites;

	[SerializeField]
	private GameObject[] fungleCrewSprites;

	[SerializeField]
	private Sprite[] bgCrewmates;

	[SerializeField]
	private SpriteRenderer rendererBGCrewmates;

	[SerializeField]
	private SpriteRenderer mapBanner;

	[SerializeField]
	private Sprite[] mapBanners;

	[SerializeField]
	private ServerDropdown serverDropdown;

	[SerializeField]
	private TextMeshPro[] serverTexts;

	[SerializeField]
	private GameObject serverButton;

	[SerializeField]
	private IntGameSetting capacitySetting;

	[SerializeField]
	private BaseGameSetting mapSetting;

	[SerializeField]
	private CreateGameMapPicker mapPicker;

	[SerializeField]
	private NumberOption capacityOption;

	[SerializeField]
	private StringNames[] tooltipStrings;

	[SerializeField]
	private StringNames[] mapTooltips;

	[SerializeField]
	private PassiveButton[] tabButtons;

	[SerializeField]
	private GameObject[] contentObjects;

	[SerializeField]
	private PassiveButton[] modeButtons;

	[SerializeField]
	private PassiveButton[] levelButtons;

	[SerializeField]
	private PassiveButton[] crossPlayButtons;

	[SerializeField]
	private PassiveButton[] aprilFoolButtons;

	[SerializeField]
	private PassiveButton[] chatTypeButtons;

	[SerializeField]
	private PassiveButton minusButtonCapacity;

	[SerializeField]
	private PassiveButton plusButtonCapacity;

	[SerializeField]
	private GameObject confirmPopUp;

	[SerializeField]
	private Transform containerConfirm;

	[SerializeField]
	private LanguagePicker langPicker;

	[SerializeField]
	private TextMeshPro chatDescText;

	[SerializeField]
	private TextMeshPro chatWarningText;

	[SerializeField]
	private GameObject loadAnim;

	[SerializeField]
	private FilterOptionUI chatOptionUI;

	[SerializeField]
	private Scroller scrollBar;

	private int currentTag;

	private Coroutine changeTooltipCo;

	private bool animating;

	private int currentDefaultTooltip;

	private const float Y_POS_LANGPICKER_NORMAL = 0.84f;

	private const float Y_POS_LANGPICKER_WARNING = 0.14f;

	private const float SCROLLER_HEIGHT = 3f;

	private const float Y_POS_APRILFOOLS = -3.4f;

	private const float WAIT_TOOLTIP_TIME = 0.3f;

	private const float CREWMATE_SLIDE_TIME = 0.3f;

	private const float POPUP_SLIDE_TIME = 0.3f;

	private const float X_OFFSET_LEFT = -7f;

	private const float X_CREWMATES_POS = 0f;

	private const float Y_BOTTOM_POS = -14f;

	private GameObject[] currentCrewSprites;

	private static readonly int STENCIL_COMP;

	private static readonly int STENCIL;

	private const int MASK_LAYER = 51;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	private readonly Logger logger;

	private void Start()
	{
	}

	public void Show()
	{
	}

	[IteratorStateMachine(typeof(_003CCoShow_003Ed__65))]
	private IEnumerator CoShow()
	{
		return null;
	}

	private void ResetHoverStateButtons()
	{
	}

	private void SetUpMapButtonsNav()
	{
	}

	private void SetUpLangButtonsNav()
	{
	}

	private void MapChanged(OptionBehaviour behaviour)
	{
	}

	private void TurnOffCrewmates()
	{
	}

	public void OpenTab(bool isGeneral)
	{
	}

	public void SetLanguage(uint lang)
	{
	}

	private void SetCurrentServer()
	{
	}

	private void SetLangTooltip(bool isActive)
	{
	}

	private void ForceTooltipChange(int index)
	{
	}

	public void SetTooltip(int index)
	{
	}

	[IteratorStateMachine(typeof(_003CSetTooltipCo_003Ed__77))]
	private IEnumerator SetTooltipCo(int index)
	{
		return null;
	}

	private void SetMapTooltip(int index)
	{
	}

	public float GetCapacity()
	{
		return 0f;
	}

	private void UpdateServerText(string text)
	{
	}

	public void OpenServerDropdown()
	{
	}

	public void CloseServerDropdown()
	{
	}

	private void ValueChanged(OptionBehaviour option)
	{
	}

	private void SetCrewmateGraphic(float capacity)
	{
	}

	public void SetCrossPlay(bool crossplay)
	{
	}

	private void CheckChatType()
	{
	}

	public void SetChatType(bool isFreeChat)
	{
	}

	public void SetAprilFool(bool isOn)
	{
	}

	public void SetModeButton(int i)
	{
	}

	public void SetTag(int i)
	{
	}

	public string GetLevelString()
	{
		return null;
	}

	private void SelectMode(int i, bool saveSetting = true)
	{
	}

	private void SwitchOptions(GameModes gameMode)
	{
	}

	private void SetGameMode(GameModes mode)
	{
	}

	private void OnDisable()
	{
	}

	public void StartIcon()
	{
	}

	public void StopIcon()
	{
	}

	public void Close()
	{
	}

	[IteratorStateMachine(typeof(_003CCoHide_003Ed__99))]
	private IEnumerator CoHide()
	{
		return null;
	}

	public void OpenConfirmPopup()
	{
	}

	public void CloseConfirmPopup()
	{
	}

	[IteratorStateMachine(typeof(_003COpenConfirmPopupCo_003Ed__102))]
	private IEnumerator OpenConfirmPopupCo()
	{
		return null;
	}

	public void Confirm()
	{
	}

	private void CoStartGame()
	{
	}

	private void NotOnlinePermissions()
	{
	}

	private void ContinueStart()
	{
	}

	[IteratorStateMachine(typeof(_003CContinueCoStart_003Ed__107))]
	private IEnumerator ContinueCoStart()
	{
		return null;
	}
}
