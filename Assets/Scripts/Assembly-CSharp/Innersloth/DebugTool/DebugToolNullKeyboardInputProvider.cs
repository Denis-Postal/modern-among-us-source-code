using System;

namespace Innersloth.DebugTool
{
	public class DebugToolNullKeyboardInputProvider : IDebugToolKeyboardInputProvider
	{
		public void GetText(string originalText, int characterLimit, Action<string> onComplete)
		{
		}
	}
}
