using System;

namespace Epic.OnlineServices.PlayerDataStorage
{
	public sealed class PlayerDataStorageFileTransferRequest : Handle
	{
		public PlayerDataStorageFileTransferRequest()
		{
		}

		public PlayerDataStorageFileTransferRequest(IntPtr innerHandle)
		{
		}

		public Result CancelRequest()
		{
			return default(Result);
		}

		public Result GetFileRequestState()
		{
			return default(Result);
		}

		public Result GetFilename(out Utf8String outStringBuffer)
		{
			outStringBuffer = null;
			return default(Result);
		}

		public void Release()
		{
		}
	}
}
