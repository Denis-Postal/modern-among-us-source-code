using System.Text;

public class MushroomMixupSabotageTask : PlayerTask
{
	private bool isComplete;

	private MushroomMixupSabotageSystem sabotage;

	public override int TaskStep => 0;

	public override bool IsComplete => false;

	public override void Initialize()
	{
	}

	public override bool ValidConsole(Console console)
	{
		return false;
	}

	public override void Complete()
	{
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}
}
