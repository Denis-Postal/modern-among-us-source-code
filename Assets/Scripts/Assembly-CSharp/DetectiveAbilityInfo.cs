using TMPro;
using UnityEngine;

public class DetectiveAbilityInfo : MonoBehaviour
{
	[SerializeField]
	private PoolablePlayer PlayerIcon;

	[SerializeField]
	private TextMeshPro ColorBlindName;

	[SerializeField]
	private SpriteRenderer MaskingArea;

	[SerializeField]
	private SpriteRenderer[] checkMarkBoxes;

	[SerializeField]
	private SpriteRenderer[] checkMarks;

	public int SuspectCount;

	private NetworkedPlayerInfo PlayerInfo { get; set; }

	public NetworkedPlayerInfo CurrentPlayerInfo => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetPlayerInfo(NetworkedPlayerInfo playerInfo, int suspectCount, bool isMeeting = false)
	{
	}

	public void DisableCheckmarks()
	{
	}

	public void SetDisabled()
	{
	}

	public void SetEnabled()
	{
	}

	private void SetColorBlindTag()
	{
	}
}
