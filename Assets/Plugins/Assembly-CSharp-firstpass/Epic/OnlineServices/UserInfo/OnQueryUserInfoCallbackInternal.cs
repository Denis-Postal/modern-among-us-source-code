using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UserInfo
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnQueryUserInfoCallbackInternal(ref QueryUserInfoCallbackInfoInternal data);
}
