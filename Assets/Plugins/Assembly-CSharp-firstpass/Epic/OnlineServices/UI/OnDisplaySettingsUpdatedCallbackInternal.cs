using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UI
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnDisplaySettingsUpdatedCallbackInternal(ref OnDisplaySettingsUpdatedCallbackInfoInternal data);
}
