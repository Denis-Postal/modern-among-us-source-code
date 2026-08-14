using UnityEngine;

public class CategoryHeaderEditRole : CategoryHeaderMasked
{
	[SerializeField]
	private SpriteRenderer blankLabel;

	[SerializeField]
	private SpriteRenderer chanceLabel;

	[SerializeField]
	private SpriteRenderer countLabel;

	public override void SetHeader(StringNames name, int maskLayer)
	{
	}
}
