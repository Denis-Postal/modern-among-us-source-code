using TMPro;
using UnityEngine;

public class ServerListButton : PoolableBehavior
{
	public TextMeshPro Text;

	public PassiveButton Button;

	public SpriteRenderer Background;

	public TextTranslatorTMP textTranslator;

	public void SetSelected(bool selected)
	{
	}

	public void SetTextTranslationId(StringNames id, string defaultStr)
	{
	}
}
