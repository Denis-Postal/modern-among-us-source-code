public class NormalGameManager : GameManager
{
	public override void InitComponents()
	{
	}

	public override MapOptions GetMapOptions()
	{
		return null;
	}

	public override bool IsNormal()
	{
		return false;
	}

	public override PlayerBodyTypes GetBodyType(PlayerControl player)
	{
		return default(PlayerBodyTypes);
	}

	public override DeadBody GetDeadBody(RoleBehaviour impostorRole)
	{
		return null;
	}
}
