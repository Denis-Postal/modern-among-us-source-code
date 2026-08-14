using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UI
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void XSXOnMemoryMonitorCallbackInternal(ref XSXMemoryMonitorCallbackInfoInternal data);
}
