using System;
using Hazel;
using InnerNet;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class SpawnGameDataMessage : BaseGameDataMessage
	{
		private readonly uint spawnTypeId;

		private readonly int ownerId;

		private readonly SpawnFlags flags;

		private readonly InnerNetObject[] childNetObjects;

		public override GameDataTypes GameDataType { get; }

		public Type NetObjectType { get; private set; }

		public SpawnGameDataMessage(InnerNetObject parentNetObject, int ownerId, SpawnFlags flags, InnerNetObject[] childNetObjects)
		{
		}

		public void ClearOrDecrementChildObjectDirt()
		{
		}

		protected override void SerializeValues(MessageWriter msg)
		{
		}
	}
}
