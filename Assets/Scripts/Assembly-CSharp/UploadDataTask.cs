using System.Text;

public class UploadDataTask : NormalPlayerTask
{
	public SystemTypes EndAt;

	public override bool ValidConsole(Console console)
	{
		return false;
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}
}
