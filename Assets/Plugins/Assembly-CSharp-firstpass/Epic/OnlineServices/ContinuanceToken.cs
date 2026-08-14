using System;

namespace Epic.OnlineServices
{
	public sealed class ContinuanceToken : Handle
	{
		public ContinuanceToken()
		{
		}

		public ContinuanceToken(IntPtr innerHandle)
		{
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

		public static explicit operator Utf8String(ContinuanceToken value)
		{
			return null;
		}
	}
}
