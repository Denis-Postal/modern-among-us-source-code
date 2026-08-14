using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using Rewired.Data;
using UnityEngine;

namespace AmongUs.Data.Settings
{
	public class RewiredUserDataStore_PlayerData : UserDataStore
	{
		private class ControllerAssignmentSaveInfo
		{
			public class PlayerInfo
			{
				public int id;

				public bool hasKeyboard;

				public bool hasMouse;

				public JoystickInfo[] joysticks;

				public int joystickCount => 0;

				public int IndexOfJoystick(int joystickId)
				{
					return 0;
				}

				public bool ContainsJoystick(int joystickId)
				{
					return false;
				}
			}

			public class JoystickInfo
			{
				public Guid instanceGuid;

				public string hardwareIdentifier;

				public int id;
			}

			public PlayerInfo[] players;

			public int playerCount => 0;

			public ControllerAssignmentSaveInfo()
			{
			}

			public ControllerAssignmentSaveInfo(int playerCount)
			{
			}

			public int IndexOfPlayer(int playerId)
			{
				return 0;
			}

			public bool ContainsPlayer(int playerId)
			{
				return false;
			}
		}

		private class JoystickAssignmentHistoryInfo
		{
			public readonly Joystick joystick;

			public readonly int oldJoystickId;

			public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLoadJoystickAssignmentsDeferred_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewiredUserDataStore_PlayerData _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLoadJoystickAssignmentsDeferred_003Ed__62(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const string LEGACY_PLAYER_PREFS_KEY_PREFIX = "RewiredSaveData5";

		private const string logPrefix = "[RewiredUserDataStore_PlayerData]";

		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";

		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";

		private const int controllerMapPPKeyVersion_original = 0;

		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;

		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;

		private const int controllerMapPPKeyVersion_includeFormatVersion = 2;

		private const int controllerMapPPKeyVersion = 2;

		private static readonly Logger logger;

		[Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
		[SerializeField]
		private bool isEnabled;

		[SerializeField]
		[Tooltip("Should saved data be loaded on start?")]
		private bool loadDataOnStart;

		[SerializeField]
		[Tooltip("Should Player Keyboard assignments be saved and loaded?")]
		private bool loadKeyboardAssignments;

		[NonSerialized]
		[Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
		private bool loadJoystickAssignments;

		[NonSerialized]
		[Tooltip("Should Player Mouse assignments be saved and loaded?")]
		private bool loadMouseAssignments;

		[NonSerialized]
		private bool allowImpreciseJoystickAssignmentMatching;

		[NonSerialized]
		private bool deferredJoystickAssignmentLoadPending;

		[NonSerialized]
		private bool wasJoystickEverDetected;

		[NonSerialized]
		private List<int> cachedAllActionIds;

		[NonSerialized]
		private string cachedAllActionIdsString;

		private string PlayerPrefsKey_ControllerAssignments => null;

		private bool ShouldLoadControllerAssignments => false;

		private List<int> AllActionIds => null;

		private string AllActionIdsString => null;

		public override void Save()
		{
		}

		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		public override void SaveControllerData(ControllerType controllerType, int controllerId)
		{
		}

		public override void SavePlayerData(int playerId)
		{
		}

		public override void SaveInputBehavior(int playerId, int behaviorId)
		{
		}

		public override void Load()
		{
		}

		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		public override void LoadControllerData(ControllerType controllerType, int controllerId)
		{
		}

		public override void LoadPlayerData(int playerId)
		{
		}

		public override void LoadInputBehavior(int playerId, int behaviorId)
		{
		}

		protected override void OnInitialize()
		{
		}

		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
		}

		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
		{
		}

		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
		{
		}

		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		private int LoadAll()
		{
			return 0;
		}

		private int LoadPlayerDataNow(int playerId)
		{
			return 0;
		}

		private int LoadPlayerDataNow(Rewired.Player player)
		{
			return 0;
		}

		private int LoadAllJoystickCalibrationData()
		{
			return 0;
		}

		private int LoadJoystickCalibrationData(Joystick joystick)
		{
			return 0;
		}

		private int LoadJoystickCalibrationData(int joystickId)
		{
			return 0;
		}

		private int LoadJoystickData(int joystickId)
		{
			return 0;
		}

		private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			return 0;
		}

		private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
		{
			return 0;
		}

		private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			return 0;
		}

		private ControllerMap LoadControllerMap(Rewired.Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		private int LoadInputBehaviors(int playerId)
		{
			return 0;
		}

		private int LoadInputBehaviorNow(int playerId, int behaviorId)
		{
			return 0;
		}

		private int LoadInputBehaviorNow(Rewired.Player player, InputBehavior inputBehavior)
		{
			return 0;
		}

		private bool LoadControllerAssignmentsNow()
		{
			return false;
		}

		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
		{
			return false;
		}

		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
		{
			return false;
		}

		private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__62))]
		private IEnumerator LoadJoystickAssignmentsDeferred()
		{
			return null;
		}

		private void SaveAll()
		{
		}

		private void SavePlayerDataNow(int playerId)
		{
		}

		private void SavePlayerDataNow(Rewired.Player player)
		{
		}

		private void SaveAllJoystickCalibrationData()
		{
		}

		private void SaveJoystickCalibrationData(int joystickId)
		{
		}

		private void SaveJoystickCalibrationData(Joystick joystick)
		{
		}

		private void SaveJoystickData(int joystickId)
		{
		}

		private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
		{
		}

		private void SaveControllerMaps(Rewired.Player player, PlayerSaveData playerSaveData)
		{
		}

		private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		private void SaveControllerMap(Rewired.Player player, ControllerMap controllerMap)
		{
		}

		private void SaveInputBehaviors(Rewired.Player player, PlayerSaveData playerSaveData)
		{
		}

		private void SaveInputBehaviorNow(int playerId, int behaviorId)
		{
		}

		private void SaveInputBehaviorNow(Rewired.Player player, InputBehavior inputBehavior)
		{
		}

		private bool SaveControllerAssignments()
		{
			return false;
		}

		private string GetBasePlayerPrefsKey(Rewired.Player player)
		{
			return null;
		}

		private string GetControllerMapPlayerPrefsKey(Rewired.Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Rewired.Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Rewired.Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
		{
			return null;
		}

		private string GetInputBehaviorPlayerPrefsKey(Rewired.Player player, int inputBehaviorId)
		{
			return null;
		}

		private string GetControllerMapXml(Rewired.Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		private List<int> GetControllerMapKnownActionIds(Rewired.Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		private string GetJoystickCalibrationMapXml(Joystick joystick)
		{
			return null;
		}

		private string GetInputBehaviorXml(Rewired.Player player, int id)
		{
			return null;
		}

		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
		{
		}

		private bool ControllerAssignmentSaveDataExists()
		{
			return false;
		}

		private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
		{
			return null;
		}

		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
		{
			matches = null;
			return false;
		}

		private static int GetDuplicateIndex(Rewired.Player player, ControllerIdentifier controllerIdentifier)
		{
			return 0;
		}

		private void RefreshLayoutManager(int playerId)
		{
		}

		private static Type GetControllerMapType(ControllerType controllerType)
		{
			return null;
		}
	}
}
