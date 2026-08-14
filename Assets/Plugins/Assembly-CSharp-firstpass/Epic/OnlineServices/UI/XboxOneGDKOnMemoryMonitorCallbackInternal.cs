using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UI
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void XboxOneGDKOnMemoryMonitorCallbackInternal(ref XboxOneGDKMemoryMonitorCallbackInfoInternal data);
}
