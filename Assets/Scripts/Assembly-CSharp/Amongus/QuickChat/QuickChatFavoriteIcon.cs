using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatFavoriteIcon : MonoBehaviour
	{
		private const string STATE_ACTIVE_IDLE = "ActiveIdle";

		private const string STATE_INACTIVE_IDLE = "InactiveIdle";

		[SerializeField]
		private Animator animator;

		[SerializeField]
		private BoxCollider2D collider;

		[SerializeField]
		private PassiveButton button;

		public Vector2 Size => default(Vector2);

		public event Action OnPressEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		public void Setup(bool active)
		{
		}

		public void SetFavorite(bool isFavorite)
		{
		}

		public void SetHeight(float height)
		{
		}

		private void OnButtonPressed()
		{
		}
	}
}
