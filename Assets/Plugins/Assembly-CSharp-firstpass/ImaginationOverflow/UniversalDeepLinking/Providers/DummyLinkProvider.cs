using System;
using System.Runtime.CompilerServices;

namespace ImaginationOverflow.UniversalDeepLinking.Providers
{
	public class DummyLinkProvider : ILinkProvider
	{
		public event Action<string> LinkReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public bool Initialize()
		{
			return false;
		}

		public void PollInfoAfterPause()
		{
		}

		protected virtual void OnLinkReceived(string obj)
		{
		}
	}
}
