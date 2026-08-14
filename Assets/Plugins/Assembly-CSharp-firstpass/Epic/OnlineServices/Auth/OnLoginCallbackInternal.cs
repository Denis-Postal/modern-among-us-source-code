using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Auth
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnLoginCallbackInternal(ref LoginCallbackInfoInternal data);
}
