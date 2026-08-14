using TMPro;
using UnityEngine;

public class ChatLanguageButton : PoolableBehavior
{
	public TextMeshPro Text;

	public PassiveButton Button;

	[SerializeField]
	private SpriteRenderer Background;

	[SerializeField]
	private SpriteRenderer Check;

	public void SetSelected(bool selected)
	{
	}

	public override void Reset()
	{
	}
}
