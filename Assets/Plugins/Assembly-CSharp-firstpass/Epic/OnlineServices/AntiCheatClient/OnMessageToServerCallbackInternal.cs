using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatClient
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnMessageToServerCallbackInternal(ref OnMessageToServerCallbackInfoInternal data);
}
