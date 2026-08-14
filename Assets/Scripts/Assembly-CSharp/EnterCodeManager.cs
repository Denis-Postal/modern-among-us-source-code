using InnerNet;
using TMPro;
using UnityEngine;

public class EnterCodeManager : MonoBehaviour, IConnectButton
{
	[SerializeField]
	private TextBoxTMP enterCodeField;

	[SerializeField]
	private GameObject enterCodeCheckmark;

	[SerializeField]
	private TextMeshPro hostText;

	[SerializeField]
	private TextMeshPro capacityText;

	[SerializeField]
	private GameObject crewmateIcon;

	[SerializeField]
	private TextMeshPro serverText;

	[SerializeField]
	private TextMeshPro chatText;

	[SerializeField]
	private PassiveButton joinGamePassiveButton;

	[SerializeField]
	private JoinGameButton joinGameButton;

	[SerializeField]
	private GameObject loadingIcon;

	[SerializeField]
	private Color availableColor;

	[SerializeField]
	private Color fullCapacityColor;

	[SerializeField]
	private AudioClip finishLoadSFX;

	[SerializeField]
	private GameObject fieldsContainer;

	private string matchmakerToken;

	private GameListing gameFound;

	private const float DEFAULT_CONTAINER_Y = 0f;

	private const float PS_CONTAINER_Y = 0.28f;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void LookForGame()
	{
	}

	private void ContinueLookForGame()
	{
	}

	private void CheckPermissions()
	{
	}

	private void NotOnlinePermissions()
	{
	}

	private void FindGameResult(HttpMatchmakerManager.FindGameByCodeResponse response, string mmToken)
	{
	}

	public void ClickJoin()
	{
	}

	public void SetGameFields(bool active)
	{
	}

	public void StartIcon()
	{
	}

	public void StopIcon()
	{
	}
}
