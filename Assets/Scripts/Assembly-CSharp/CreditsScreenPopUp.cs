using UnityEngine;

public class CreditsScreenPopUp : MonoBehaviour
{
	[SerializeField]
	private TransitionOpen TransitionOpen;

	[SerializeField]
	private CreditsController CreditsController;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
