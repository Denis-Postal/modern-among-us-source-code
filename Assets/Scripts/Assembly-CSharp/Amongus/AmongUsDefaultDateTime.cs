using System;

namespace AmongUs
{
	public class AmongUsDefaultDateTime : IAmongUsDateTimeRetriever
	{
		public DateTime Now()
		{
			return default(DateTime);
		}

		public DateTime UtcNow()
		{
			return default(DateTime);
		}
	}
}
