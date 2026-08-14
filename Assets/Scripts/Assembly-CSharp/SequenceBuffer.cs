using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class SequenceBuffer<T>
{
	private struct SequencedData<T> : IComparable<SequencedData<T>>
	{
		public readonly ushort Sid;

		public readonly T Data;

		public SequencedData(ushort sid, T data)
		{
			Sid = 0;
			Data = default(T);
		}

		public int CompareTo(SequencedData<T> other)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class _003CSubsequentObjs_003Ed__11 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public SequenceBuffer<T> _003C_003E4__this;

		T IEnumerator<T>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(T);
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
		public _003CSubsequentObjs_003Ed__11(int _003C_003E1__state)
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

		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private readonly List<SequencedData<T>> buffer;

	public ushort LastSid { get; set; }

	public SequenceBuffer(ushort sidStart = 0)
	{
	}

	public void Add(ushort sid, T info)
	{
	}

	public void BumpSid()
	{
	}

	public bool IsInvalidSid(ushort sid)
	{
		return false;
	}

	public bool IsNextSid(ushort sid)
	{
		return false;
	}

	[IteratorStateMachine(typeof(SequenceBuffer<>._003CSubsequentObjs_003Ed__11))]
	public IEnumerable<T> SubsequentObjs()
	{
		return null;
	}

	private void Sort()
	{
	}

	private bool HasElements()
	{
		return false;
	}

	private SequencedData<T> Pop()
	{
		return default(SequencedData<T>);
	}

	private SequencedData<T> Peek()
	{
		return default(SequencedData<T>);
	}
}
