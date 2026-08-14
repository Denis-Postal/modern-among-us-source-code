using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.XSX
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int XSXVMDecommitFuncInternal(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData);
}
