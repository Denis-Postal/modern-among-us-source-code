using System.Runtime.InteropServices;

namespace Epic.OnlineServices.PlayerDataStorage
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnDeleteFileCompleteCallbackInternal(ref DeleteFileCallbackInfoInternal data);
}
