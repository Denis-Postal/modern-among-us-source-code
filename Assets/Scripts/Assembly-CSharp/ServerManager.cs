using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;

public class ServerManager : DestroyableSingleton<ServerManager>
{
	[JsonObject]
	private struct JsonServerData
	{
		public int CurrentRegionIdx;

		public IRegionInfo[] Regions;

		internal void CleanAndMerge(IRegionInfo[] defaultRegions)
		{
		}
	}

	private struct PingWrapper
	{
		public IRegionInfo Region;

		public Ping Ping;

		public PingWrapper(IRegionInfo region, Ping ping)
		{
			Region = null;
			Ping = null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CReselectRegionFromDefaults_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ServerManager _003C_003E4__this;

		private List<Task<IPAddress[]>> _003CdnsLookups_003E5__2;

		private List<PingWrapper> _003Cpings_003E5__3;

		private float _003CtimeElapsedSeconds_003E5__4;

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
		public _003CReselectRegionFromDefaults_003Ed__33(int _003C_003E1__state)
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
	private sealed class _003CWaitForServers_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ServerManager _003C_003E4__this;

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
		public _003CWaitForServers_003Ed__34(int _003C_003E1__state)
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

	public static readonly IRegionInfo[] DefaultRegions;

	private const bool useDtls = false;

	private const float PingTimeoutSeconds = 5f;

	private string serverInfoFileJson;

	private UpdateState state;

	public IRegionInfo CurrentRegion { get; private set; }

	public ServerInfo CurrentUdpServer { get; private set; }

	public bool IsHttp => false;

	public string TargetServer => null;

	public IRegionInfo[] AvailableRegions { get; private set; }

	private ServerInfo[] AvailableServers => null;

	public string UdpNetAddress => null;

	public ushort UdpNetPort => 0;

	public bool UdpUseDtls => false;

	internal void AddOrUpdateRegion(IRegionInfo newRegion)
	{
	}

	public override void Awake()
	{
	}

	private void HandleUpnp()
	{
	}

	[ContextMenu("Reselect Server")]
	internal void ReselectServer()
	{
	}

	[IteratorStateMachine(typeof(_003CReselectRegionFromDefaults_003Ed__33))]
	public IEnumerator ReselectRegionFromDefaults()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitForServers_003Ed__34))]
	public IEnumerator WaitForServers()
	{
		return null;
	}

	internal void SetRegion(IRegionInfo region)
	{
	}

	public void SaveServers()
	{
	}

	public void LoadServers()
	{
	}

	internal bool TrackServerFailure(string networkAddress)
	{
		return false;
	}
}
