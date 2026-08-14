using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.XboxOneGDK
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int XboxOneGDKVMCommitFuncInternal(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData);
}
