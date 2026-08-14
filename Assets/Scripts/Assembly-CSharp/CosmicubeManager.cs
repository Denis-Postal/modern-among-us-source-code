using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CosmicubeManager : DestroyableSingleton<CosmicubeManager>
{
	[CompilerGenerated]
	private sealed class _003CStartDownload_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<AssetReference> toDownload;

		private List<AssetReference> _003CreallyDownload_003E5__2;

		private List<AssetReference>.Enumerator _003C_003E7__wrap2;

		private AssetReference _003Caref_003E5__4;

		private AsyncOperationHandle<long> _003CdlSizeHandle_003E5__5;

		private float _003CstartTime_003E5__6;

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
		public _003CStartDownload_003Ed__4(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public static Dictionary<UnlockableCosmetic.UnlockableQuality, Color> qualityColorMap;

	private List<CosmicubeData> allCubes;

	public CosmicubeData GetCubeDataByID(string id)
	{
		return null;
	}

	public void Initialize()
	{
	}

	[IteratorStateMachine(typeof(_003CStartDownload_003Ed__4))]
	private IEnumerator StartDownload(List<AssetReference> toDownload)
	{
		return null;
	}

	public IEnumerable<CosmicubeData> GetAllCubeData()
	{
		return null;
	}

	public CosmicubeData[] GetAvailableCubeData()
	{
		return null;
	}

	public CosmicubeData[] GetUnlockedCubes()
	{
		return null;
	}

	public CosmicubeData GetDataForPodId(string podId)
	{
		return null;
	}

	public float GetCompletionProgress(CosmicubeData cube)
	{
		return 0f;
	}

	public bool IsCompleted(CosmicubeData cube)
	{
		return false;
	}
}
