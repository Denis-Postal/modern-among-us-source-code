using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CollectableOre : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShineCollect_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectableOre _003C_003E4__this;

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
		public _003CShineCollect_003Ed__20(int _003C_003E1__state)
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

	private const float WAIT_TIME_COLLECT = 0.3f;

	private const float WAIT_TIME_ROCK = 0.7f;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private BreakableRock[] rocks;

	[SerializeField]
	private Sprite[] oreSprites;

	[SerializeField]
	private Sprite[] rockSprites;

	[SerializeField]
	private AudioClip gemCollect;

	private int rockCount;

	private Action onCollect;

	private bool isRock;

	private Action onRockRelease;

	public void Initialize(Action collectOre, Action<CollectableOre, Vector3> powerAction, Controller control, Action rockReleased)
	{
	}

	public BreakableRock[] GetRocks()
	{
		return null;
	}

	public bool GetIsRock()
	{
		return false;
	}

	public void RotateObjects()
	{
	}

	public void SetNumRocks(int numRocks)
	{
	}

	public void SetAsRock()
	{
	}

	public void SetOreSprite(int index)
	{
	}

	public void BrokenRock()
	{
	}

	public int GetNumberRocksBroken()
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CShineCollect_003Ed__20))]
	private IEnumerator ShineCollect()
	{
		return null;
	}

	private void RotateObject(GameObject obj)
	{
	}
}
