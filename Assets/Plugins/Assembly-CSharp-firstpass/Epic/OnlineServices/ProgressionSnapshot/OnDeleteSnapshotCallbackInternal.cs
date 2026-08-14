using System.Runtime.InteropServices;

namespace Epic.OnlineServices.ProgressionSnapshot
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnDeleteSnapshotCallbackInternal(ref DeleteSnapshotCallbackInfoInternal data);
}
