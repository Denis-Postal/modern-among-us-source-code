namespace Innersloth.IO
{
	public static class FileIO
	{
		private static IPlatformFileIO platform;

		static FileIO()
		{
		}

		public static string GetUserName()
		{
			return null;
		}

		public static string GetPlatformName()
		{
			return null;
		}

		public static string GetRootDataPath()
		{
			return null;
		}

		public static bool Exists(string path)
		{
			return false;
		}

		public static string ReadAllText(string path)
		{
			return null;
		}

		public static void WriteAllText(string path, string contents)
		{
		}

		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		public static void Delete(string path)
		{
		}

		public static string GetDataPathTo(params string[] directories)
		{
			return null;
		}

		public static string FilterText(string input, string inputCompo = "")
		{
			return null;
		}

		public static bool IsCharAllowed(char i)
		{
			return false;
		}
	}
}
