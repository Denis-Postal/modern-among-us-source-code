using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Logging
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void LogMessageFuncInternal(ref LogMessageInternal message);
}
