using PowerTools;
using TMPro;
using UnityEngine;

public class DrillMinigame : Minigame
{
	public SpriteRenderer CaseImage;

	public TextMeshPro statusText;

	public SpriteAnim[] Buttons;

	public AnimationClip BadAnim;

	public AudioClip ButtonSound;

	private int MaxState;

	private int[] states;

	private SpriteAnim prevFixedButton;

	private float changeButtonDelay;

	private int[] drillButtonMaps;

	public void Start()
	{
	}

	public override void Begin(PlayerTask task)
	{
	}

	private void Update()
	{
	}

	public void FixButton(SpriteAnim button)
	{
	}
}
