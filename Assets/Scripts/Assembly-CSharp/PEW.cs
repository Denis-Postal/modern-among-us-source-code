using System;
using System.Runtime.CompilerServices;

public static class PEW
{
	public static class Hardware
	{
		public enum HardwareType
		{
			PC = 0,
			Switch = 1,
			XboxOne = 2,
			XboxScarlett = 3,
			PS4 = 4,
			PS5 = 5,
			Stadia = 6,
			Unknown = 7
		}

		private static HardwareType type;

		private static int tier;

		public static HardwareType hardwareType
		{
			get
			{
				return default(HardwareType);
			}
			private set
			{
			}
		}

		public static int hardwareTier
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		private static HardwareType GetHardwareType()
		{
			return default(HardwareType);
		}

		private static int GetHardwareTier()
		{
			return 0;
		}
	}

	[Obsolete("\nDon't reference this class directly, create a class that derives from it! Unity won't properly serialize classes with generics.\n\npublic class ConditionalWhatever : ConditionalValue<Whatever> { }; \n\n(Ignore if you're already doing that)")]
	public class ConditionalValue<T>
	{
		public T PC;

		public T Switch;

		public T XboxOne;

		public T XboxOneX;

		public T PS4;

		public T PS4Pro;

		public T PS5;

		public T Stadia;

		public T Misc;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Select()
		{
			return default(T);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator T(ConditionalValue<T> input)
		{
			return default(T);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator ConditionalValue<T>(T input)
		{
			return null;
		}
	}
}
