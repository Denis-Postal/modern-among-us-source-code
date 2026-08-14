using UnityEngine;

namespace AmongUs.QuickChat
{
	public abstract class AbstractQuickChatMenuPage : MonoBehaviour
	{
		private QuickChatMenu menu;

		private float width;

		private float height;

		public QuickChatMenu Menu => null;

		public float Width => 0f;

		public float Height => 0f;

		public virtual PassiveButton DefaultSelection => null;

		public virtual void Initialize(QuickChatMenu menu, float width)
		{
		}

		public virtual void Show(float height)
		{
		}

		public virtual void Hide()
		{
		}
	}
}
