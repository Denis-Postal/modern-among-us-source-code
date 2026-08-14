namespace AmongUs.QuickChat
{
	public class QuickChatPhraseBuilderResult
	{
		public class Phrase
		{
			public readonly QuickChatPhraseType Type;

			public readonly StringNames PhraseKey;

			public readonly byte PlayerID;

			public Phrase(QuickChatPhrase phrase)
			{
			}

			public Phrase(QuickChatPhraseType type, StringNames key, byte playerID)
			{
			}
		}

		public readonly Phrase RootPhrase;

		public readonly Phrase[] SubPhrases;

		public QuickChatPhraseBuilderResult(QuickChatPhraseType type, StringNames rootPhrase, byte playerID, QuickChatPhrase[] subPhrases)
		{
		}

		public QuickChatPhraseBuilderResult(QuickChatPhrase rootPhrase, QuickChatPhrase[] subPhrases)
		{
		}

		public bool IsValid()
		{
			return false;
		}

		public string ToChatText()
		{
			return null;
		}

		private static string ToPlayerNameChatText(byte playerID)
		{
			return null;
		}

		private static string ToSimpleChatText(StringNames key)
		{
			return null;
		}

		private string ToComplexChatText()
		{
			return null;
		}

		private static Phrase[] ConvertSubPhrases(QuickChatPhrase[] input)
		{
			return null;
		}
	}
}
