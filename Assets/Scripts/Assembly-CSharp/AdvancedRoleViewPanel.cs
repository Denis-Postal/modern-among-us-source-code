using UnityEngine;

public class AdvancedRoleViewPanel : MonoBehaviour
{
	[SerializeField]
	private CategoryHeaderRoleVariant header;

	[SerializeField]
	private SpriteRenderer divider;

	[SerializeField]
	private ViewSettingsInfoPanel infoPanelOrigin;

	[SerializeField]
	private float xPosStart;

	[SerializeField]
	private float yPosStart;

	private const float START_BODY_HEIGHT = 1.08f;

	private const float BODY_SPACING = 0.8f;

	public float SetUp(RoleBehaviour role, float spacingY, int maskLayer)
	{
		return 0f;
	}
}
