using Hazel;

namespace AmongUs.QuickChat
{
	public static class QuickChatNetData
	{
		public static void Serialize(QuickChatPhraseBuilderResult data, MessageWriter writer)
		{
		}

		public static QuickChatPhraseBuilderResult Deserialize(MessageReader reader)
		{
			return null;
		}

		private static void SerializePlayerID(byte playerID, MessageWriter writer)
		{
		}

		private static byte DeserializePlayerID(MessageReader reader)
		{
			return 0;
		}

		private static void SerializeSimplePhrase(StringNames phraseKey, MessageWriter writer)
		{
		}

		private static StringNames DeserializeSimplePhrase(MessageReader reader)
		{
			return default(StringNames);
		}

		private static void SerializeComplexPhrase(QuickChatPhraseBuilderResult data, MessageWriter writer)
		{
		}

		private static QuickChatPhraseBuilderResult DeserializeComplexPhrase(MessageReader reader)
		{
			return null;
		}
	}
}
