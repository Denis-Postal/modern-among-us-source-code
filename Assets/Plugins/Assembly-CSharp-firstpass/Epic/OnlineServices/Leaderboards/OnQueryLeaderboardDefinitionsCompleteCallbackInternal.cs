using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Leaderboards
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnQueryLeaderboardDefinitionsCompleteCallbackInternal(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal data);
}
