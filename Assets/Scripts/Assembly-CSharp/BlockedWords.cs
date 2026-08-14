using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public static class BlockedWords
{
	private class LengthCompare : IComparer<string>
	{
		public static readonly LengthCompare Instance;

		public int Compare(string x, string y)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCensorWordsCo_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string chatText;

		public Action<string> onWordsCensoredCallback;

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
		public _003CCensorWordsCo_003Ed__8(int _003C_003E1__state)
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

	public static readonly HashSet<char> SymbolChars;

	private static LetterTree SkipList;

	static BlockedWords()
	{
	}

	public static void SetLanguage(TranslatedImageSet newLang)
	{
	}

	public static bool ContainsWord(string chatText)
	{
		return false;
	}

	public static string CensorWords(string chatText, bool skipConsoleAPI = false)
	{
		return null;
	}

	public static void CensorWordsAsync(string chatText, Action<string> onWordsCensoredCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CCensorWordsCo_003Ed__8))]
	public static IEnumerator CensorWordsCo(string chatText, Action<string> onWordsCensoredCallback)
	{
		return null;
	}

	private static bool IsLetter(char letter)
	{
		return false;
	}
}
