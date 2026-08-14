using System.Collections.Generic;
using System.Reflection;

namespace Innersloth.DebugTool
{
	public class DebugCommand
	{
		public readonly string CommandPath;

		public readonly MethodInfo ActionInfo;

		public readonly object Target;

		public string Description;

		public bool CloseBeforeExecute;

		private readonly Dictionary<int, string> argumentPlaceholders;

		public string Directory => null;

		public string CommandName => null;

		public DebugCommand(string commandPath, object target, MethodInfo methodInfo)
		{
		}

		public string GetArgumentPlaceholder(int i)
		{
			return null;
		}

		public void SetArgumentPlaceholder(int i, string placeholder)
		{
		}
	}
}
