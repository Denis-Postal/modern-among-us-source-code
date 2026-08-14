using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UI
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void PS4OnMemoryMonitorCallbackInternal(ref PS4MemoryMonitorCallbackInfoInternal data);
}
