using System.Text;

public class DivertPowerTask : NormalPlayerTask
{
	public SystemTypes TargetSystem;

	public override bool ValidConsole(Console console)
	{
		return false;
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}
}
