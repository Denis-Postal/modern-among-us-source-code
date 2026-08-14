using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Inventory
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnOpenCompleteCallbackInternal(ref OnOpenCompleteCallbackInfoInternal data);
}
