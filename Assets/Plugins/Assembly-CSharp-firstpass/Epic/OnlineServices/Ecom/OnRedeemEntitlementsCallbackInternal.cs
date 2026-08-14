using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnRedeemEntitlementsCallbackInternal(ref RedeemEntitlementsCallbackInfoInternal data);
}
