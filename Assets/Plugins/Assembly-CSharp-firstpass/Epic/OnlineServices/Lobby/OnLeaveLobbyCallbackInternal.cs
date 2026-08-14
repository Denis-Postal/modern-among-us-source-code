using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnLeaveLobbyCallbackInternal(ref LeaveLobbyCallbackInfoInternal data);
}
