using System;

namespace Epic.OnlineServices.TitleStorage
{
	public sealed class TitleStorageFileTransferRequest : Handle
	{
		public TitleStorageFileTransferRequest()
		{
		}

		public TitleStorageFileTransferRequest(IntPtr innerHandle)
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
