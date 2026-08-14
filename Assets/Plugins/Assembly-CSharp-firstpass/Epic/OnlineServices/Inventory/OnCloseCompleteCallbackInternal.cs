using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Inventory
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnCloseCompleteCallbackInternal(ref OnCloseCompleteCallbackInfoInternal data);
}
