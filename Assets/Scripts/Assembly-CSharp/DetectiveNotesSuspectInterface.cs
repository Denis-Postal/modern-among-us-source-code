using TMPro;
using UnityEngine;

public class DetectiveNotesSuspectInterface : MonoBehaviour
{
	[SerializeField]
	private GameObject container;

	[SerializeField]
	private PoolablePlayer player;

	[SerializeField]
	private GameObject deadImage;

	[SerializeField]
	private TMP_Text playerName;

	[SerializeField]
	private TMP_Text playerColor;

	[SerializeField]
	private TMP_Text locationName;

	[SerializeField]
	private TMP_Text numberedText;

	public void SetPlayerInfo(DetectiveSuspect suspectPlayerInfo, NetworkedPlayerInfo victimPlayerInfo, int index, int maskLayer)
	{
	}

	public void DisplayDead()
	{
	}

	public void Clear()
	{
	}
}
