using System;

namespace Epic.OnlineServices.Lobby
{
	public sealed class LobbyModification : Handle
	{
		public const int LobbymodificationAddattributeApiLatest = 2;

		public const int LobbymodificationAddmemberattributeApiLatest = 2;

		public const int LobbymodificationMaxAttributeLength = 64;

		public const int LobbymodificationMaxAttributes = 64;

		public const int LobbymodificationRemoveattributeApiLatest = 1;

		public const int LobbymodificationRemovememberattributeApiLatest = 1;

		public const int LobbymodificationSetallowedplatformidsApiLatest = 1;

		public const int LobbymodificationSetbucketidApiLatest = 1;

		public const int LobbymodificationSetinvitesallowedApiLatest = 1;

		public const int LobbymodificationSetmaxmembersApiLatest = 1;

		public const int LobbymodificationSetpermissionlevelApiLatest = 1;

		public LobbyModification()
		{
		}

		public LobbyModification(IntPtr innerHandle)
		{
		}

		public Result AddAttribute(ref LobbyModificationAddAttributeOptions options)
		{
			return default(Result);
		}

		public Result AddMemberAttribute(ref LobbyModificationAddMemberAttributeOptions options)
		{
			return default(Result);
		}

		public void Release()
		{
		}

		public Result RemoveAttribute(ref LobbyModificationRemoveAttributeOptions options)
		{
			return default(Result);
		}

		public Result RemoveMemberAttribute(ref LobbyModificationRemoveMemberAttributeOptions options)
		{
			return default(Result);
		}

		public Result SetAllowedPlatformIds(ref LobbyModificationSetAllowedPlatformIdsOptions options)
		{
			return default(Result);
		}

		public Result SetBucketId(ref LobbyModificationSetBucketIdOptions options)
		{
			return default(Result);
		}

		public Result SetInvitesAllowed(ref LobbyModificationSetInvitesAllowedOptions options)
		{
			return default(Result);
		}

		public Result SetMaxMembers(ref LobbyModificationSetMaxMembersOptions options)
		{
			return default(Result);
		}

		public Result SetPermissionLevel(ref LobbyModificationSetPermissionLevelOptions options)
		{
			return default(Result);
		}
	}
}
