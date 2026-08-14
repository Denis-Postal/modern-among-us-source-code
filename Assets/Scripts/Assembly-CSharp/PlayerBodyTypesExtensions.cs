using System.Collections.Generic;

public static class PlayerBodyTypesExtensions
{
	private static readonly Dictionary<PlayerBodyTypes, HatOptions> CustomHatOptions;

	private static readonly Dictionary<PlayerBodyTypes, SkinOptions> CustomSkinOptions;

	private static readonly Dictionary<PlayerBodyTypes, VisorOptions> CustomVisorOptions;

	public static HatOptions GetHatOptions(this PlayerBodyTypes bodyTypes)
	{
		return default(HatOptions);
	}

	public static SkinOptions GetSkinOptions(this PlayerBodyTypes bodyTypes)
	{
		return default(SkinOptions);
	}

	public static VisorOptions GetVisorOptions(this PlayerBodyTypes bodyTypes)
	{
		return default(VisorOptions);
	}
}
