using System.Text;

public class AirshipUploadTask : NormalPlayerTask
{
	public ArrowBehaviour[] Arrows;

	public override bool ValidConsole(Console console)
	{
		return false;
	}

	protected override void FixedUpdate()
	{
	}

	public override void UpdateArrowAndLocation()
	{
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}
}
