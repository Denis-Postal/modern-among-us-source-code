using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTC
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnParticipantStatusChangedCallbackInternal(ref ParticipantStatusChangedCallbackInfoInternal data);
}
