using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Inventory
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
	internal struct OnCheckpointCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnCheckpointCompleteCallbackInfo>, ISettable<OnCheckpointCompleteCallbackInfo>, IDisposable
	{
		private Result m_ResultCode;

		private IntPtr m_ClientData;

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

		public void Set(ref OnCheckpointCompleteCallbackInfo other)
		{
		}

		public void Set(ref OnCheckpointCompleteCallbackInfo? other)
		{
		}

		public void Dispose()
		{
		}

		public void Get(out OnCheckpointCompleteCallbackInfo output)
		{
			output = default(OnCheckpointCompleteCallbackInfo);
		}
	}
}
