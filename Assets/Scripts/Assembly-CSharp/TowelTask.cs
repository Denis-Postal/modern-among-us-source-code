using System.Text;

public class TowelTask : NormalPlayerTask
{
	public override bool ValidConsole(Console console)
	{
		return false;
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}
}
