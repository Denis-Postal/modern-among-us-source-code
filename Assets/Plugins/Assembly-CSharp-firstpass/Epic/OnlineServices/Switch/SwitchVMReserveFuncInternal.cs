using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Switch
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr SwitchVMReserveFuncInternal(UIntPtr sizeInBytes, SwitchAccessType accessType, ref IntPtr outContextData);
}
