using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Connect
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnCreateDeviceIdCallbackInternal(ref CreateDeviceIdCallbackInfoInternal data);
}
