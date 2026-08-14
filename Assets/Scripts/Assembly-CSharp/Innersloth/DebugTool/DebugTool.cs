using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Innersloth.DebugTool
{
	public static class DebugTool
	{
		public delegate void LogHandler(string message, DebugCommandMessageType type);

		private static readonly List<DebugCommand> AllCommands;

		private static readonly DebugCircleBuffer<DebugLogMessage> AllLogMessages;

		private static readonly Dictionary<Type, Func<string, object>> CustomParsers;

		private static readonly Dictionary<Type, Func<string[]>> CustomDropdownCollectors;

		private static Dictionary<Type, string> simpleTypeNames;

		public static IReadOnlyList<DebugCommand> Commands => null;

		public static IEnumerator<DebugLogMessage> Logs => null;

		public static bool ListeningToLogs { get; private set; }

		public static event LogHandler OnLogMessageReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void RegisterCommandHandler(object obj)
		{
		}

		public static void RegisterCommandHandler(Type t, object target = null)
		{
		}

		public static void UnregisterCommandHandler(Type t)
		{
		}

		public static void UnregisterCommandHandler(object obj)
		{
		}

		public static DebugCommand AddCommand(string commandPath, Action commandAction, bool closeBeforeExecute = false)
		{
			return null;
		}

		public static DebugCommand AddCommand<T>(string commandPath, Action<T> commandAction, bool closeBeforeExecute = false)
		{
			return null;
		}

		public static DebugCommand AddCommand<T1, T2>(string commandPath, Action<T1, T2> commandAction, bool closeBeforeExecute = false)
		{
			return null;
		}

		public static void AddCommand(DebugCommand command)
		{
		}

		public static void RemoveCommand(string commandPath)
		{
		}

		public static void AddCustomParser<T>(Func<string, T> parser)
		{
		}

		public static object ParseInputToType(string rawValue, string fieldName, Type type)
		{
			return null;
		}

		public static void AddCustomDropdownValueCollector<T>(Func<string[]> collector)
		{
		}

		public static bool HasDropdownValueCollector(Type type)
		{
			return false;
		}

		public static string[] GetDropdownValues(Type type)
		{
			return null;
		}

		public static void ListenToLogs()
		{
		}

		private static void LogMessageReceived(string log, string stacktrace, LogType type)
		{
		}

		public static void ClearLogs()
		{
		}

		public static void LogCommandInfo(string log)
		{
		}

		public static void LogCommandSuccess(string log)
		{
		}

		public static void LogCommandWarning(string log)
		{
		}

		public static void LogCommandError(string log)
		{
		}

		private static void Log(string message, DebugCommandMessageType type)
		{
		}

		public static string GetTypeName(Type type)
		{
			return null;
		}
	}
}
