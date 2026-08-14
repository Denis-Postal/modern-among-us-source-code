using UnityEngine;

public class SkeldShipRoom : PlainShipRoom, IStepWatcher
{
	public AudioClip AmbientSound;

	public float AmbientVolume;

	public float AmbientMaxDist;

	public Vector2 AmbientOffset;

	public SoundGroup FootStepSounds;

	private RaycastHit2D[] volumeBuffer;

	public int Priority { get; }

	public void Start()
	{
	}

	public SoundGroup MakeFootstep(PlayerControl player)
	{
		return null;
	}

	private void GetAmbientSoundVolume(AudioSource player, float dt)
	{
	}
}
