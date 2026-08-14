using System.Runtime.InteropServices;

namespace Epic.OnlineServices.CustomInvites
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnRequestToJoinRejectedCallbackInternal(ref OnRequestToJoinRejectedCallbackInfoInternal data);
}
