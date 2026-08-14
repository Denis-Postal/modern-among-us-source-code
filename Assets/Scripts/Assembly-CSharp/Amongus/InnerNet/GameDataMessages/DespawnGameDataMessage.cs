using Hazel;

namespace AmongUs.InnerNet.GameDataMessages
{
	public class DespawnGameDataMessage : BaseGameDataMessage
	{
		private readonly uint objToDespawnNetId;

		public override GameDataTypes GameDataType { get; }

		public DespawnGameDataMessage(uint objToDespawnNetId)
		{
		}

		protected override void SerializeValues(MessageWriter msg)
		{
		}
	}
}
