using TMPro;
using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatMenuVoteTimer : MonoBehaviour
	{
		private const float HEIGHT = 0.4f;

		[SerializeField]
		private TextMeshPro text;

		[SerializeField]
		private RectTransform textRect;

		[SerializeField]
		private SpriteRenderer[] backgrounds;

		public float Height => 0f;

		public void SetText(StringNames key, int value)
		{
		}

		public void SetWidth(float width)
		{
		}
	}
}
