using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Presence
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnPresenceChangedCallbackInternal(ref PresenceChangedCallbackInfoInternal data);
}
