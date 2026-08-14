using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.IntegratedPlatform
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void PS4ManagedBySdkNotificationMessagesCallbackInternal(IntPtr clientData, IntPtr inEvent);
}
