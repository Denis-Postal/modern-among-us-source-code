using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAdmin
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnKickCompleteCallbackInternal(ref KickCompleteCallbackInfoInternal data);
}
