using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Stats
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnIngestStatCompleteCallbackInternal(ref IngestStatCompleteCallbackInfoInternal data);
}
