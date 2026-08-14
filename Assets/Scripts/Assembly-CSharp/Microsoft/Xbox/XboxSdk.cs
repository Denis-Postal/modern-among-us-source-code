using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Microsoft.Xbox
{
	public class XboxSdk : MonoBehaviour
	{
		public delegate void OnGameSaveLoadedHandler(object sender, GameSaveLoadedArgs e);

		public delegate void OnErrorHandler(object sender, ErrorEventArgs e);

		public Text dlcOutputTextBox;

		[Header("You can find the value of the scid in your MicrosoftGame.config")]
		public string scid;

		public Text gamertagLabel;

		public bool signInOnStart;

		private static XboxSdk _xboxHelpers;

		private static bool _initialized;

		private const string _GAME_SAVE_CONTAINER_NAME = "x_game_save_default_container";

		private const string _GAME_SAVE_BLOB_NAME = "x_game_save_default_blob";

		public static XboxSdk Helpers => null;

		public event OnGameSaveLoadedHandler OnGameSaveLoaded
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

		public event OnErrorHandler OnError
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

		private void Start()
		{
		}

		private void _Initialize()
		{
		}

		public void SignIn()
		{
		}

		public void Save(byte[] data)
		{
		}

		public void LoadSaveData()
		{
		}

		public void UnlockAchievement(string achievementId)
		{
		}

		private void Update()
		{
		}

		protected static bool Succeeded(int hresult, string operationFriendlyName)
		{
			return false;
		}

		private static void _LogError(string message)
		{
		}
	}
}
