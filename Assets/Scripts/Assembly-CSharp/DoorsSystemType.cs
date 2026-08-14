using System;
using System.Collections.Generic;
using Hazel;

public class DoorsSystemType : ISystemType, IActivatable, RunTimer, IDoorSystem
{
	public const byte CloseDoors = 128;

	public const byte OpenDoor = 64;

	private const byte ActionMask = 192;

	private const byte IdMask = 31;

	private readonly Dictionary<SystemTypes, float> timers = new Dictionary<SystemTypes, float>();

	private OpenableDoor[] doors;

	private uint dirtyBits;

	private float initialCooldown;

	public bool IsActive
	{
		get
		{
			if (doors == null)
			{
				return false;
			}
			for (int i = 0; i < doors.Length; i++)
			{
				if ((bool)doors[i] && !doors[i].IsOpen)
				{
					return true;
				}
			}
			return false;
		}
	}

	public bool IsDirty { get; private set; }

	public DoorsSystemType()
	{
	}

	public DoorsSystemType(OpenableDoor[] doors)
	{
		SetDoors(doors);
	}

	public DoorsSystemType(AutoOpenDoor[] doors)
	{
		SetDoors(doors);
	}

	public void SetDoors(OpenableDoor[] doors)
	{
		this.doors = doors;
	}

	public void SetDoors(AutoOpenDoor[] doors)
	{
		if (doors == null)
		{
			this.doors = null;
			return;
		}
		this.doors = new OpenableDoor[doors.Length];
		for (int i = 0; i < doors.Length; i++)
		{
			this.doors[i] = doors[i];
		}
	}

	public void Deteriorate(float deltaTime)
	{
		DecrementTimers(deltaTime);
		if (doors == null)
		{
			return;
		}
		for (int i = 0; i < doors.Length && i < 32; i++)
		{
			OpenableDoor door = doors[i];
			if ((bool)door && door.DoUpdate(deltaTime))
			{
				SetDirtyBit(i);
			}
		}
	}

	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
		UpdateSystem(player, msgReader.ReadByte());
	}

	public void UpdateSystem(PlayerControl player, byte amount)
	{
		byte action = (byte)(amount & ActionMask);
		byte value = (byte)(amount & IdMask);
		if (action == CloseDoors)
		{
			CloseDoorsOfType((SystemTypes)value);
		}
		else if (action == OpenDoor)
		{
			SetDoorById(value, true);
		}
	}

	public void MarkClean()
	{
		dirtyBits = 0u;
		IsDirty = false;
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
		if (doors == null)
		{
			if (!initialState)
			{
				writer.WritePacked(0u);
			}
			return;
		}
		if (initialState)
		{
			for (int i = 0; i < doors.Length; i++)
			{
				WriteDoor(writer, doors[i]);
			}
			return;
		}
		writer.WritePacked(dirtyBits);
		for (int j = 0; j < doors.Length && j < 32; j++)
		{
			if ((dirtyBits & (uint)(1 << j)) != 0)
			{
				WriteDoor(writer, doors[j]);
			}
		}
		MarkClean();
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
		if (doors == null)
		{
			if (!initialState)
			{
				reader.ReadPackedUInt32();
			}
			return;
		}
		if (initialState)
		{
			for (int i = 0; i < doors.Length; i++)
			{
				ReadDoor(reader, doors[i]);
			}
			return;
		}
		uint changedBits = reader.ReadPackedUInt32();
		for (int j = 0; j < doors.Length && j < 32; j++)
		{
			if ((changedBits & (uint)(1 << j)) != 0)
			{
				ReadDoor(reader, doors[j]);
			}
		}
	}

	public void SetDoor(AutoOpenDoor door, bool open)
	{
		SetDoor((OpenableDoor)door, open);
	}

	public void SetDoor(OpenableDoor door, bool open)
	{
		if (!door)
		{
			return;
		}
		door.SetDoorway(open);
		int index = IndexOfDoor(door);
		if (index >= 0)
		{
			SetDirtyBit(index);
		}
	}

	public void CloseDoorsOfType(SystemTypes room)
	{
		if (GetTimer(room) > 0f)
		{
			return;
		}
		timers[room] = AutoOpenDoor.CooldownDuration;
		if (doors == null)
		{
			IsDirty = true;
			return;
		}
		for (int i = 0; i < doors.Length && i < 32; i++)
		{
			OpenableDoor door = doors[i];
			if ((bool)door && door.Room == room)
			{
				door.SetDoorway(false);
				SetDirtyBit(i);
			}
		}
	}

	public float GetTimer(SystemTypes room)
	{
		float timer;
		if (timers.TryGetValue(room, out timer))
		{
			return timer;
		}
		if (doors != null)
		{
			for (int i = 0; i < doors.Length; i++)
			{
				AutoOpenDoor autoOpenDoor = doors[i] as AutoOpenDoor;
				if ((bool)autoOpenDoor && autoOpenDoor.Room == room)
				{
					return autoOpenDoor.CooldownTimer;
				}
			}
		}
		return initialCooldown;
	}

	public void SetInitialSabotageCooldown()
	{
		initialCooldown = AutoOpenDoor.CooldownDuration;
		IsDirty = true;
	}

	private void SetDoorById(int id, bool open)
	{
		if (doors == null)
		{
			return;
		}
		for (int i = 0; i < doors.Length && i < 32; i++)
		{
			OpenableDoor door = doors[i];
			if ((bool)door && (door.Id == id || i == id))
			{
				door.SetDoorway(open);
				SetDirtyBit(i);
				return;
			}
		}
	}

	private void DecrementTimers(float deltaTime)
	{
		if (initialCooldown > 0f)
		{
			initialCooldown = Math.Max(initialCooldown - deltaTime, 0f);
		}
		if (timers.Count == 0)
		{
			return;
		}
		SystemTypes[] keys = new SystemTypes[timers.Count];
		timers.Keys.CopyTo(keys, 0);
		for (int i = 0; i < keys.Length; i++)
		{
			SystemTypes key = keys[i];
			timers[key] = Math.Max(timers[key] - deltaTime, 0f);
		}
	}

	private void SetDirtyBit(int index)
	{
		if (index < 0 || index >= 32)
		{
			return;
		}
		dirtyBits |= (uint)(1 << index);
		IsDirty = true;
	}

	private int IndexOfDoor(OpenableDoor door)
	{
		if (doors == null)
		{
			return -1;
		}
		for (int i = 0; i < doors.Length; i++)
		{
			if (doors[i] == door)
			{
				return i;
			}
		}
		return -1;
	}

	private static void WriteDoor(MessageWriter writer, OpenableDoor door)
	{
		if ((bool)door)
		{
			door.Serialize(writer);
		}
		else
		{
			writer.Write(true);
		}
	}

	private static void ReadDoor(MessageReader reader, OpenableDoor door)
	{
		if ((bool)door)
		{
			door.Deserialize(reader);
		}
		else
		{
			reader.ReadBoolean();
		}
	}
}
