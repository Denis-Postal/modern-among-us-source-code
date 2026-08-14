using UnityEngine;

namespace AmongUs.QuickChat
{
	[CreateAssetMenu]
	public class QuickChatPhraseAsset : ScriptableObject
	{
		[Header("Phrase Properties")]
		[SerializeField]
		private string text;

		[SerializeField]
		private StringNames key;

		[SerializeField]
		private Sprite icon;

		[SerializeField]
		private int order;

		[Header("Usage")]
		[SerializeField]
		private bool isInput;

		[SerializeField]
		private bool isNegative;

		[SerializeField]
		[Space(10f)]
		private QuickChatTag[] tags;

		[SerializeField]
		private QuickChatPhraseInput[] inputs;

		[SerializeField]
		[Header("Inclusion Rules")]
		private QuickChatClassicPhraseRules classicRules;

		[SerializeField]
		private QuickChatHideAndSeekPhraseRules hideAndSeekRules;

		private QuickChatPhrase cachedPhrase;

		public string Text => null;

		public StringNames Key => default(StringNames);

		public Sprite Icon => null;

		public int Order => 0;

		public bool IsInput => false;

		public bool IsNegative => false;

		public QuickChatTag[] Tags => null;

		public QuickChatPhraseInput[] Inputs => null;

		public bool EvaluateContext(QuickChatContext context)
		{
			return false;
		}

		public QuickChatPhrase ToPhrase()
		{
			return null;
		}
	}
}
