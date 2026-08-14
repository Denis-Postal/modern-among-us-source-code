using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Platform
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate IntPtr ReallocateMemoryFunc(IntPtr pointer, UIntPtr sizeInBytes, UIntPtr alignment);
}
