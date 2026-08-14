using UnityEngine;

public class AutoTaskConsole : Console
{
	public AudioClip useSound;

	private PlayerTask FindTask(PlayerControl pc)
	{
		return null;
	}

	public override void Use()
	{
	}

	protected virtual void AfterUse(NormalPlayerTask task)
	{
	}
}
