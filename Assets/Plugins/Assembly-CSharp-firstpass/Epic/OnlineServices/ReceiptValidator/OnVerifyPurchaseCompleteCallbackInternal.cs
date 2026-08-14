using System.Runtime.InteropServices;

namespace Epic.OnlineServices.ReceiptValidator
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnVerifyPurchaseCompleteCallbackInternal(ref VerifyPurchaseCompleteCallbackInfoInternal data);
}
