using UnityEngine;

public class StoreArmsTaskConsole : Console
{
	public AudioClip useSound;

	public Sprite[] Images;

	public int usesPerStep;

	private int timesUsed;

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
