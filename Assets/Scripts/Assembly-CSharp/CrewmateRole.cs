using System.Text;

public class CrewmateRole : RoleBehaviour
{
	public override bool IsDead => false;

	public override bool CanUse(IUsable console)
	{
		return false;
	}

	public override bool DidWin(GameOverReason gameOverReason)
	{
		return false;
	}

	public override void AppendTaskHint(StringBuilder taskStringBuilder)
	{
	}
}
