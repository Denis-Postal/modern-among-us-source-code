using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Switch
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int SwitchVMDecommitFuncInternal(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData);
}
