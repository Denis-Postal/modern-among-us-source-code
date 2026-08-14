public class MapOptions
{
	public enum Modes
	{
		None = 0,
		Normal = 1,
		CountOverlay = 2,
		Sabotage = 3,
		Detective = 4
	}

	public Modes Mode;

	public bool AllowMovementWhileMapOpen;

	public bool ShowLivePlayerPosition;

	public bool IncludeDeadBodies;
}
