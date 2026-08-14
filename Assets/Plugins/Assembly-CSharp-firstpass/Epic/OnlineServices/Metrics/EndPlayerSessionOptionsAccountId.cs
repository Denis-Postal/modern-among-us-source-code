namespace Epic.OnlineServices.Metrics
{
	public struct EndPlayerSessionOptionsAccountId
	{
		private MetricsAccountIdType m_AccountIdType;

		private EpicAccountId m_Epic;

		private Utf8String m_External;

		public MetricsAccountIdType AccountIdType
		{
			get
			{
				return default(MetricsAccountIdType);
			}
			private set
			{
			}
		}

		public EpicAccountId Epic
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Utf8String External
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static implicit operator EndPlayerSessionOptionsAccountId(EpicAccountId value)
		{
			return default(EndPlayerSessionOptionsAccountId);
		}

		public static implicit operator EndPlayerSessionOptionsAccountId(Utf8String value)
		{
			return default(EndPlayerSessionOptionsAccountId);
		}

		public static implicit operator EndPlayerSessionOptionsAccountId(string value)
		{
			return default(EndPlayerSessionOptionsAccountId);
		}

		internal void Set(ref EndPlayerSessionOptionsAccountIdInternal other)
		{
		}
	}
}
