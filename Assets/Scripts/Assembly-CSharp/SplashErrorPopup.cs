using TMPro;
using UnityEngine;

public class SplashErrorPopup : MonoBehaviour
{
	[SerializeField]
	private TextMeshPro TitleText;

	[SerializeField]
	private TextMeshPro InfoText;

	[SerializeField]
	private AudioSource ShowSFX;

	public bool IsShowing => false;

	public void Show(string titleText, string infoText)
	{
	}

	public void OnButtonPressed()
	{
	}
}
