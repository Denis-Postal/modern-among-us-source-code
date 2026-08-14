using System.Text;

public class HeliCharlesTask : SabotageTask
{
	private bool isComplete;

	private ICriticalSabotage sabotage;

	private bool even;

	public override int TaskStep => 0;

	public override bool IsComplete => false;

	public override void Initialize()
	{
	}

	public void Awake()
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
