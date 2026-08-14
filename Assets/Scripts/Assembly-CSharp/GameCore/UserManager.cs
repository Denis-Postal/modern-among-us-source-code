using System.Collections.Generic;

namespace GameCore
{
	public class UserManager
	{
		public enum UserOpResult
		{
			Success = 0,
			NoDefaultUser = 1,
			ResolveUserIssueRequired = 2,
			UnclearedVetoes = 3,
			UnknownError = 4
		}

		private enum State
		{
			Initializing = 0,
			GetContext = 1,
			WaitForAddingUser = 2,
			GetBasicInfo = 3,
			InitializeNetwork = 4,
			GrabAchievements = 5,
			UserDisplayImage = 6,
			ReturnMuteList = 7,
			ReturnAvoidList = 8,
			UserPermissionsCheck = 9,
			WaitForNextTask = 10,
			Error = 11,
			Idle = 12,
			End = 13
		}

		public class UserData
		{
		}

		public delegate void AddUserCompletedDelegate(UserOpResult result);

		private const int E_GAMEUSER_NO_DEFAULT_USER = -1994108666;

		public const bool isSingleUserGame = true;

		public List<UserData> UserDataList;

		private UserData primaryUser;

		public UserData PrimaryUser
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}
	}
}
