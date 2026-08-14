using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Switch
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int SwitchOnNetworkRequestedInternal();
}
