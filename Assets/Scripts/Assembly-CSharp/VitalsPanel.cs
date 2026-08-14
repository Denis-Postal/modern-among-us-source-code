using TMPro;
using UnityEngine;

public class VitalsPanel : MonoBehaviour
{
	public PoolablePlayer PlayerIcon;

	public SpriteRenderer MaskingArea;

	public SpriteRenderer Background;

	public VertLineBehaviour Cardio;

	public Sprite VitalBgDead;

	public Sprite VitalBgDiscon;

	public IntRange BeatRange;

	public bool IsDead;

	public bool IsDiscon;

	public TextMeshPro ColorBlindName;

	public NetworkedPlayerInfo PlayerInfo { get; set; }

	public void SetPlayer(int index, NetworkedPlayerInfo playerInfo)
	{
	}

	public void SetDisconnected()
	{
	}

	public void SetDead()
	{
	}

	public void SetAlive()
	{
	}
}
