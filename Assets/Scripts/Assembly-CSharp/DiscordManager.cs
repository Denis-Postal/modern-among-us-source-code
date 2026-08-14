using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Discord;

public class DiscordManager : DestroyableSingleton<DiscordManager>
{
	[CompilerGenerated]
	private sealed class _003CCoJoinGame_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string joinSecret;

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
		public _003CCoJoinGame_003Ed__22(int _003C_003E1__state)
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

	private const long ClientId = 477175586805252107L;

	private const string DeeplinkScheme = "amongus";

	private static readonly DateTime epoch;

	public GenericPopup discordPopup;

	[NonSerialized]
	private global::Discord.Discord presence;

	private DateTime? StartTime;

	public void Start()
	{
	}

	private void OnSceneChange(string name)
	{
	}

	public void FixedUpdate()
	{
	}

	public bool HasValidPartyID()
	{
		return false;
	}

	public bool CanLoginWithDiscord()
	{
		return false;
	}

	public void LoginWithDiscord()
	{
	}

	public void Logout()
	{
	}

	public void SetInMenus()
	{
	}

	public void SetPlayingGame()
	{
	}

	public void SetHowToPlay()
	{
	}

	public void SetInLobbyClient(int numPlayers, int maxPlayers, int gameId)
	{
	}

	private void ClearPresence()
	{
	}

	public void SetInLobbyHost(int numPlayers, int maxPlayers, int gameId)
	{
	}

	public bool CanShareGameOnDiscord()
	{
		return false;
	}

	public void ShareGameOnDiscord()
	{
	}

	private void HandleJoinRequest(string joinSecret)
	{
	}

	[IteratorStateMachine(typeof(_003CCoJoinGame_003Ed__22))]
	private IEnumerator CoJoinGame(string joinSecret)
	{
		return null;
	}

	public void RequestRespondYes(long userId)
	{
	}

	public void RequestRespondNo(long userId)
	{
	}

	public override void OnDestroy()
	{
	}

	private static string ReverseString(string source)
	{
		return null;
	}

	private static long ToUnixTime(DateTime time)
	{
		return 0L;
	}
}
