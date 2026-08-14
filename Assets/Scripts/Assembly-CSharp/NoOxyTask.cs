using System.Text;

public class NoOxyTask : SabotageTask
{
	private bool isComplete;

	private LifeSuppSystemType reactor;

	private bool even;

	public int targetNumber;

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

	public override void OnRemove()
	{
	}

	public override void Complete()
	{
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}
}
