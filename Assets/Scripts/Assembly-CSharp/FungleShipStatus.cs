using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class FungleShipStatus : ShipStatus
{
	private readonly Dictionary<int, Mushroom> sporeMushrooms;

	[SerializeField]
	private MushroomMixupSabotageSystem specialSabotage;

	[SerializeField]
	private GameObject[] startAMBSounds;

	[SerializeField]
	private AssetReference staticWavesAsset;

	[SerializeField]
	private AssetReference animatedWavesAsset;

	public ZiplineBehaviour Zipline { get; private set; }

	public Vector2 LastBinocularPos { get; set; }

	protected override void OnEnable()
	{
	}

	private void LoadWavesAsync(AssetReference waveAsset)
	{
	}

	public override void StartSFX()
	{
	}

	public override void OnMeetingCalled()
	{
	}

	public void TriggerSporesFromMushroom(int mushroomId)
	{
	}

	public Mushroom GetMushroomFromId(int mushroomId)
	{
		return null;
	}

	public bool IsMushroomMixupActive()
	{
		return false;
	}
}
