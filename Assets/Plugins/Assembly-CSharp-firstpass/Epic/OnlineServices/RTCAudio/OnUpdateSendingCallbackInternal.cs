using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnUpdateSendingCallbackInternal(ref UpdateSendingCallbackInfoInternal data);
}
