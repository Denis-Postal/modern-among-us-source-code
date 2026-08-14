using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnJoinLobbyAcceptedCallbackInternal(ref JoinLobbyAcceptedCallbackInfoInternal data);
}
