using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Achievements
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnAchievementsUnlockedCallbackV2Internal(ref OnAchievementsUnlockedCallbackV2InfoInternal data);
}
