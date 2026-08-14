using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnQueryInvitesCallbackInternal(ref QueryInvitesCallbackInfoInternal data);
}
