using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCData
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnDataReceivedCallbackInternal(ref DataReceivedCallbackInfoInternal data);
}
