using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public class ISteamMatchmakingServerListResponse
	{
		public delegate void ServerResponded(HServerListRequest hRequest, int iServer);

		public delegate void ServerFailedToRespond(HServerListRequest hRequest, int iServer);

		public delegate void RefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void InternalServerResponded(HServerListRequest hRequest, int iServer);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void InternalServerFailedToRespond(HServerListRequest hRequest, int iServer);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void InternalRefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response);

		[StructLayout((LayoutKind)0)]
		private class VTable
		{
			[NonSerialized]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;

			[NonSerialized]
			public InternalRefreshComplete m_VTRefreshComplete;
		}

		private VTable m_VTable;

		private IntPtr m_pVTable;

		private GCHandle m_pGCHandle;

		private ServerResponded m_ServerResponded;

		private ServerFailedToRespond m_ServerFailedToRespond;

		private RefreshComplete m_RefreshComplete;

		public ISteamMatchmakingServerListResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond, RefreshComplete onRefreshComplete)
		{
		}

		~ISteamMatchmakingServerListResponse()
		{
		}

		private void InternalOnServerResponded(HServerListRequest hRequest, int iServer)
		{
		}

		private void InternalOnServerFailedToRespond(HServerListRequest hRequest, int iServer)
		{
		}

		private void InternalOnRefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
		}

		public static explicit operator IntPtr(ISteamMatchmakingServerListResponse that)
		{
			return (IntPtr)0;
		}
	}
}
