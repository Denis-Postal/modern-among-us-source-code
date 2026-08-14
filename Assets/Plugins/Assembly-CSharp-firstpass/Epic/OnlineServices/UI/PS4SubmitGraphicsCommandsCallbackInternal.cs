using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UI
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void PS4SubmitGraphicsCommandsCallbackInternal(ref PS4SubmitGraphicsCommandsCallbackInfoInternal data);
}
