using TMPro;
using UnityEngine;

public class TimerTextTMP : MonoBehaviour
{
	[SerializeField]
	private TextMeshPro text;

	private string format;

	private float duration;

	private float startTime;

	private int seconds;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void SetTimer(float duration, string format)
	{
	}

	private int GetSecondsRemaining()
	{
		return 0;
	}

	private string GetTextString()
	{
		return null;
	}

	private void Tick()
	{
	}

	private void UpdateText()
	{
	}
}
