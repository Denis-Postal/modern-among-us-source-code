using System.Runtime.CompilerServices;

public static class ResolutionManager
{
	public delegate void ResolutionChangedHandler(float aspectRatio, int width, int height, bool fullscreen);

	public static event ResolutionChangedHandler ResolutionChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static void SetResolution(int width, int height, bool fullscreen)
	{
	}

	public static void ToggleFullscreen()
	{
	}
}
