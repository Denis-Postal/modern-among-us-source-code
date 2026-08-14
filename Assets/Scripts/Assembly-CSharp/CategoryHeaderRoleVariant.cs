using UnityEngine;

public class CategoryHeaderRoleVariant : CategoryHeaderMasked
{
	[SerializeField]
	private SpriteRenderer icon;

	public override void SetHeader(StringNames name, int maskLayer)
	{
	}

	public void SetHeader(StringNames roleName, int maskLayer, bool crewmate, Sprite roleIcon = null)
	{
	}
}
