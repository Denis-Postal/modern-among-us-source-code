using UnityEngine;

public class CrystalMinigame : Minigame
{
	public CrystalBehaviour[] CrystalPieces;

	private CrystalBehaviour[] Shuffed;

	public Transform[] CrystalSlots;

	public FloatRange XRange;

	public float TrayY;

	public AudioClip[] PickUpSounds;

	public AudioClip AttachSound;

	private Controller myController;

	private bool prevHadStick;

	private bool prevHadButton;

	private int prevSelectedCrystal;

	private int selectedCrystal;

	public void Start()
	{
	}

	public void Update()
	{
	}

	private void CheckSolution(int startAt)
	{
	}
}
