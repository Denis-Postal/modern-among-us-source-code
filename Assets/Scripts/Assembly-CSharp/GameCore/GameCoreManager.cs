using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace GameCore
{
	public class GameCoreManager : MonoBehaviour
	{
		public LocalizationProvider LocalizationProvider;

		public Action OnSuspend;

		public Action<double> OnResume;

		public Action<bool> OnResourceChange;

		private Thread dispatchJob;

		private bool stopExecution;

		private Dictionary<string, ulong> puid2xuid;

		private List<KeyValuePair<string, ulong>> xUIDsToCheckIfBlocked;

		private HashSet<string> nonXuids;

		private Dictionary<string, string> censoredTexts;

		public static GameCoreManager Instance { get; private set; }

		public UserManager UserManager { get; private set; }

		public NetworkManager NetworkManager { get; private set; }

		public SaveManager SaveManager { get; private set; }

		public StoreManager StoreManager { get; private set; }

		private void Awake()
		{
		}
	}
}
