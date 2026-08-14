using TMPro;
using UnityEngine;

public class TempMinigame : Minigame
{
	public TextMeshPro LogText;

	public TextMeshPro ReadingText;

	public IntRange LogRange;

	public IntRange ReadingRange;

	private int logValue;

	private int readingValue;

	public AudioClip ButtonSound;

	private float deltaSinceLastChangeNumber;

	public const float CHANGE_NUMBER_UPDATE_THRESHOLD_MIN = 0.05f;

	public override void Begin(PlayerTask task)
	{
	}

	public void ChangeNumber(int dir)
	{
	}

	private void Update()
	{
	}
}
