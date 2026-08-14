using TMPro;
using UnityEngine;

public class RewindTapeMinigame : Minigame
{
	private const float MaxTime = 83544f;

	private float targetTime;

	private float currentTime;

	public SpriteRenderer LeftWheel;

	public SpriteRenderer LeftTape;

	public SpriteRenderer RightWheel;

	public SpriteRenderer RightTape;

	public TextMeshPro TargetText;

	public TextMeshPro CurrentText;

	public SpriteRenderer RewindButton;

	public Sprite RewindNormal;

	public Sprite RewindDown;

	public SpriteRenderer FastFwdButton;

	public Sprite FastFwdNormal;

	public Sprite FastFwdDown;

	public SpriteRenderer PlayButton;

	public Sprite PlayNormal;

	public Sprite PlayDown;

	public SpriteRenderer PauseButton;

	public Sprite PauseNormal;

	public Sprite PauseDown;

	public SpriteRenderer RewindGlyph;

	public SpriteRenderer FastFwdGlyph;

	public SpriteRenderer PlayGlyph;

	public SpriteRenderer PauseGlyph;

	public float upGlyphYPos;

	public float pressedGlyphYPos;

	public Color upGlyphColor;

	public Color pressedGlyphColor;

	private float direction;

	public AudioClip buttonSound;

	public AudioClip playStartSound;

	public AudioClip playLoopSound;

	public AudioClip playStopSound;

	private AudioSource loopSound;

	public override void Begin(PlayerTask task)
	{
	}

	private void UpdateText(TextMeshPro targetText, float targetTime)
	{
	}

	public void Update()
	{
	}

	private void SetYPos(Transform t, float newYPos)
	{
	}

	public void Rewind()
	{
	}

	public void FastForward()
	{
	}

	public void Pause()
	{
	}

	public void Play()
	{
	}

	public override void Close()
	{
	}
}
