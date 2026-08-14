using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LobbyInfoPane : DestroyableSingleton<LobbyInfoPane>
{
	[CompilerGenerated]
	private sealed class _003CCoCopyGameCode_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LobbyInfoPane _003C_003E4__this;

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
		public _003CCoCopyGameCode_003Ed__24(int _003C_003E1__state)
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
	private SpriteRenderer InfoPaneBackground;

	[SerializeField]
	private Sprite InfoPaneInactive;

	[SerializeField]
	private Sprite InfoPaneActive;

	[SerializeField]
	private UiElement EditButton;

	[SerializeField]
	private UiElement HostViewButton;

	[SerializeField]
	private UiElement ClientViewButton;

	[SerializeField]
	private UiElement CopyCodeButton;

	[SerializeField]
	private UiElement ActivateButton;

	[SerializeField]
	private UiElement BackButton;

	[SerializeField]
	private List<UiElement> ControllerSelectable;

	[SerializeField]
	private UiElement HostPrivateButton;

	[SerializeField]
	private UiElement HostPublicButton;

	[SerializeField]
	private LobbyViewSettingsPane LobbyViewSettingsPane;

	[SerializeField]
	private GameObject CopyCodeText;

	[SerializeField]
	private AudioClip CopyCodeSound;

	private UiElement DefaultButtonSelected;

	private IEnumerator copyGameCodeCoroutine;

	private bool IsPaneActive;

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void ActivatePane()
	{
	}

	public void DeactivatePane()
	{
	}

	public void RefreshPane()
	{
	}

	public void CopyGameCode()
	{
	}

	[IteratorStateMachine(typeof(_003CCoCopyGameCode_003Ed__24))]
	private IEnumerator CoCopyGameCode()
	{
		return null;
	}

	private void DisableCopyCodeText()
	{
	}
}
