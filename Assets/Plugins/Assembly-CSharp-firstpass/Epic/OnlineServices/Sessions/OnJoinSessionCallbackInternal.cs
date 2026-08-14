using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnJoinSessionCallbackInternal(ref JoinSessionCallbackInfoInternal data);
}
