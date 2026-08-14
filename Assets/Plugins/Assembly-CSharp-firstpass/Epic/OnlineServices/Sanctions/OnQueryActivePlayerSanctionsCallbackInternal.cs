using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sanctions
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnQueryActivePlayerSanctionsCallbackInternal(ref QueryActivePlayerSanctionsCallbackInfoInternal data);
}
