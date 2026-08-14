using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatTag : ScriptableObject
	{
		[SerializeField]
		private StringNames tagKey;

		[SerializeField]
		private StringNames inputKey;

		[ColorUsage(false)]
		[SerializeField]
		private Color color;

		[SerializeField]
		private string[] parsingKeys;

		public StringNames TagNameKey => default(StringNames);

		public StringNames InputNameKey => default(StringNames);

		public string LocalizedTagName => null;

		public string LocalizedInputName => null;

		public Color Color => default(Color);

		public bool ContainsParsingKey(string key)
		{
			return false;
		}
	}
}
