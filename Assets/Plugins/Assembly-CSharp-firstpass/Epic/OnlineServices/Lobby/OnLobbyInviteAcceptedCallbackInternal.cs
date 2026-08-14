using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnLobbyInviteAcceptedCallbackInternal(ref LobbyInviteAcceptedCallbackInfoInternal data);
}
