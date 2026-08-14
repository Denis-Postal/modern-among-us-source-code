using TMPro;
using UnityEngine;

public class ConfirmCreatePopUp : MonoBehaviour
{
	[SerializeField]
	private CreateGameOptions createGameOptions;

	[SerializeField]
	private TextMeshPro modeText;

	[SerializeField]
	private TextMeshPro serverText;

	[SerializeField]
	private TextMeshPro capacityText;

	[SerializeField]
	private TextMeshPro chatText;

	[SerializeField]
	private TextMeshPro tagText;

	[SerializeField]
	private TextMeshPro langText;

	[SerializeField]
	private Sprite[] mapBanners;

	[SerializeField]
	private Sprite[] mapLogos;

	[SerializeField]
	private SpriteRenderer mapBanner;

	[SerializeField]
	private SpriteRenderer mapLogo;

	private void OnEnable()
	{
	}

	private void SetupInfo()
	{
	}
}
