using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class CircleBuffer<T> : IEnumerable<T>, IEnumerable where T : class
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__7 : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		public CircleBuffer<T> _003C_003E4__this;

		private int _003Ci_003E5__2;

		T IEnumerator<T>.Current
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
		public _003CGetEnumerator_003Ed__7(int _003C_003E1__state)
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
	private sealed class _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CircleBuffer<T> _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__8(int _003C_003E1__state)
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

	private T[] data;

	private int idx;

	private int count;

	public CircleBuffer(int size)
	{
	}

	public void Sort(IComparer<T> comparer)
	{
	}

	public void Add(T item)
	{
	}

	public void Clear()
	{
	}

	[IteratorStateMachine(typeof(CircleBuffer<>._003CGetEnumerator_003Ed__7))]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[IteratorStateMachine(typeof(CircleBuffer<>._003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__8))]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
