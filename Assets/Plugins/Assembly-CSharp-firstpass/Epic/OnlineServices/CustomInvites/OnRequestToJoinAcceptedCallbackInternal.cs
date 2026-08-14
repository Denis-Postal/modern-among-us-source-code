using System.Runtime.InteropServices;

namespace Epic.OnlineServices.CustomInvites
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnRequestToJoinAcceptedCallbackInternal(ref OnRequestToJoinAcceptedCallbackInfoInternal data);
}
