using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UI
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnShowBlockPlayerCallbackInternal(ref OnShowBlockPlayerCallbackInfoInternal data);
}
