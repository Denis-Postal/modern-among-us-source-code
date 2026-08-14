using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnSendLobbyNativeInviteRequestedCallbackInternal(ref SendLobbyNativeInviteRequestedCallbackInfoInternal data);
}
