using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
	internal struct OnQueryInputDevicesInformationCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryInputDevicesInformationCallbackInfo>, ISettable<OnQueryInputDevicesInformationCallbackInfo>, IDisposable
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

		public void Set(ref OnQueryInputDevicesInformationCallbackInfo other)
		{
		}

		public void Set(ref OnQueryInputDevicesInformationCallbackInfo? other)
		{
		}

		public void Dispose()
		{
		}

		public void Get(out OnQueryInputDevicesInformationCallbackInfo output)
		{
			output = default(OnQueryInputDevicesInformationCallbackInfo);
		}
	}
}
