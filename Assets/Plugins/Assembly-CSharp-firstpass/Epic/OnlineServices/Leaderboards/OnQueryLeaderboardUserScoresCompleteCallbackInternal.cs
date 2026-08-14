using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Leaderboards
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnQueryLeaderboardUserScoresCompleteCallbackInternal(ref OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal data);
}
