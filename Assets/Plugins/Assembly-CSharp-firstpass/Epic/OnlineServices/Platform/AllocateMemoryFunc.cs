using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Platform
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate IntPtr AllocateMemoryFunc(UIntPtr sizeInBytes, UIntPtr alignment);
}
