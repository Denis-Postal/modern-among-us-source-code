using System.Text;

public class HudOverrideTask : SabotageTask, IHudOverrideTask
{
	private bool isComplete;

	private HudOverrideSystemType system;

	private bool even;

	public override int TaskStep => 0;

	public override bool IsComplete => false;

	public override void Initialize()
	{
	}

	private void FixedUpdate()
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
