using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UI
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void PS5OnMemoryMonitorCallbackInternal(ref PS5MemoryMonitorCallbackInfoInternal data);
}
