using System;

namespace Epic.OnlineServices.KWS
{
	public sealed class KWSInterface : Handle
	{
		public const int AddnotifypermissionsupdatereceivedApiLatest = 1;

		public const int CopypermissionbyindexApiLatest = 1;

		public const int CreateuserApiLatest = 1;

		public const int GetpermissionbykeyApiLatest = 1;

		public const int GetpermissionscountApiLatest = 1;

		public const int MaxPermissionLength = 32;

		public const int MaxPermissions = 16;

		public const int PermissionstatusApiLatest = 1;

		public const int QueryagegateApiLatest = 1;

		public const int QuerypermissionsApiLatest = 1;

		public const int RequestpermissionsApiLatest = 1;

		public const int UpdateparentemailApiLatest = 1;

		public KWSInterface()
		{
		}

		public KWSInterface(IntPtr innerHandle)
		{
		}

		public ulong AddNotifyPermissionsUpdateReceived(ref AddNotifyPermissionsUpdateReceivedOptions options, object clientData, OnPermissionsUpdateReceivedCallback notificationFn)
		{
			return 0uL;
		}

		public Result CopyPermissionByIndex(ref CopyPermissionByIndexOptions options, out PermissionStatus? outPermission)
		{
			outPermission = null;
			return default(Result);
		}

		public void CreateUser(ref CreateUserOptions options, object clientData, OnCreateUserCallback completionDelegate)
		{
		}

		public Result GetPermissionByKey(ref GetPermissionByKeyOptions options, out KWSPermissionStatus outPermission)
		{
			outPermission = default(KWSPermissionStatus);
			return default(Result);
		}

		public int GetPermissionsCount(ref GetPermissionsCountOptions options)
		{
			return 0;
		}

		public void QueryAgeGate(ref QueryAgeGateOptions options, object clientData, OnQueryAgeGateCallback completionDelegate)
		{
		}

		public void QueryPermissions(ref QueryPermissionsOptions options, object clientData, OnQueryPermissionsCallback completionDelegate)
		{
		}

		public void RemoveNotifyPermissionsUpdateReceived(ulong inId)
		{
		}

		public void RequestPermissions(ref RequestPermissionsOptions options, object clientData, OnRequestPermissionsCallback completionDelegate)
		{
		}

		public void UpdateParentEmail(ref UpdateParentEmailOptions options, object clientData, OnUpdateParentEmailCallback completionDelegate)
		{
		}

		[MonoPInvokeCallback(typeof(OnCreateUserCallbackInternal))]
		internal static void OnCreateUserCallbackInternalImplementation(ref CreateUserCallbackInfoInternal data)
		{
		}

		[MonoPInvokeCallback(typeof(OnPermissionsUpdateReceivedCallbackInternal))]
		internal static void OnPermissionsUpdateReceivedCallbackInternalImplementation(ref PermissionsUpdateReceivedCallbackInfoInternal data)
		{
		}

		[MonoPInvokeCallback(typeof(OnQueryAgeGateCallbackInternal))]
		internal static void OnQueryAgeGateCallbackInternalImplementation(ref QueryAgeGateCallbackInfoInternal data)
		{
		}

		[MonoPInvokeCallback(typeof(OnQueryPermissionsCallbackInternal))]
		internal static void OnQueryPermissionsCallbackInternalImplementation(ref QueryPermissionsCallbackInfoInternal data)
		{
		}

		[MonoPInvokeCallback(typeof(OnRequestPermissionsCallbackInternal))]
		internal static void OnRequestPermissionsCallbackInternalImplementation(ref RequestPermissionsCallbackInfoInternal data)
		{
		}

		[MonoPInvokeCallback(typeof(OnUpdateParentEmailCallbackInternal))]
		internal static void OnUpdateParentEmailCallbackInternalImplementation(ref UpdateParentEmailCallbackInfoInternal data)
		{
		}
	}
}
