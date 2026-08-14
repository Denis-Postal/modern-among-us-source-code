using System.Text;
using UnityEngine;

public class ViperRole : ImpostorRole
{
	[SerializeField]
	private Sprite killSprite;

	private float dissolveMaxTime => 0f;

	public override void Initialize(PlayerControl player)
	{
	}

	public override void KillAnimSpecialSetup(DeadBody deadBody, PlayerControl killer, PlayerControl victim)
	{
	}

	public override void AppendTaskHint(StringBuilder taskStringBuilder)
	{
	}
}
