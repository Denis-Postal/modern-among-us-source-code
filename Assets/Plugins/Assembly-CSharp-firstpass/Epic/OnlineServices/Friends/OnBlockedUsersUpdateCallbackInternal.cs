using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Friends
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnBlockedUsersUpdateCallbackInternal(ref OnBlockedUsersUpdateInfoInternal data);
}
