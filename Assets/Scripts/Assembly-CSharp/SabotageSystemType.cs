using System.Collections.Generic;
using Hazel;

public class SabotageSystemType : ISystemType
{
	public const float SpecialSabDelay = 30f;

	private List<IActivatable> specials;

	private bool initialCooldown;

	public float Timer { get; private set; }

	public float PercentCool => 0f;

	public bool AnyActive => false;

	public bool IsDirty { get; private set; }

	public SabotageSystemType(IActivatable[] specials)
	{
	}

	public void Deteriorate(float deltaTime)
	{
	}

	public void SetInitialSabotageCooldown()
	{
	}

	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	public void MarkClean()
	{
	}

	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	public void Deserialize(MessageReader reader, bool initialState)
	{
	}
}
