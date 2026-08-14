using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Innersloth.Assets;
using UnityEngine;

[CreateAssetMenu]
public class UnlockableCosmetic : ScriptableObject
{
	public enum UnlockableQuality
	{
		Nameplate = 1,
		Hat = 2,
		Visor = 3,
		Skin = 4,
		Pet = 5,
		Kill = 6
	}

	[CompilerGenerated]
	private sealed class _003CCoLoadIcon_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnlockableCosmetic _003C_003E4__this;

		public Action<Sprite, AddressableAsset> onLoaded;

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
		public _003CCoLoadIcon_003Ed__6(int _003C_003E1__state)
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

	public UnlockableQuality quality;

	public CosmeticData unlockableCosmetic;

	public int cost;

	public string GetProdId()
	{
		return null;
	}

	public string GetBundleId()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoLoadIcon_003Ed__6))]
	public IEnumerator CoLoadIcon(Action<Sprite, AddressableAsset> onLoaded)
	{
		return null;
	}
}
