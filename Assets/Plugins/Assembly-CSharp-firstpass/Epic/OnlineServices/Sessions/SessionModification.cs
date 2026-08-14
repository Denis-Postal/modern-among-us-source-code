using System;

namespace Epic.OnlineServices.Sessions
{
	public sealed class SessionModification : Handle
	{
		public const int SessionmodificationAddattributeApiLatest = 2;

		public const int SessionmodificationMaxSessionAttributeLength = 64;

		public const int SessionmodificationMaxSessionAttributes = 64;

		public const int SessionmodificationMaxSessionidoverrideLength = 64;

		public const int SessionmodificationMinSessionidoverrideLength = 16;

		public const int SessionmodificationRemoveattributeApiLatest = 1;

		public const int SessionmodificationSetallowedplatformidsApiLatest = 1;

		public const int SessionmodificationSetbucketidApiLatest = 1;

		public const int SessionmodificationSethostaddressApiLatest = 1;

		public const int SessionmodificationSetinvitesallowedApiLatest = 1;

		public const int SessionmodificationSetjoininprogressallowedApiLatest = 1;

		public const int SessionmodificationSetmaxplayersApiLatest = 1;

		public const int SessionmodificationSetpermissionlevelApiLatest = 1;

		public SessionModification()
		{
		}

		public SessionModification(IntPtr innerHandle)
		{
		}

		public Result AddAttribute(ref SessionModificationAddAttributeOptions options)
		{
			return default(Result);
		}

		public void Release()
		{
		}

		public Result RemoveAttribute(ref SessionModificationRemoveAttributeOptions options)
		{
			return default(Result);
		}

		public Result SetAllowedPlatformIds(ref SessionModificationSetAllowedPlatformIdsOptions options)
		{
			return default(Result);
		}

		public Result SetBucketId(ref SessionModificationSetBucketIdOptions options)
		{
			return default(Result);
		}

		public Result SetHostAddress(ref SessionModificationSetHostAddressOptions options)
		{
			return default(Result);
		}

		public Result SetInvitesAllowed(ref SessionModificationSetInvitesAllowedOptions options)
		{
			return default(Result);
		}

		public Result SetJoinInProgressAllowed(ref SessionModificationSetJoinInProgressAllowedOptions options)
		{
			return default(Result);
		}

		public Result SetMaxPlayers(ref SessionModificationSetMaxPlayersOptions options)
		{
			return default(Result);
		}

		public Result SetPermissionLevel(ref SessionModificationSetPermissionLevelOptions options)
		{
			return default(Result);
		}
	}
}
