using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public class ISteamMatchmakingRulesResponse
	{
		public delegate void RulesResponded(string pchRule, string pchValue);

		public delegate void RulesFailedToRespond();

		public delegate void RulesRefreshComplete();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate void InternalRulesResponded(IntPtr pchRule, IntPtr pchValue);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate void InternalRulesFailedToRespond();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate void InternalRulesRefreshComplete();

		[StructLayout((LayoutKind)0)]
		private class VTable
		{
			[NonSerialized]
			public InternalRulesResponded m_VTRulesResponded;

			[NonSerialized]
			public InternalRulesFailedToRespond m_VTRulesFailedToRespond;

			[NonSerialized]
			public InternalRulesRefreshComplete m_VTRulesRefreshComplete;
		}

		private VTable m_VTable;

		private IntPtr m_pVTable;

		private GCHandle m_pGCHandle;

		private RulesResponded m_RulesResponded;

		private RulesFailedToRespond m_RulesFailedToRespond;

		private RulesRefreshComplete m_RulesRefreshComplete;

		public ISteamMatchmakingRulesResponse(RulesResponded onRulesResponded, RulesFailedToRespond onRulesFailedToRespond, RulesRefreshComplete onRulesRefreshComplete)
		{
		}

		~ISteamMatchmakingRulesResponse()
		{
		}

		private void InternalOnRulesResponded(IntPtr pchRule, IntPtr pchValue)
		{
		}

		private void InternalOnRulesFailedToRespond()
		{
		}

		private void InternalOnRulesRefreshComplete()
		{
		}

		public static explicit operator IntPtr(ISteamMatchmakingRulesResponse that)
		{
			return (IntPtr)0;
		}
	}
}
