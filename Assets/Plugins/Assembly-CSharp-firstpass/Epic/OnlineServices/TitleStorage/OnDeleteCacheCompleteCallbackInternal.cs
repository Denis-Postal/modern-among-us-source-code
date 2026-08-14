using System.Runtime.InteropServices;

namespace Epic.OnlineServices.TitleStorage
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnDeleteCacheCompleteCallbackInternal(ref DeleteCacheCallbackInfoInternal data);
}
