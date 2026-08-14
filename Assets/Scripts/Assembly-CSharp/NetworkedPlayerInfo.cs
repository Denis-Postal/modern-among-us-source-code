using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AmongUs.GameOptions;
using Hazel;
using InnerNet;
using UnityEngine;

public class NetworkedPlayerInfo : InnerNetObject
{
	public class TaskInfo
	{
		public uint Id;

		public byte TypeId;

		public bool Complete;

		public TaskInfo()
		{
		}

		public TaskInfo(byte typeId, uint id)
		{
			TypeId = typeId;
			Id = id;
		}

		public void Serialize(MessageWriter writer)
		{
			writer.WritePacked(Id);
			writer.Write(TypeId);
			writer.Write(Complete);
		}

		public void Deserialize(MessageReader reader)
		{
			Id = reader.ReadPackedUInt32();
			TypeId = reader.ReadByte();
			Complete = reader.ReadBoolean();
		}
	}

	public class PlayerOutfit
	{
		private const string MISSING_COSMETIC_ID = "missing";

		public int ColorId;

		public string HatId;

		public string PetId;

		public string SkinId;

		public string VisorId;

		public string NamePlateId;

		public string PlayerName;

		public byte HatSequenceId;

		public byte PetSequenceId;

		public byte SkinSequenceId;

		public byte VisorSequenceId;

		public byte NamePlateSequenceId;

		public bool IsIncomplete => string.IsNullOrEmpty(PlayerName) || ColorId < 0 || string.IsNullOrEmpty(HatId) || string.IsNullOrEmpty(PetId) || string.IsNullOrEmpty(SkinId) || string.IsNullOrEmpty(VisorId) || string.IsNullOrEmpty(NamePlateId);

		public override string ToString()
		{
			return PlayerName ?? string.Empty;
		}

		public void Serialize(MessageWriter writer)
		{
		}

		public void Deserialize(MessageReader reader)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCoCensorNameAsync_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkedPlayerInfo _003C_003E4__this;

		public Action callback;

		private int _003Cattempts_003E5__2;

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
		public _003CCoCensorNameAsync_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CCoUpdateColor_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkedPlayerInfo _003C_003E4__this;

		public int colorId;

		private int _003Cattempts_003E5__2;

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
		public _003CCoUpdateColor_003Ed__48(int _003C_003E1__state)
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

	private const int MAX_NETOBJECT_INIT_ATTEMPTS = 60;

	private const float NETOBJECT_INIT_ATTEMPT_WAIT_SECONDS = 0.1f;

	public byte PlayerId;

	public int ClientId;

	public string FriendCode;

	public string Puid;

	public RoleTypes RoleType;

	public RoleTypes? RoleWhenAlive;

	public Dictionary<PlayerOutfitType, PlayerOutfit> Outfits;

	public uint PlayerLevel;

	public bool Disconnected;

	public RoleBehaviour Role;

	public List<TaskInfo> Tasks;

	public bool IsDead;

	public bool WasEjected;

	private PlayerControl _object;

	public bool IsIncomplete => DefaultOutfit == null || DefaultOutfit.IsIncomplete;

	public PlayerControl Object
	{
		get
		{
			if (!_object)
			{
				for (int i = 0; PlayerControl.AllPlayerControls != null && i < PlayerControl.AllPlayerControls.Count; i++)
				{
					PlayerControl player = PlayerControl.AllPlayerControls[i];
					if ((bool)player && player.PlayerId == PlayerId)
					{
						_object = player;
						break;
					}
				}
			}
			return _object;
		}
	}

	public PlayerOutfit DefaultOutfit
	{
		get
		{
			if (Outfits == null)
			{
				Outfits = new Dictionary<PlayerOutfitType, PlayerOutfit>();
			}
			if (!Outfits.TryGetValue(PlayerOutfitType.Default, out PlayerOutfit outfit) || outfit == null)
			{
				outfit = CreateDefaultOutfit();
				Outfits[PlayerOutfitType.Default] = outfit;
			}
			return outfit;
		}
	}

	public string PlayerName
	{
		get
		{
			return DefaultOutfit != null ? DefaultOutfit.PlayerName : string.Empty;
		}
		set
		{
			DefaultOutfit.PlayerName = value;
			MarkDirty();
		}
	}

	public Color Color => default(Color);

	public Color ShadowColor => default(Color);

	public string ColorName => null;

	public void Init(PlayerControl pc, int clientId)
	{
		_object = pc;
		PlayerId = pc.PlayerId;
		ClientId = clientId;
		FriendCode = pc.FriendCode;
		Puid = pc.Puid;
		PlayerLevel = 0u;
		Disconnected = false;
		IsDead = false;
		WasEjected = false;
		if (Tasks == null)
		{
			Tasks = new List<TaskInfo>();
		}
		if (Outfits == null)
		{
			Outfits = new Dictionary<PlayerOutfitType, PlayerOutfit>();
		}
		if (!Outfits.ContainsKey(PlayerOutfitType.Default))
		{
			Outfits[PlayerOutfitType.Default] = CreateDefaultOutfit();
		}
		if (pc.CurrentOutfit != null)
		{
			SetOutfit(PlayerOutfitType.Default, pc.CurrentOutfit);
		}
		if (Role == null && GameData.Instance != null)
		{
			Role = GameData.Instance.DefaultRole;
		}
	}

	public void MarkDirty()
	{
		SetDirtyBit(uint.MaxValue);
	}

	public override void ClearOrDecrementDirt()
	{
		ClearDirtyBits();
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	public string GetPlayerName(PlayerOutfitType outfitType)
	{
		if (Outfits != null && Outfits.TryGetValue(outfitType, out PlayerOutfit outfit) && outfit != null)
		{
			return outfit.PlayerName;
		}
		return PlayerName;
	}

	public void CensorNameAsync(Action callback = null)
	{
	}

	[IteratorStateMachine(typeof(_003CCoCensorNameAsync_003Ed__38))]
	private IEnumerator CoCensorNameAsync(Action callback = null)
	{
		return null;
	}

	public string GetPlayerColorString(PlayerOutfitType outfitType = PlayerOutfitType.Default)
	{
		PlayerOutfit outfit = DefaultOutfit;
		if (Outfits != null && Outfits.TryGetValue(outfitType, out PlayerOutfit typedOutfit) && typedOutfit != null)
		{
			outfit = typedOutfit;
		}
		return outfit != null ? outfit.ColorId.ToString() : "0";
	}

	public TaskInfo FindTaskById(uint taskId)
	{
		if (Tasks == null)
		{
			return null;
		}
		for (int i = 0; i < Tasks.Count; i++)
		{
			if (Tasks[i] != null && Tasks[i].Id == taskId)
			{
				return Tasks[i];
			}
		}
		return null;
	}

	public void SetOutfit(PlayerOutfitType outfitType, PlayerOutfit outfit)
	{
		if (outfit == null)
		{
			return;
		}
		if (Outfits == null)
		{
			Outfits = new Dictionary<PlayerOutfitType, PlayerOutfit>();
		}
		Outfits[outfitType] = CloneOutfit(outfit);
		MarkDirty();
	}

	public void UpdateNamePlate(string namePlate)
	{
		DefaultOutfit.NamePlateId = string.IsNullOrEmpty(namePlate) ? NamePlateData.EmptyId : namePlate;
		MarkDirty();
	}

	public void UpdateVisor(string visor)
	{
		DefaultOutfit.VisorId = string.IsNullOrEmpty(visor) ? VisorData.EmptyId : visor;
		MarkDirty();
	}

	public void UpdateSkin(string skin)
	{
		DefaultOutfit.SkinId = string.IsNullOrEmpty(skin) ? SkinData.EmptyId : skin;
		MarkDirty();
	}

	public void UpdatePet(string petId)
	{
		DefaultOutfit.PetId = string.IsNullOrEmpty(petId) ? PetData.EmptyId : petId;
		MarkDirty();
	}

	public void UpdateHat(string hat)
	{
		DefaultOutfit.HatId = string.IsNullOrEmpty(hat) ? HatData.EmptyId : hat;
		MarkDirty();
	}

	public void UpdateColor(int colorId)
	{
		DefaultOutfit.ColorId = colorId;
		MarkDirty();
	}

	[IteratorStateMachine(typeof(_003CCoUpdateColor_003Ed__48))]
	private IEnumerator CoUpdateColor(int colorId)
	{
		return null;
	}

	private void UpdateHostPanelImage()
	{
	}

	public void UpdateLevel(uint level)
	{
		PlayerLevel = level;
		MarkDirty();
	}

	private void UpdateName(string playerName, ClientData client)
	{
		PlayerName = string.IsNullOrWhiteSpace(playerName) ? "Player" : playerName;
		client?.UpdatePlayerName(PlayerName);
	}

	public void OnGameStart()
	{
		IsDead = false;
	}

	public void OnGameEnd()
	{
	}

	private void SetTasks(byte[] taskTypeIds)
	{
		Tasks = new List<TaskInfo>();
		if (taskTypeIds == null)
		{
			return;
		}
		for (int i = 0; i < taskTypeIds.Length; i++)
		{
			Tasks.Add(new TaskInfo(taskTypeIds[i], (uint)i));
		}
	}

	public void RpcSetTasks(byte[] taskTypeIds)
	{
		SetTasks(taskTypeIds);
		MarkDirty();
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	private static PlayerOutfit CreateDefaultOutfit()
	{
		return new PlayerOutfit
		{
			ColorId = PlayerCustomization.ColorId,
			HatId = PlayerCustomization.HatId,
			PetId = PlayerCustomization.PetId,
			SkinId = PlayerCustomization.SkinId,
			VisorId = PlayerCustomization.VisorId,
			NamePlateId = PlayerCustomization.NameplateId,
			PlayerName = PlayerPrefs.GetString("PlayerName", "Player")
		};
	}

	private static PlayerOutfit CloneOutfit(PlayerOutfit outfit)
	{
		return new PlayerOutfit
		{
			ColorId = outfit.ColorId,
			HatId = outfit.HatId,
			PetId = outfit.PetId,
			SkinId = outfit.SkinId,
			VisorId = outfit.VisorId,
			NamePlateId = outfit.NamePlateId,
			PlayerName = outfit.PlayerName,
			HatSequenceId = outfit.HatSequenceId,
			PetSequenceId = outfit.PetSequenceId,
			SkinSequenceId = outfit.SkinSequenceId,
			VisorSequenceId = outfit.VisorSequenceId,
			NamePlateSequenceId = outfit.NamePlateSequenceId
		};
	}
}
