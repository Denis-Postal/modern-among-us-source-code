using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetectiveNotesTab : MonoBehaviour
{
	private int tabIndex;

	[SerializeField]
	private BoxCollider2D collider;

	[SerializeField]
	private PoolablePlayer playerIcon;

	[SerializeField]
	private List<SpriteRenderer> backgrounds;

	[SerializeField]
	private SpriteRenderer playerColorBackground;

	[SerializeField]
	private PassiveButton passiveButton;

	[SerializeField]
	private SpriteRenderer tabBG;

	[SerializeField]
	private SpriteRenderer dimBG;

	[SerializeField]
	private Sprite largeBG;

	[SerializeField]
	private Sprite smallBG;

	[SerializeField]
	private TMP_Text colorblindText;

	private float tabSpacing;

	private float smallColliderSizeX;

	private float smallPlayerPosX;

	private float smallPlayerScale;

	private Vector2 smallBackgroundSize;

	private Vector2 smallColorSize;

	private int maskLayer;

	public void Setup(DetectiveNotesMinigame notesMinigame, int _tabIndex, NetworkedPlayerInfo player, int amountOfTabs)
	{
	}

	public void SetHighlighted(DetectiveNotesMinigame minigame, bool highlighted)
	{
	}
}
