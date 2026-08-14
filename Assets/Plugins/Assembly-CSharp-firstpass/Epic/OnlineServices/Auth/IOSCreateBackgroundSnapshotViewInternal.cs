using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Auth
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr IOSCreateBackgroundSnapshotViewInternal(IntPtr context);
}
