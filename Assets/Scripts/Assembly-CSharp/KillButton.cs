using UnityEngine;

public class KillButton : ActionButton
{
	private PlayerControl currentTarget;

	[SerializeField]
	private TextTranslatorTMP textTranslator;

	[SerializeField]
	private Sprite defaultKillSprite;

	public PlayerControl Target => null;

	public override void DoClick()
	{
	}

	public void CheckClick(PlayerControl target)
	{
	}

	public void SetTarget(PlayerControl target)
	{
	}

	private void Start()
	{
	}

	public void ChangeButtonText(StringNames stringName)
	{
	}

	public void ChangeGraphic(Sprite newSprite)
	{
	}

	public void ResetKillButton()
	{
	}
}
