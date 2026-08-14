using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class HostInfoPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetCosmetics_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HostInfoPanel _003C_003E4__this;

		public NetworkedPlayerInfo playerInfo;

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
		public _003CSetCosmetics_003Ed__11(int _003C_003E1__state)
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
	private GameObject content;

	[SerializeField]
	private PoolablePlayer player;

	[SerializeField]
	private GameObject playerHolder;

	[SerializeField]
	private TextMeshPro playerName;

	[SerializeField]
	private TextMeshPro hostLabel;

	[SerializeField]
	private Transform hostLabelCenter;

	private const float CREW_WIDTH = 0.43f;

	private const float CONTENT_CENTER_X = -0.43f;

	private float hostWidth;

	private bool firstUpdate;

	public void SetUp()
	{
	}

	[IteratorStateMachine(typeof(_003CSetCosmetics_003Ed__11))]
	public IEnumerator SetCosmetics(NetworkedPlayerInfo playerInfo)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private bool ShouldBoldenHostLabel(SupportedLangs language)
	{
		return false;
	}
}
