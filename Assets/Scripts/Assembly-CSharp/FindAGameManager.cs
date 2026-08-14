using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AmongUs.GameOptions;
using AmongUs.Matchmaking;
using InnerNet;
using TMPro;
using UnityEngine;

public class FindAGameManager : DestroyableSingleton<FindAGameManager>, IGameListHandler, IConnectButton
{
	private class GameSorter : IComparer<GameListing>
	{
		public static readonly GameSorter Instance;

		public int Compare(GameListing x, GameListing y)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCoShow_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FindAGameManager _003C_003E4__this;

		public Vector3 startPos;

		public Vector3 endPos;

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
		public _003CCoShow_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CRefreshListCo_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FindAGameManager _003C_003E4__this;

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
		public _003CRefreshListCo_003Ed__66(int _003C_003E1__state)
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
	private FilterPopUp filterPopUp;

	[SerializeField]
	private ServerDropdown serverDropdown;

	[SerializeField]
	private PassiveButton serverButton;

	[SerializeField]
	private TextMeshPro[] serverTexts;

	[SerializeField]
	private GameContainer[] gameContainers;

	[SerializeField]
	private PassiveButton refreshButton;

	[SerializeField]
	private GameObject animLoad;

	[SerializeField]
	private FindGameMoreInfoPopup findGameMoreInfoPopUp;

	[SerializeField]
	private GameObject clearFilterPop;

	[SerializeField]
	private TextMeshPro[] filtersFoundNums;

	[SerializeField]
	private TextMeshPro matchesFoundText;

	[SerializeField]
	private AudioClip findGameSFX;

	[SerializeField]
	private AudioClip foundGameSFX;

	[SerializeField]
	private Transform container;

	[SerializeField]
	private TextMeshPro modeText;

	[SerializeField]
	private PassiveButton clearFilterButton;

	public TextMeshPro TotalText;

	private const float RefreshTimeSeconds = 1f;

	private float timer;

	private Coroutine refreshFilterCoroutine;

	private bool animating;

	private GameFilterSet classicFilterSet;

	private GameFilterSet hnsFilterSet;

	private const string MAP_FILTER_NAME = "Map";

	private const string LANGUAGE_FILTER_NAME = "Language";

	private const string CHAT_FILTER_NAME = "Chat";

	private const string CROSSPLAY_FILTER_NAME = "Crossplay";

	private const float WAIT_FILTER_REFRESH = 1f;

	private const float WAIT_SLIDE_INTRO = 0.3f;

	private const float Y_POS_OFFSET = -9f;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	private readonly Logger logger;

	public void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CCoShow_003Ed__35))]
	private IEnumerator CoShow(Vector3 startPos, Vector3 endPos)
	{
		return null;
	}

	public MapGameFilter GetMapFilter()
	{
		return null;
	}

	public void ResetTimer()
	{
	}

	private void ResetContainers()
	{
	}

	private void SetLanguage()
	{
	}

	private void SetChatRestriction()
	{
	}

	public void UpdateFiltersTexts()
	{
	}

	public int GetRealFilterCount()
	{
		return 0;
	}

	private int GetFilterCount()
	{
		return 0;
	}

	public void UpdateGameModeText()
	{
	}

	public GameModes GetGameMode()
	{
		return default(GameModes);
	}

	private void SetCurrentServer()
	{
	}

	public void OpenServerDropdown()
	{
	}

	private void CloseServerDropdown()
	{
	}

	private void UpdateServerText(string text)
	{
	}

	public void Update()
	{
	}

	private void SetRefresh(bool isActive)
	{
	}

	public void OpenMorePopUp(GameListing gameL)
	{
	}

	public void SetFilterPopUp(bool isOn)
	{
	}

	public void OpenFilterClear()
	{
	}

	public void ClearAllFilters()
	{
	}

	public void RefreshList()
	{
	}

	public GameFilterSet GetFilterSet()
	{
		return null;
	}

	public void UpdateFilterSets()
	{
	}

	public override void OnDestroy()
	{
	}

	public void HandleList(InnerNetClient.TotalGameData totalGames, HttpMatchmakerManager.FindGamesListFilteredResponse response)
	{
	}

	public void ExitGame()
	{
	}

	public void StartIcon()
	{
	}

	public void StopIcon()
	{
	}

	public void FilterModified()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshListCo_003Ed__66))]
	private IEnumerator RefreshListCo()
	{
		return null;
	}

	public void AddBoolFilterValue(bool value, string key, BoolOptionNames boolOptionNames)
	{
	}

	public void RemoveBoolFilterValue(bool value, string key, BoolOptionNames boolOptionNames)
	{
	}

	public void AddIntFilterValue(int value, string key, Int32OptionNames intOptionName)
	{
	}

	public void RemoveIntFilterValue(int value, string key, Int32OptionNames intOptionName)
	{
	}

	public void AddCatFilterValue(int value, string key, CategorizedOptionNames catFilterName)
	{
	}

	public void RemoveCatFilterValue(int value, string key, CategorizedOptionNames catFilterName)
	{
	}

	public void SetMapFilter(byte mapByte)
	{
	}

	public void RemoveMapFilter()
	{
	}

	public void AddLangFilterValue(uint value, bool refreshList = true)
	{
	}

	public uint GetLangFilter()
	{
		return 0u;
	}

	public void AddChatFilterValue(QuickChatModes mode, bool refreshList = true)
	{
	}

	public void AddCrossplayFilterValue(uint mode, bool refreshList = true)
	{
	}

	public int GetChatFilter()
	{
		return 0;
	}
}
