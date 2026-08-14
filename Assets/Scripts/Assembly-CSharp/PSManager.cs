using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AmongUs.GameOptions;
using UnityEngine;

[DefaultExecutionOrder(-20000)]
public class PSManager : DestroyableSingleton<PSManager>
{
	[CompilerGenerated]
	private sealed class _003CCreateGameCo_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PSManager _003C_003E4__this;

		public GameModes gameMode;

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
		public _003CCreateGameCo_003Ed__10(int _003C_003E1__state)
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
	private sealed class _003CJoinGame_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int gameCode;

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
		public _003CJoinGame_003Ed__7(int _003C_003E1__state)
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
	private sealed class _003CKeepLoadBlockerActive_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PSManager _003C_003E4__this;

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
		public _003CKeepLoadBlockerActive_003Ed__11(int _003C_003E1__state)
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

	public Texture2D ps4SessionImage;

	[NonSerialized]
	public byte[] ps4SessionImageAsPNG;

	public JoinSessionSource joinSessionSource;

	public bool gameplayStarted;

	private bool keepBlockerActive;

	public string GetSessionName()
	{
		return null;
	}

	public void JoinGameFromCode(string gameCode)
	{
	}

	public void JoinGameFromCode(int gameCode)
	{
	}

	[IteratorStateMachine(typeof(_003CJoinGame_003Ed__7))]
	public IEnumerator JoinGame(int gameCode)
	{
		return null;
	}

	public void CreateGame(GameModes gameMode)
	{
	}

	[IteratorStateMachine(typeof(_003CCreateGameCo_003Ed__10))]
	private IEnumerator CreateGameCo(GameModes gameMode)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CKeepLoadBlockerActive_003Ed__11))]
	private IEnumerator KeepLoadBlockerActive()
	{
		return null;
	}
}
