using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.PS4
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr PS4VMReserveFuncInternal(UIntPtr sizeInBytes, PS4AccessType accessType, ref IntPtr outContextData);
}
