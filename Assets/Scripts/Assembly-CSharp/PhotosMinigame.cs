using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PhotosMinigame : Minigame
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PhotosMinigame _003C_003E4__this;

		private float _003Cz_003E5__2;

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
		public _003CStart_003Ed__15(int _003C_003E1__state)
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

	public GamePhotoBehaviour[] photos;

	public Sprite[] PhotoContents;

	public Collider2D PoolHitbox;

	public Transform selectorObject;

	public SpriteRenderer selectorHand;

	public Rect PolaroidBounds;

	private Controller controller;

	private bool prevHadButton;

	private int currentlyGrabbedObject;

	private bool AllowDraggingPhotos => false;

	private List<Sprite> GetUniqueListOfPhotos(int count)
	{
		return null;
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void WriteInitialData()
	{
	}

	private void ReadInitialData()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__15))]
	public IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private void HandleJoystick()
	{
	}

	private void HandleMouse()
	{
	}

	private void clampToBounds(GamePhotoBehaviour photo)
	{
	}

	private void FixZ(GamePhotoBehaviour current)
	{
	}
}
