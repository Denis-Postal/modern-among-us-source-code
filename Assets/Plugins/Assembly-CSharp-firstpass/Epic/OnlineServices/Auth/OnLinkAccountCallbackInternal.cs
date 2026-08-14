using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Auth
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnLinkAccountCallbackInternal(ref LinkAccountCallbackInfoInternal data);
}
