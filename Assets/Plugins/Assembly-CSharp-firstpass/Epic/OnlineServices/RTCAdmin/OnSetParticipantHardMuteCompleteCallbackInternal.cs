using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAdmin
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnSetParticipantHardMuteCompleteCallbackInternal(ref SetParticipantHardMuteCompleteCallbackInfoInternal data);
}
