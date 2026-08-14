using TMPro;
using UnityEngine;

public class DetectiveNotesSuspectContainer : MonoBehaviour
{
	[SerializeField]
	private int SuspectIndex;

	[SerializeField]
	private TMP_Text SuspectPlaceholderText;

	[SerializeField]
	private SpriteRenderer BGSprite;

	[SerializeField]
	private GameObject SuspectPrefab;

	[SerializeField]
	private DetectiveNotesSuspectInterface suspectInterface;

	[SerializeField]
	private Sprite activeBGSprite;

	[SerializeField]
	private Sprite inactiveBGSprite;

	private int MaskLayer;

	public void Awake()
	{
	}

	public void SetSuspect(DetectiveSuspect suspectPlayerInfo, NetworkedPlayerInfo victimPlayerInfo, bool wasDead, int index)
	{
	}

	public void ClearSuspect()
	{
	}

	public void Disable()
	{
	}

	public void SetMaskLayer(int layer)
	{
	}
}
