using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Friends
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnQueryFriendsCallbackInternal(ref QueryFriendsCallbackInfoInternal data);
}
