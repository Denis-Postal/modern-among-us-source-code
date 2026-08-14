using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data
{
	public abstract class AbstractSaveData : AbstractSaveDataGroup
	{
		[JsonProperty("dataVersion")]
		protected int dataVersion;

		private const byte XOR_KEY = 212;

		public bool IsDirty { get; private set; }

		protected abstract AbstractSaveDataGroup[] Groups { get; }

		protected virtual int CurrentVersion => 0;

		public event Action OnSavedEvent
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

		public event Action OnLoadedEvent
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

		public AbstractSaveData()
		{
		}

		protected abstract void HandleSave();

		protected abstract void HandleLoad();

		protected abstract void HandleDelete();

		protected abstract bool HandleDoesFileExist();

		protected override void HandleChange()
		{
		}

		public bool DoesFileExist()
		{
			return false;
		}

		public void Save()
		{
		}

		public void ForceSave()
		{
		}

		public void Load()
		{
		}

		public void ForceLoad()
		{
		}

		private void ForEachGroup(Action<ISaveDataGroupControl> action)
		{
		}

		public void Delete()
		{
		}

		private void CheckVersionMigration()
		{
		}

		protected virtual void HandleVersionMigration(int version)
		{
		}

		protected static bool TrySaveToJsonFile(object value, string filename)
		{
			return false;
		}

		protected static bool TryLoadFromJsonFile<T>(string filename, out T output)
		{
			output = default(T);
			return false;
		}

		protected static bool TryLoadAndOverwriteFromJsonFile<T>(T target, string filename)
		{
			return false;
		}

		protected bool TrySerializeAndEncrypt(object target, out byte[] output)
		{
			output = null;
			return false;
		}

		protected bool TryDecryptAndDeserialize<T>(ref T target, byte[] encryptedBytes)
		{
			return false;
		}
	}
}
