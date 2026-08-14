using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Achievements
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void OnAchievementsUnlockedCallbackInternal(ref OnAchievementsUnlockedCallbackInfoInternal data);
}
