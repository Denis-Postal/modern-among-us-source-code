using System;

namespace Epic.OnlineServices
{
	public sealed class EpicAccountId : Handle
	{
		public const int EpicaccountidMaxLength = 32;

		public EpicAccountId()
		{
		}

		public EpicAccountId(IntPtr innerHandle)
		{
		}

		public static EpicAccountId FromString(Utf8String accountIdString)
		{
			return null;
		}

		public static explicit operator EpicAccountId(Utf8String value)
		{
			return null;
		}

		public bool IsValid()
		{
			return false;
		}

		public Result ToString(out Utf8String outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public override string ToString()
		{
			return null;
		}

		public override string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		public static explicit operator Utf8String(EpicAccountId value)
		{
			return null;
		}
	}
}
