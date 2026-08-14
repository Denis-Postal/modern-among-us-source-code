using System;

namespace Epic.OnlineServices
{
	public sealed class ProductUserId : Handle
	{
		public const int ProductuseridMaxLength = 32;

		public ProductUserId()
		{
		}

		public ProductUserId(IntPtr innerHandle)
		{
		}

		public static ProductUserId FromString(Utf8String productUserIdString)
		{
			return null;
		}

		public static explicit operator ProductUserId(Utf8String value)
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

		public static explicit operator Utf8String(ProductUserId value)
		{
			return null;
		}
	}
}
