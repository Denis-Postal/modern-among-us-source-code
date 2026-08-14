using System;
using Hazel;
using UnityEngine;

namespace InnerNet
{
	public abstract class InnerNetObject : MonoBehaviour, IComparable<InnerNetObject>
	{
		public uint SpawnId;

		public uint NetId;

		protected uint DirtyBits;

		public SpawnFlags SpawnFlags;

		public SendOption sendMode;

		public int OwnerId;

		protected bool DespawnOnDestroy;

		public virtual bool IsDirty => DirtyBits != 0;

		public bool AmOwner => global::AmongUsClient.Instance != null && (OwnerId == global::AmongUsClient.Instance.ClientId || OwnerId == InnerNetClient.ServerOwned);

		public void Despawn()
		{
			if (global::AmongUsClient.Instance != null)
			{
				global::AmongUsClient.Instance.Despawn(this);
			}
		}

		public virtual void OnDestroy()
		{
			if (DespawnOnDestroy && global::AmongUsClient.Instance != null)
			{
				global::AmongUsClient.Instance.RemoveNetObject(this);
			}
		}

		public abstract void HandleRpc(byte callId, MessageReader reader);

		public abstract void ClearOrDecrementDirt();

		public abstract bool Serialize(MessageWriter writer, bool initialState);

		public abstract void Deserialize(MessageReader reader, bool initialState);

		public int CompareTo(InnerNetObject other)
		{
			if (other == null)
			{
				return 1;
			}
			return NetId.CompareTo(other.NetId);
		}

		protected bool IsDirtyBitSet(int idx)
		{
			return (DirtyBits & (1u << idx)) != 0;
		}

		protected void ClearDirtyBits()
		{
			DirtyBits = 0u;
		}

		protected void UnsetDirtyBit(uint val)
		{
			DirtyBits &= ~val;
		}

		protected void SetDirtyBit(uint val)
		{
			DirtyBits |= val;
		}
	}
}
