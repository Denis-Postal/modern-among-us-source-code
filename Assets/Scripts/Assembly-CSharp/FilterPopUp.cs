using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AmongUs.GameOptions;
using AmongUs.Matchmaking;
using TMPro;
using UnityEngine;

public class FilterPopUp : MonoBehaviour
{
	public class FilterInfoUI
	{
		public enum FilterName
		{
			PlayerSpeed = 0,
			KillCooldown = 1,
			VotingTime = 2,
			VisualTasks = 3,
			AnonymousVotes = 4,
			ConfirmEjects = 5,
			Tag = 6,
			CrossPlay = 7,
			Roles = 8,
			ImpostorNumber = 9,
			FlashlightMode = 10,
			HidingTime = 11,
			FinalHideTime = 12,
			MaxVentUses = 13
		}

		public FilterName myFilterName;

		public int ButtonCount;

		public List<string> buttonTexts;

		public FilterOptionUI.ButtonSize ButtonSize;

		public StringNames stringName;

		public BoolOptionNames BoolOptionN;

		public Int32OptionNames Int32OptionN;

		public CategorizedOptionNames CatOptionName;

		public int tooltipIndex;

		public string ExtraInfoString;

		public string GetFilterType()
		{
			return null;
		}

		public void Init(FilterName filterName)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCloseCo_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FilterPopUp _003C_003E4__this;

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
		public _003CCloseCo_003Ed__59(int _003C_003E1__state)
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
	private sealed class _003CSetTooltipCo_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FilterPopUp _003C_003E4__this;

		public int index;

		public int highlightIndex;

		public string extraInfo;

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
		public _003CSetTooltipCo_003Ed__64(int _003C_003E1__state)
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
	private sealed class _003CShowCo_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FilterPopUp _003C_003E4__this;

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
		public _003CShowCo_003Ed__57(int _003C_003E1__state)
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
	private FilterMapPicker mapPicker;

	[SerializeField]
	private BaseGameSetting mapSetting;

	[SerializeField]
	private Scroller scrollBar;

	[SerializeField]
	private Scroller scrollBarChat;

	[SerializeField]
	private FilterOptionUI filterButtonPrefab;

	[SerializeField]
	private Transform container;

	[SerializeField]
	private PassiveButton[] modeButtons;

	[SerializeField]
	private PassiveButton[] crossPlayButtons;

	[SerializeField]
	private PassiveButton[] tabButtons;

	[SerializeField]
	private PassiveButton[] chatTypeButtons;

	[SerializeField]
	private FilterOptionUI modeFilterOptionUI;

	[SerializeField]
	private FilterOptionUI crossPlayOptionUI;

	[SerializeField]
	private FilterOptionUI chatOptionUI;

	[SerializeField]
	private GameObject generalContainer;

	[SerializeField]
	private GameObject chatContainer;

	[SerializeField]
	private LanguagePicker langPicker;

	[SerializeField]
	private TextMeshPro tooltip;

	[SerializeField]
	private TextMeshPro tooltipExtraInfo;

	[SerializeField]
	private GameObject tooltipExtraBox;

	[SerializeField]
	private StringNames[] tooltipStrings;

	[SerializeField]
	private AspectPosition aspectPosition;

	[SerializeField]
	private TextMeshPro mapNames;

	[SerializeField]
	private TextMeshPro mapNameTitle;

	[SerializeField]
	private List<SpriteRenderer> blackSquares;

	[SerializeField]
	private Color boxColor;

	[SerializeField]
	private Color boxhighlightColor;

	[SerializeField]
	private TextMeshPro chatWarningText;

	[SerializeField]
	private GameObject filtersActiveText;

	[SerializeField]
	private GameObject maxFiltersText;

	[SerializeField]
	private GameObject numFiltersText;

	private List<FilterOptionUI> classicChildren;

	private List<FilterOptionUI> hnsChildren;

	private const float START_POS_Y = -0.1f;

	private const float START_POS_X = 0.44f;

	private const float SPACING_Y = 0.45f;

	private const float HEADER_HEIGHT = 0.65f;

	private const float WAIT_TOOLTIP_TIME = 0.3f;

	private const float ANCHOR_POSX = 0.1f;

	private const float ANCHOR_OFFSET_X = 0.89f;

	private const float WAIT_TIME_SLIDE = 0.3f;

	private float scrollerHeightClassic;

	private float scrollerHeightHnS;

	private List<FilterInfoUI> filtersClassic;

	private List<FilterInfoUI> filtersHnS;

	private Coroutine changeTooltipCo;

	private bool animating;

	private static readonly int STENCIL_COMP;

	private static readonly int STENCIL;

	private const int MASK_LAYER = 51;

	private const float Y_POS_LANGPICKER_NORMAL = 1.38f;

	private const float Y_POS_LANGPICKER_WARNING = 0.58f;

	private const int FILTER_LIMIT = 8;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CShowCo_003Ed__57))]
	private IEnumerator ShowCo()
	{
		return null;
	}

	public void CloseFilter()
	{
	}

	[IteratorStateMachine(typeof(_003CCloseCo_003Ed__59))]
	private IEnumerator CloseCo()
	{
		return null;
	}

	private void ResetHoverStateButtons()
	{
	}

	private void OnDisable()
	{
	}

	private void SetLanguage(uint lang)
	{
	}

	private void SetLangTooltip(bool isActive)
	{
	}

	[IteratorStateMachine(typeof(_003CSetTooltipCo_003Ed__64))]
	private IEnumerator SetTooltipCo(int index, int highlightIndex, string extraInfo = "")
	{
		return null;
	}

	private void ForceDefaultTooltip()
	{
	}

	private void SetMapTooltip(int index)
	{
	}

	public void SetModePublic(int i)
	{
	}

	private void SetMode(int i)
	{
	}

	public void SetTooltipModes(int index)
	{
	}

	public void SetTooltipChat(int index)
	{
	}

	public void SetTooltipCrossplay(int index)
	{
	}

	public void SetTooltip(int index, int highlightIndex, string extraInfo = "")
	{
	}

	public void HighlightBox(int index)
	{
	}

	private void SetExtraInfoTooltip(string infoString)
	{
	}

	public void SelectTab(bool isGeneral)
	{
	}

	public void SetCrossplayFilter(bool allPlatforms)
	{
	}

	private void SetUpMapButtonsNav()
	{
	}

	private void SetUpLangButtonsNav()
	{
	}

	private void CheckChatType()
	{
	}

	public void SetChatType(bool isFreeChat)
	{
	}

	private void CreateButtons(bool isClassic)
	{
	}

	public void ResetFilterSelection()
	{
	}

	private void InitializeControllerNavigation(bool isClassic)
	{
	}

	private void ClickFilterOption(bool isSelected, int index, FilterInfoUI filterInfo)
	{
	}

	private void CheckFilterLimit()
	{
	}

	private UiElement FindNextFilterAvailable(GameModes gameMode)
	{
		return null;
	}

	public void SetupFilters(PermittedFilters filters)
	{
	}
}
