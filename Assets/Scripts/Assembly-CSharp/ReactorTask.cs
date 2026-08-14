using System.Text;

public class ReactorTask : SabotageTask
{
	private bool isComplete;

	private ICriticalSabotage reactor;

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
