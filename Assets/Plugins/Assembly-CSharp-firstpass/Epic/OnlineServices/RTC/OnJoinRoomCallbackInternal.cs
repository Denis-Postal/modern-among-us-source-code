using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTC
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnJoinRoomCallbackInternal(ref JoinRoomCallbackInfoInternal data);
}
