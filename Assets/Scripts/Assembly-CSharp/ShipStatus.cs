using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Hazel;
using InnerNet;
using PowerTools;
using UnityEngine;

public class ShipStatus : InnerNetObject
{
	public enum MapType
	{
		Ship = 0,
		Hq = 1,
		Pb = 2,
		Fungle = 3
	}

	public class SystemTypeComparer : IEqualityComparer<SystemTypes>
	{
		public static readonly SystemTypeComparer Instance;

		public bool Equals(SystemTypes x, SystemTypes y)
		{
			return false;
		}

		public int GetHashCode(SystemTypes obj)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCoStartMeeting_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControl reporter;

		public NetworkedPlayerInfo target;

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
		public _003CCoStartMeeting_003Ed__102(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CPrespawnStep_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CPrespawnStep_003Ed__94(int _003C_003E1__state)
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

	public static ShipStatus Instance;

	public Color CameraColor;

	public float MaxLightRadius;

	public float MinLightRadius;

	public float MapScale;

	public MapBehaviour MapPrefab;

	public ExileController ExileCutscenePrefab;

	public MeetingCalledAnimation EmergencyOverlay;

	public MeetingCalledAnimation ReportOverlay;

	public Sprite MeetingBackground;

	public Sprite BrokenEmergencyButton;

	public SystemConsole EmergencyButton;

	public Vector2 InitialSpawnCenter;

	public Vector2 MeetingSpawnCenter;

	public Vector2 MeetingSpawnCenter2;

	public float SpawnRadius;

	public NormalPlayerTask[] CommonTasks;

	public NormalPlayerTask[] LongTasks;

	public NormalPlayerTask[] ShortTasks;

	public PlayerTask[] SpecialTasks;

	public Transform[] DummyLocations;

	[NonSerialized]
	public SurvCamera[] AllCameras;

	public OpenableDoor[] AllDoors;

	[NonSerialized]
	public Console[] AllConsoles;

	[NonSerialized]
	public Ladder[] Ladders;

	public Dictionary<SystemTypes, ISystemType> Systems;

	public StringNames[] SystemNames;

	public StringNames[] ExtraTaskNames;

	public AudioClip SabotageSound;

	public AnimationClip[] WeaponFires;

	public SpriteAnim WeaponsImage;

	public AudioClip[] VentMoveSounds;

	public AudioClip VentEnterSound;

	public AudioClip VentExitSound;

	public AnimationClip HatchActive;

	public SpriteAnim Hatch;

	public ParticleSystem HatchParticles;

	public AnimationClip ShieldsActive;

	public SpriteAnim[] ShieldsImages;

	public SpriteRenderer ShieldBorder;

	public Sprite ShieldBorderOn;

	public MedScannerBehaviour MedScanner;

	private int WeaponFireIdx;

	public float Timer;

	public float EmergencyCooldown;

	public MapType Type;

	protected readonly Logger logger;

	private int numScans;

	public IStepWatcher[] AllStepWatchers { get; private set; }

	public PlainShipRoom[] AllRooms { get; private set; }

	public Dictionary<SystemTypes, PlainShipRoom> FastRooms { get; private set; }

	public Vent[] AllVents { get; private set; }

	public float HideCountdown { get; set; }

	public CosmeticsCache CosmeticsCache { get; set; }

	public override bool IsDirty => false;

	protected virtual void OnEnable()
	{
		EnsureDoorSystem();
	}

	public virtual void RepairCriticalSabotages()
	{
	}

	private void Awake()
	{
		EnsureDoorSystem();
	}

	protected virtual void Start()
	{
	}

	public override void OnDestroy()
	{
	}

	public virtual void SpawnPlayer(PlayerControl player, int numPlayers, bool initialSpawn)
	{
	}

	public void StartShields()
	{
	}

	public void FireWeapon()
	{
	}

	public NormalPlayerTask GetTaskById(byte idx)
	{
		return null;
	}

	public PlayerTask[] GetAllTasks()
	{
		return null;
	}

	public bool HasTaskType<TTaskType>() where TTaskType : PlayerTask
	{
		return false;
	}

	public bool HasTaskTypes(params Type[] types)
	{
		return false;
	}

	private void InitializeExtraTaskNames()
	{
	}

	public void OpenHatch()
	{
	}

	public void CloseDoorsOfType(SystemTypes room)
	{
		EnsureDoorSystem();
		DoorsSystemType doorsSystem = GetDoorsSystem();
		if (doorsSystem != null)
		{
			doorsSystem.CloseDoorsOfType(room);
			SetDirtyBit(1u << (int)SystemTypes.Doors);
		}
	}

	public void UpdateSystem(SystemTypes systemType, PlayerControl player, byte amount)
	{
		EnsureDoorSystem();
		DoorsSystemType doorsSystem = GetDoorsSystem();
		if (systemType == SystemTypes.Doors && doorsSystem != null)
		{
			doorsSystem.UpdateSystem(player, amount);
			SetDirtyBit(1u << (int)SystemTypes.Doors);
		}
	}

	public void UpdateSystem(SystemTypes systemType, PlayerControl player, MessageReader msgReader)
	{
		EnsureDoorSystem();
		ISystemType system;
		if (Systems != null && Systems.TryGetValue(systemType, out system) && system != null)
		{
			system.UpdateSystem(player, msgReader);
			SetDirtyBit(1u << (int)systemType);
		}
	}

	private void EnsureDoorSystem()
	{
		if (AllDoors == null || AllDoors.Length == 0)
		{
			AllDoors = GetComponentsInChildren<OpenableDoor>(true);
		}
		if (Systems == null)
		{
			Systems = new Dictionary<SystemTypes, ISystemType>();
		}
		DoorsSystemType doorsSystem = GetDoorsSystem();
		if (doorsSystem == null)
		{
			doorsSystem = new DoorsSystemType(AllDoors);
			Systems[SystemTypes.Doors] = doorsSystem;
		}
		else
		{
			doorsSystem.SetDoors(AllDoors);
		}
	}

	private DoorsSystemType GetDoorsSystem()
	{
		if (Systems == null)
		{
			return null;
		}
		ISystemType system;
		if (Systems.TryGetValue(SystemTypes.Doors, out system))
		{
			return system as DoorsSystemType;
		}
		return null;
	}

	private void AssignTaskIndexes()
	{
	}

	public virtual void OnMeetingCalled()
	{
	}

	public virtual void StartSFX()
	{
	}

	[IteratorStateMachine(typeof(_003CPrespawnStep_003Ed__94))]
	public virtual IEnumerator PrespawnStep()
	{
		return null;
	}

	public void Begin()
	{
	}

	private void AddTasksFromList(ref int start, int count, List<byte> tasks, HashSet<TaskTypes> usedTaskTypes, List<NormalPlayerTask> unusedTasks)
	{
	}

	public void FixedUpdate()
	{
	}

	public virtual float CalculateLightRadius(NetworkedPlayerInfo player)
	{
		return 0f;
	}

	public void StartMeeting(PlayerControl reporter, NetworkedPlayerInfo target)
	{
	}

	public PlayerTask GetSabotageTask(SystemTypes system)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoStartMeeting_003Ed__102))]
	public IEnumerator CoStartMeeting(PlayerControl reporter, NetworkedPlayerInfo target)
	{
		return null;
	}

	public void BreakEmergencyButton()
	{
	}

	private void ValidateAllTasksOnShip()
	{
	}

	public void RpcCloseDoorsOfType(SystemTypes type)
	{
		CloseDoorsOfType(type);
	}

	public void RpcUpdateSystem(SystemTypes systemType, byte amount)
	{
		UpdateSystem(systemType, PlayerControl.LocalPlayer, amount);
	}

	public void RpcUpdateSystem(SystemTypes systemType, MessageWriter msgWriter)
	{
	}

	public override void ClearOrDecrementDirt()
	{
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}
}
