using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UI
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void PS5SubmitGraphicsCommandsCallbackInternal(ref PS5SubmitGraphicsCommandsCallbackInfoInternal data);
}
