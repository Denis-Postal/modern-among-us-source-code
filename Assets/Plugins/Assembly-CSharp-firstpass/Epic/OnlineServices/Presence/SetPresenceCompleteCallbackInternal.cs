using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Presence
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void SetPresenceCompleteCallbackInternal(ref SetPresenceCallbackInfoInternal data);
}
