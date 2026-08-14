using System.Runtime.InteropServices;

namespace Epic.OnlineServices.IntegratedPlatform
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnUserLoginStatusChangedCallbackInternal(ref UserLoginStatusChangedCallbackInfoInternal data);
}
