using System.Runtime.InteropServices;

namespace Epic.OnlineServices.IntegratedPlatform
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntegratedPlatformPreLogoutAction OnUserPreLogoutCallbackInternal(ref UserPreLogoutCallbackInfoInternal data);
}
