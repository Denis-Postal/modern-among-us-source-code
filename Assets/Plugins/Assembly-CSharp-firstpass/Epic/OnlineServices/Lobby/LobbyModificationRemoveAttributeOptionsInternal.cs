using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
	internal struct LobbyModificationRemoveAttributeOptionsInternal : ISettable<LobbyModificationRemoveAttributeOptions>, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_Key;

		public Utf8String Key
		{
			set
			{
			}
		}

		public void Set(ref LobbyModificationRemoveAttributeOptions other)
		{
		}

		public void Set(ref LobbyModificationRemoveAttributeOptions? other)
		{
		}

		public void Dispose()
		{
		}
	}
}
