using System.Runtime.InteropServices;

namespace Epic.OnlineServices.TitleStorage
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ReadResult OnReadFileDataCallbackInternal(ref ReadFileDataCallbackInfoInternal data);
}
