using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UserInfo
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct QueryUserInfoByExternalAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryUserInfoByExternalAccountCallbackInfo>, ISettable<QueryUserInfoByExternalAccountCallbackInfo>, IDisposable
	{
		private Result m_ResultCode;

		private IntPtr m_ClientData;

		private IntPtr m_LocalUserId;

		private IntPtr m_ExternalAccountId;

		private ExternalAccountType m_AccountType;

		private IntPtr m_TargetUserId;

		public Result ResultCode
		{
			get
			{
				return default(Result);
			}
			set
			{
			}
		}

		public object ClientData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IntPtr ClientDataAddress => (IntPtr)0;

		public EpicAccountId LocalUserId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Utf8String ExternalAccountId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ExternalAccountType AccountType
		{
			get
			{
				return default(ExternalAccountType);
			}
			set
			{
			}
		}

		public EpicAccountId TargetUserId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Set(ref QueryUserInfoByExternalAccountCallbackInfo other)
		{
		}

		public void Set(ref QueryUserInfoByExternalAccountCallbackInfo? other)
		{
		}

		public void Dispose()
		{
		}

		public void Get(out QueryUserInfoByExternalAccountCallbackInfo output)
		{
			output = default(QueryUserInfoByExternalAccountCallbackInfo);
		}
	}
}
