using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Mods
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnUpdateModCallbackInternal(ref UpdateModCallbackInfoInternal data);
}
