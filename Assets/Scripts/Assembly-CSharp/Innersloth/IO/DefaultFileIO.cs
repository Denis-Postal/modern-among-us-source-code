namespace Innersloth.IO
{
	public class DefaultFileIO : IPlatformFileIO
	{
		private string userName;

		private string platformName;

		public virtual string GetUserName()
		{
			return null;
		}

		public virtual string GetPlatformName()
		{
			return null;
		}

		public string GetRootDataPath()
		{
			return null;
		}

		public virtual bool Exists(string path)
		{
			return false;
		}

		public virtual string ReadAllText(string path)
		{
			return null;
		}

		public virtual void WriteAllText(string path, string contents)
		{
		}

		public virtual byte[] ReadAllBytes(string path)
		{
			return null;
		}

		public virtual void WriteAllBytes(string path, byte[] bytes)
		{
		}

		public virtual void Delete(string path)
		{
		}
	}
}
