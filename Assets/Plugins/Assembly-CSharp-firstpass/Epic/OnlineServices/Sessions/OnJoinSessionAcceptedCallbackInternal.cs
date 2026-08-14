using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnJoinSessionAcceptedCallbackInternal(ref JoinSessionAcceptedCallbackInfoInternal data);
}
