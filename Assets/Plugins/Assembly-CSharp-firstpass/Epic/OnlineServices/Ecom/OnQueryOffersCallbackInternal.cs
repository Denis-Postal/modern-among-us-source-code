using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnQueryOffersCallbackInternal(ref QueryOffersCallbackInfoInternal data);
}
