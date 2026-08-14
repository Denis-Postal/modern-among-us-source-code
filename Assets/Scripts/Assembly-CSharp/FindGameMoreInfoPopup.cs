using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using InnerNet;
using TMPro;
using UnityEngine;

public class FindGameMoreInfoPopup : MonoBehaviour, IConnectButton
{
	[CompilerGenerated]
	private sealed class _003CCoShow_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FindGameMoreInfoPopup _003C_003E4__this;

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
		public _003CCoShow_003Ed__36(int _003C_003E1__state)
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
	private TextMeshPro modeText;

	[SerializeField]
	private SpriteRenderer mapBackground;

	[SerializeField]
	private SpriteRenderer mapLogo;

	[SerializeField]
	private Sprite[] mapBackgroundSprites;

	[SerializeField]
	private Sprite[] mapLogoSprites;

	[SerializeField]
	private TextMeshPro capacity;

	[SerializeField]
	private GameObject classicFilters;

	[SerializeField]
	private GameObject hnsFilters;

	[SerializeField]
	private TextMeshPro impostorsText;

	[SerializeField]
	private TextMeshPro rolesText;

	[SerializeField]
	private TextMeshPro confirmEjectsText;

	[SerializeField]
	private TextMeshPro visualTaskText;

	[SerializeField]
	private TextMeshPro meetingTimeText;

	[SerializeField]
	private TextMeshPro anonVotesText;

	[SerializeField]
	private TextMeshPro killcooldownText;

	[SerializeField]
	private TextMeshPro playerSpeedText;

	[SerializeField]
	private TextMeshPro tagText;

	[SerializeField]
	private TextMeshPro flashlightText;

	[SerializeField]
	private TextMeshPro hidingTimeText;

	[SerializeField]
	private TextMeshPro finalHideText;

	[SerializeField]
	private TextMeshPro playerSpeedHnSText;

	[SerializeField]
	private TextMeshPro maxVentUsesText;

	[SerializeField]
	private TextMeshPro chatTypeText;

	[SerializeField]
	private TextMeshPro regionText;

	[SerializeField]
	private TextMeshPro languageText;

	private bool animating;

	private GameListing gameListing;

	private const float WAIT_SLIDE_INTRO = 0.3f;

	private const float Y_POS_OFFSET = -9f;

	[Header("Console Controller Navigation")]
	[SerializeField]
	private UiElement BackButton;

	[SerializeField]
	private UiElement defaultButtonSelected;

	private List<UiElement> controllerSelectable;

	public void SetupInfo(GameListing gameL)
	{
	}

	public string GetLevelString(int tag)
	{
		return null;
	}

	private string GetStringSetting(bool value)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CCoShow_003Ed__36))]
	private IEnumerator CoShow()
	{
		return null;
	}

	public void Close()
	{
	}

	public void OnClick()
	{
	}

	public void StartIcon()
	{
	}

	public void StopIcon()
	{
	}
}
