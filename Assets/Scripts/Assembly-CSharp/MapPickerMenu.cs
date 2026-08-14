using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MapPickerMenu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CHack_FixDefaultSelection_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MapPickerMenu _003C_003E4__this;

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
		public _003CHack_FixDefaultSelection_003Ed__4(int _003C_003E1__state)
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
	private MapFilterButton[] MapButtons;

	[SerializeField]
	private CreateOptionsPicker Parent;

	[SerializeField]
	private UiElement BackButton;

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CHack_FixDefaultSelection_003Ed__4))]
	private IEnumerator Hack_FixDefaultSelection()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	public void UpdateMapButtons(int mapid)
	{
	}

	public void SetMap(int mapId)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}
}
