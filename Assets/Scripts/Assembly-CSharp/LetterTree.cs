using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

public class LetterTree
{
	private enum NodeTypes : byte
	{
		NonTerm = 0,
		Terminal = 1,
		TerminalStrict = 2,
		TerminalExact = 3,
		TerminalUnbroken = 4
	}

	private class LetterNode
	{
		public char Letter;

		public NodeTypes Terminal;

		public LetterNode[] Children;

		public LetterNode[] SpecialChildren;

		public LetterNode(char l)
		{
		}

		public LetterNode CreateChild(char l)
		{
			return null;
		}

		public LetterNode FindChild(char l)
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetWords_003Ed__13 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public LetterTree _003C_003E4__this;

		private StringBuilder _003Cb_003E5__2;

		private LetterNode[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private IEnumerator<string> _003C_003E7__wrap4;

		string IEnumerator<string>.Current
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
		public _003CGetWords_003Ed__13(int _003C_003E1__state)
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

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetWords_003Ed__14 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private LetterNode node;

		public LetterNode _003C_003E3__node;

		private StringBuilder b;

		public StringBuilder _003C_003E3__b;

		private int i;

		public int _003C_003E3__i;

		public LetterTree _003C_003E4__this;

		private LetterNode[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private IEnumerator<string> _003C_003E7__wrap3;

		string IEnumerator<string>.Current
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
		public _003CGetWords_003Ed__14(int _003C_003E1__state)
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

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private LetterNode root;

	public void Clear()
	{
	}

	public void AddWord(string word)
	{
	}

	private bool IsTerminator(char l)
	{
		return false;
	}

	public static bool IsFiller(char l)
	{
		return false;
	}

	public static bool IsFiller(char l, out bool isUnicode)
	{
		isUnicode = default(bool);
		return false;
	}

	public static int ToIndex(char c)
	{
		return 0;
	}

	public static int ToIndex(char c, out bool isUnicode)
	{
		isUnicode = default(bool);
		return 0;
	}

	public int SearchTestOnly(string input, int start)
	{
		return 0;
	}

	public int Search(char[] input, int start)
	{
		return 0;
	}

	private int SubSearchRec(char[] input, int start, LetterNode previous, bool postDupes, bool postBreak, bool exactStart)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CGetWords_003Ed__13))]
	public IEnumerable<string> GetWords()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetWords_003Ed__14))]
	private IEnumerable<string> GetWords(StringBuilder b, int i, LetterNode node)
	{
		return null;
	}
}
