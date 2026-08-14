using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AmongUsLoadingBar : MonoBehaviour
{
	[SerializeField]
	private Image barFill;

	[SerializeField]
	private TextMeshProUGUI percentText;

	[SerializeField]
	private TextMeshProUGUI loadingText;

	[SerializeField]
	private Transform crewmate;

	private void OnEnable()
	{
	}

	public void SetLoadingPercent(float percent, StringNames loadText = StringNames.None)
	{
	}
}
