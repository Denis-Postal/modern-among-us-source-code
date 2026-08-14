using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnStartSessionCallbackInternal(ref StartSessionCallbackInfoInternal data);
}
