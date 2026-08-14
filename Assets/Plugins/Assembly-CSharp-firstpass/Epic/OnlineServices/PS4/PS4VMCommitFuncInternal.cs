using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.PS4
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int PS4VMCommitFuncInternal(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData);
}
