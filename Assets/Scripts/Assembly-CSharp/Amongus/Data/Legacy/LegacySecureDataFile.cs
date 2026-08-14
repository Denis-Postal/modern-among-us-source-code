using System;
using System.IO;

namespace AmongUs.Data.Legacy
{
	public class LegacySecureDataFile
	{
		private string filePath;

		public bool Loaded { get; private set; }

		public LegacySecureDataFile(string filePath)
		{
		}

		public void LoadData(Action<BinaryReader> performRead)
		{
		}

		public void Delete()
		{
		}
	}
}
