using UnityEngine;

public class AirshipUploadGame : Minigame
{
	public SpriteRenderer Phone;

	public Collider2D Hotspot;

	public Collider2D Perfect;

	public Collider2D Good;

	public Collider2D Poor;

	public GameObject PerfectIcon;

	public GameObject GoodIcon;

	public GameObject PoorIcon;

	public GameObject NoneIcon;

	public HorizontalGauge gauge;

	public float moveSpeed;

	private const float MaxTimer = 20f;

	private float timer;

	public AudioClip nearSound;

	public float BeepPeriod;

	private float beepTimer;

	public Controller cont;

	public SpriteRenderer promptGlyph;

	private Color glyphColor;

	private float glyphDisappearDelay;

	private bool phoneGrabbed;

	public void Start()
	{
	}

	public void Update()
	{
	}

	public void ToggleGrab()
	{
	}

	private void DeactivateIcons()
	{
	}
}
