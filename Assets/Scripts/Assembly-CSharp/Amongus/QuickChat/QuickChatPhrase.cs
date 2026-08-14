using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatPhrase
	{
		private QuickChatPhraseType type;

		private bool isInput;

		private bool isNegative;

		private byte playerId;

		private StringNames phraseKey;

		private QuickChatPhraseInput[] phraseInputs;

		public bool IsInput => false;

		public bool IsNegative => false;

		public QuickChatPhraseType Type => default(QuickChatPhraseType);

		public byte PlayerId => 0;

		public StringNames PhraseKey => default(StringNames);

		public QuickChatPhraseInput[] PhraseInputs => null;

		public int ExpectedInputCount => 0;

		public static QuickChatPhrase NewPlayerId(byte playerID)
		{
			return null;
		}

		public static QuickChatPhrase NewSimplePhrase(StringNames localizationKey, bool isInput, bool isNegative)
		{
			return null;
		}

		public static QuickChatPhrase NewComplexPhrase(StringNames localizationKey, QuickChatPhraseInput[] inputs, bool isNegative)
		{
			return null;
		}

		public string ToPreviewText(QuickChatPhrase[] inputs)
		{
			return null;
		}

		public string ToButtonText()
		{
			return null;
		}

		public string ToComplexInputPreviewText()
		{
			return null;
		}

		public string ToLogString()
		{
			return null;
		}

		private string ToPlayerNameText(bool boldPlayerName)
		{
			return null;
		}

		private string ToPlayerColorText()
		{
			return null;
		}

		private string ToPlayerNamePreviewText()
		{
			return null;
		}

		private string ToPlayerNameButtonText()
		{
			return null;
		}

		private string ToPlayerNameInputPreviewText()
		{
			return null;
		}

		public Color ToPlayerColor()
		{
			return default(Color);
		}

		public Color ToPlayerBackgroundColor()
		{
			return default(Color);
		}

		private string ToSimplePhraseText()
		{
			return null;
		}

		private string ToSimplePhrasePreviewText()
		{
			return null;
		}

		private string ToSimplePhraseButtonText()
		{
			return null;
		}

		private string ToSimplePhraseInputPreviewText()
		{
			return null;
		}

		private string ToComplexPreviewText(QuickChatPhrase[] inputs, bool useColor)
		{
			return null;
		}

		private static string GetConditionallyColoredString(string input, bool useColor, Color color)
		{
			return null;
		}

		private static string AddBoldTagsIfSupported(string input)
		{
			return null;
		}
	}
}
