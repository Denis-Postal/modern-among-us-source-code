using System;
using TMPro;
using UnityEngine;

public class ShapeshifterPanel : MonoBehaviour
{
	public PoolablePlayer PlayerIcon;

	public SpriteRenderer Background;

	public TextMeshPro NameText;

	public TextMeshPro LevelNumberText;

	public PassiveButton Button;

	private Action shapeshift;

	public TextMeshPro ColorBlindName;

	public void SetPlayer(int index, NetworkedPlayerInfo playerInfo, Action onShift)
	{
	}

	public void ShapeShift()
	{
	}

	private void OnDisable()
	{
	}

	private void SetColorblindText()
	{
	}
}
