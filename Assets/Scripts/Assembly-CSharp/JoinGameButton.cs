using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using TMPro;
using UnityEngine;

public class JoinGameButton : MonoBehaviour, IConnectButton
{
	[CompilerGenerated]
	private sealed class _003CJoinLocalGame_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JoinGameButton _003C_003E4__this;

		private float _003Ctime_003E5__2;

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
		public _003CJoinLocalGame_003Ed__13(int _003C_003E1__state)
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

	public AudioClip IntroMusic;

	public TextBoxTMP GameIdText;

	public TextMeshPro gameNameText;

	public float timeRecieved;

	public SpriteRenderer FillScreen;

	public SpriteAnim connectIcon;

	public AnimationClip connectClip;

	public NetworkModes NetworkMode;

	public string netAddress;

	private void Start()
	{
	}

	public void OnClick()
	{
	}

	private void NotOnlinePermissions()
	{
	}

	private void ContinueOnClick()
	{
	}

	[IteratorStateMachine(typeof(_003CJoinLocalGame_003Ed__13))]
	private IEnumerator JoinLocalGame()
	{
		return null;
	}

	public void SetGameName(string[] gameNameParts)
	{
	}

	public void StartIcon()
	{
	}

	public void StopIcon()
	{
	}
}
