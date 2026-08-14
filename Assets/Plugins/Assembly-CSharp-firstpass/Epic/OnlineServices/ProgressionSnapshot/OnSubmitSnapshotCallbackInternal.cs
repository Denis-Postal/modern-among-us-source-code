using System.Runtime.InteropServices;

namespace Epic.OnlineServices.ProgressionSnapshot
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnSubmitSnapshotCallbackInternal(ref SubmitSnapshotCallbackInfoInternal data);
}
