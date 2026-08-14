using System.Text;

public class WeatherNodeTask : NormalPlayerTask
{
	public int NodeId;

	public Minigame Stage2Prefab;

	public override bool ValidConsole(Console console)
	{
		return false;
	}

	public override Minigame GetMinigamePrefab()
	{
		return null;
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}
}
