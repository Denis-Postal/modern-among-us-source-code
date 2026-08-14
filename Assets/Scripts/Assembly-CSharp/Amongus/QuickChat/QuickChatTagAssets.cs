using UnityEngine;

namespace AmongUs.QuickChat
{
	public class QuickChatTagAssets : ScriptableObject
	{
		[Header("Tags")]
		[SerializeField]
		private QuickChatTag accusation;

		[SerializeField]
		private QuickChatTag crew;

		[SerializeField]
		private QuickChatTag deadCrew;

		[SerializeField]
		private QuickChatTag defense;

		[SerializeField]
		private QuickChatTag favorite;

		[SerializeField]
		private QuickChatTag location;

		[SerializeField]
		private QuickChatTag question;

		[SerializeField]
		private QuickChatTag remark;

		[SerializeField]
		private QuickChatTag role;

		[SerializeField]
		private QuickChatTag self;

		[SerializeField]
		private QuickChatTag system;

		[SerializeField]
		private QuickChatTag task;

		[SerializeField]
		[Header("Lobby Tags")]
		private QuickChatTag lobbyImpostor;

		[SerializeField]
		private QuickChatTag lobbyMeeting;

		[SerializeField]
		private QuickChatTag lobbyHiding;

		[SerializeField]
		private QuickChatTag lobbyFlashlight;

		[SerializeField]
		[Header("Collections")]
		private QuickChatTag[] visibleInClassicLobby;

		[SerializeField]
		private QuickChatTag[] visibleInHideAndSeekLobby;

		[SerializeField]
		private QuickChatTag[] visibleInGame;

		[SerializeField]
		private QuickChatTag[] all;

		public QuickChatTag Accusation => null;

		public QuickChatTag Crew => null;

		public QuickChatTag DeadCrew => null;

		public QuickChatTag Defense => null;

		public QuickChatTag Favorite => null;

		public QuickChatTag Location => null;

		public QuickChatTag Question => null;

		public QuickChatTag Remark => null;

		public QuickChatTag Role => null;

		public QuickChatTag Self => null;

		public QuickChatTag System => null;

		public QuickChatTag Task => null;

		public QuickChatTag LobbyImpostor => null;

		public QuickChatTag LobbyMeeting => null;

		public QuickChatTag LobbyHiding => null;

		public QuickChatTag LobbyFlashlight => null;

		public QuickChatTag[] VisibleInClassicLobby => null;

		public QuickChatTag[] VisibleInHideAndSeekLobby => null;

		public QuickChatTag[] VisibleInGame => null;

		public QuickChatTag[] All => null;

		public QuickChatTag GetTagByName(string name)
		{
			return null;
		}

		public QuickChatTag[] GetTagsByParsingKeys(params string[] parsingKeys)
		{
			return null;
		}
	}
}
