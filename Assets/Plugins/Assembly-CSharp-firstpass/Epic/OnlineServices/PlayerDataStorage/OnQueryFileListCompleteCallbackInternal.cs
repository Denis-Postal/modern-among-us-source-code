using System.Runtime.InteropServices;

namespace Epic.OnlineServices.PlayerDataStorage
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnQueryFileListCompleteCallbackInternal(ref QueryFileListCallbackInfoInternal data);
}
