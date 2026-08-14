using System;
using TMPro;
using UnityEngine;

public class HowToPlayRoleButton : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer background;

	[SerializeField]
	private SpriteRenderer border;

	[SerializeField]
	private SpriteRenderer roleIcon;

	[SerializeField]
	private TextMeshPro roleName;

	[SerializeField]
	private PassiveButton passiveButton;

	[SerializeField]
	private GameObject newRoleAlert;

	[SerializeField]
	private int MaskLayer;

	[SerializeField]
	private Collider2D collider;

	private RoleBehaviour role;

	private readonly float offscreenYPos;

	private void OnEnable()
	{
	}

	public void SetRoleInfo(RoleBehaviour _role, Sprite roleIcon)
	{
	}

	public RoleBehaviour GetRole()
	{
		return null;
	}

	public void SetButtonAction(Action action)
	{
	}

	private void Update()
	{
	}
}
