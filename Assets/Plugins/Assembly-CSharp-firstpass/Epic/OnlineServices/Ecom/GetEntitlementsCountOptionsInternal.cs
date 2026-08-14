using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
	internal struct GetEntitlementsCountOptionsInternal : ISettable<GetEntitlementsCountOptions>, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_LocalUserId;

		public EpicAccountId LocalUserId
		{
			set
			{
			}
		}

		public void Set(ref GetEntitlementsCountOptions other)
		{
		}

		public void Set(ref GetEntitlementsCountOptions? other)
		{
		}

		public void Dispose()
		{
		}
	}
}
