using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.XboxOneGDK
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr XboxOneGDKVMReserveFuncInternal(UIntPtr sizeInBytes, XboxOneGDKAccessType accessType, ref IntPtr outContextData);
}
