using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Leaderboards
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnQueryLeaderboardRanksCompleteCallbackInternal(ref OnQueryLeaderboardRanksCompleteCallbackInfoInternal data);
}
