using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class AnnouncementPopUp : MonoBehaviour
{
	public enum AnnounceState
	{
		NotStarted = 0,
		Fetching = 1,
		Failed = 2,
		Success = 3,
		Cached = 4
	}

	[CompilerGenerated]
	private sealed class _003CDelayedUpdateHyperlinkPositions_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnnouncementPopUp _003C_003E4__this;

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
		public _003CDelayedUpdateHyperlinkPositions_003Ed__48(int _003C_003E1__state)
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
	private sealed class _003CInit_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnnouncementPopUp _003C_003E4__this;

		public bool forceOpen;

		private string _003Curi_003E5__2;

		private UnityWebRequest _003Crequest_003E5__3;

		private int _003Cattempts_003E5__4;

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
		public _003CInit_003Ed__46(int _003C_003E1__state)
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
	private sealed class _003CShowIfNew_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnnouncementPopUp _003C_003E4__this;

		public Action onDismissed;

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
		public _003CShowIfNew_003Ed__42(int _003C_003E1__state)
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

	private const float PANEL_HEIGHT = 0.8f;

	private const float SCROLL_OFFSET = 2.512f;

	private MainMenuManager mainMenuManager;

	private static AnnounceState UpdateState;

	[SerializeField]
	private GameObject ConnectIcon;

	[SerializeField]
	private AnnouncementPanel AnnouncementPanelPrefab;

	[SerializeField]
	private TextMeshPro Title;

	[SerializeField]
	private TextMeshPro SubTitle;

	[SerializeField]
	private TextMeshPro DateString;

	[SerializeField]
	private TextMeshPro AnnouncementBodyText;

	[SerializeField]
	private GameObject AnnouncementListSlider;

	[SerializeField]
	private Scroller TextScroller;

	[SerializeField]
	private Scroller ListScroller;

	[SerializeField]
	private ManualScrollHelper ManualScrollHelper;

	[SerializeField]
	private AnnouncementPanel ErrorPanel;

	[SerializeField]
	private GameObject ListStateHUD;

	[SerializeField]
	private GameObject ReadingStateHUD;

	[SerializeField]
	private NewsCountButton NewsCountButton;

	private const string READING_STATE_NAME = "Reading";

	private Vector3 panelStartPos;

	private int newestAnnouncement;

	private List<AnnouncementPanel> visibleAnnouncements;

	private AnnouncementPanel selectedPanel;

	private int selectedIndex;

	private Action OnDismissed;

	private readonly Logger logger;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement ReadingBackButton;

	private List<SelectableHyperLink> selectableHyperLinks;

	private bool readingAnnouncement;

	public event Action ActionOnDisable
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action ActionOnEnable
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void SetMainMenuManager(MainMenuManager mainMenu)
	{
	}

	private static bool IsSuccess(AnnounceState state)
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public static void ClearAnnouncementCache()
	{
	}

	[IteratorStateMachine(typeof(_003CShowIfNew_003Ed__42))]
	public IEnumerator ShowIfNew(Action onDismissed = null)
	{
		return null;
	}

	public void Show()
	{
	}

	private void SetMenu()
	{
	}

	public void Close()
	{
	}

	[IteratorStateMachine(typeof(_003CInit_003Ed__46))]
	private IEnumerator Init(bool forceOpen)
	{
		return null;
	}

	public void ReturnToList()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedUpdateHyperlinkPositions_003Ed__48))]
	private IEnumerator DelayedUpdateHyperlinkPositions()
	{
		return null;
	}

	private void ClearAnnouncements()
	{
	}

	private void CreateAnnouncementList()
	{
	}

	private void ShowError()
	{
	}

	private void UpdateAnnouncementText(int id, bool previewOnly = false)
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}
}
