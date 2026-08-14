using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Epic.OnlineServices;
using Epic.OnlineServices.Platform;
using Epic.OnlineServices.PlayerDataStorage;
using UnityEngine;

public class PlayerStorageManager : DestroyableSingleton<PlayerStorageManager>
{
	public struct CloudPlayerPrefs
	{
		public string ActivePodType;

		public string receiptRedemptionAccounts;

		public uint PlatformsLimitedItemsValidated;
	}

	[CompilerGenerated]
	private sealed class _003CCoSaveChanges_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerStorageManager _003C_003E4__this;

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
		public _003CCoSaveChanges_003Ed__14(int _003C_003E1__state)
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
	private sealed class _003CWaitForLoad_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerStorageManager _003C_003E4__this;

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
		public _003CWaitForLoad_003Ed__20(int _003C_003E1__state)
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

	private const int MaxEOSChunkLength = 40960;

	private const string PlayerPrefsFilename = "player.prefs";

	private PlayerDataStorageInterface playerStorage;

	public Coroutine saveRoutine;

	public CloudPlayerPrefs PlayerPrefs { get; private set; }

	public UpdateState PlayerStorageLoadState { get; private set; }

	public void RefreshAll(PlatformInterface platformInterface)
	{
	}

	public void SaveChanges(CloudPlayerPrefs newPrefs)
	{
	}

	[IteratorStateMachine(typeof(_003CCoSaveChanges_003Ed__14))]
	private IEnumerator CoSaveChanges()
	{
		return null;
	}

	private WriteResult OnWriteChunkToEOS(ref WriteFileDataCallbackInfo data, out ArraySegment<byte> outDataBuffer)
	{
		outDataBuffer = default(ArraySegment<byte>);
		return default(WriteResult);
	}

	private void OnWriteFileComplete(ref WriteFileCallbackInfo data)
	{
	}

	private ReadResult OnReadChunkFromEOS(ref ReadFileDataCallbackInfo data)
	{
		return default(ReadResult);
	}

	private void OnReadPlayerPrefsComplete(ref ReadFileCallbackInfo data)
	{
	}

	private void OnReadPlayerPrefsCompleteInternal(MemoryStream stream, Result resultCode)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForLoad_003Ed__20))]
	public IEnumerator WaitForLoad()
	{
		return null;
	}

	private static MemoryStream ObjectToStream(object dataToStream)
	{
		return null;
	}
}
