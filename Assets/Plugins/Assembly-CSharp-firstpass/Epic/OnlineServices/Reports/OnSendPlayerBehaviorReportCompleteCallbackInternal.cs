using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Reports
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnSendPlayerBehaviorReportCompleteCallbackInternal(ref SendPlayerBehaviorReportCompleteCallbackInfoInternal data);
}
