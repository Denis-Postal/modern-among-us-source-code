namespace Epic.OnlineServices.Logging
{
	public sealed class LoggingInterface
	{
		public static Result SetCallback(LogMessageFunc callback)
		{
			return default(Result);
		}

		public static Result SetLogLevel(LogCategory logCategory, LogLevel logLevel)
		{
			return default(Result);
		}

		[MonoPInvokeCallback(typeof(LogMessageFuncInternal))]
		internal static void LogMessageFuncInternalImplementation(ref LogMessageInternal message)
		{
		}
	}
}
