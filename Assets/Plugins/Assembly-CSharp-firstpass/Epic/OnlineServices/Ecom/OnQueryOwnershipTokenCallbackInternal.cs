using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnQueryOwnershipTokenCallbackInternal(ref QueryOwnershipTokenCallbackInfoInternal data);
}
