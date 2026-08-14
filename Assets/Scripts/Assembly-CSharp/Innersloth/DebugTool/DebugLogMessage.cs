using UnityEngine;

namespace Innersloth.DebugTool
{
	public readonly struct DebugLogMessage
	{
		public readonly string LogString;

		public readonly string Stacktrace;

		public readonly LogType LogType;

		public DebugLogMessage(string logString, string stacktrace, LogType logType)
		{
			LogString = null;
			Stacktrace = null;
			LogType = default(LogType);
		}
	}
}
