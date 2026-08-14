using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.IntegratedPlatform
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct XSXXBLOptionsInternal : IGettable<XSXXBLOptions>, ISettable<XSXXBLOptions>, IDisposable
	{
		private int m_ApiVersion;

		private IntPtr m_Type;

		private IntegratedPlatformManagementFlags m_Flags;

		private IntPtr m_InitOptions;

		public Utf8String Type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IntegratedPlatformManagementFlags Flags
		{
			get
			{
				return default(IntegratedPlatformManagementFlags);
			}
			set
			{
			}
		}

		public XSXXBLOptionsInitOptions? InitOptions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Set(ref XSXXBLOptions other)
		{
		}

		public void Set(ref XSXXBLOptions? other)
		{
		}

		public void Dispose()
		{
		}

		public void Get(out XSXXBLOptions output)
		{
			output = default(XSXXBLOptions);
		}
	}
}
