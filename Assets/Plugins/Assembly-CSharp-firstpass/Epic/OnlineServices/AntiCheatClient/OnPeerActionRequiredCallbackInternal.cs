using System.Runtime.InteropServices;
using Epic.OnlineServices.AntiCheatCommon;

namespace Epic.OnlineServices.AntiCheatClient
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnPeerActionRequiredCallbackInternal(ref OnClientActionRequiredCallbackInfoInternal data);
}
