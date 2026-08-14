using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Achievements
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnQueryDefinitionsCompleteCallbackInternal(ref OnQueryDefinitionsCompleteCallbackInfoInternal data);
}
