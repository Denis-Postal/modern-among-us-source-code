using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public class ISteamMatchmakingPingResponse
	{
		public delegate void ServerResponded(gameserveritem_t server);

		public delegate void ServerFailedToRespond();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void InternalServerResponded(gameserveritem_t server);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void InternalServerFailedToRespond();

		[StructLayout((LayoutKind)0)]
		private class VTable
		{
			[NonSerialized]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;
		}

		private VTable m_VTable;

		private IntPtr m_pVTable;

		private GCHandle m_pGCHandle;

		private ServerResponded m_ServerResponded;

		private ServerFailedToRespond m_ServerFailedToRespond;

		public ISteamMatchmakingPingResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond)
		{
		}

		~ISteamMatchmakingPingResponse()
		{
		}

		private void InternalOnServerResponded(gameserveritem_t server)
		{
		}

		private void InternalOnServerFailedToRespond()
		{
		}

		public static explicit operator IntPtr(ISteamMatchmakingPingResponse that)
		{
			return (IntPtr)0;
		}
	}
}
