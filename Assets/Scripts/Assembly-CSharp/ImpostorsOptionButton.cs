using TMPro;
using UnityEngine;

public class ImpostorsOptionButton : MonoBehaviour
{
	public SpriteRenderer SpriteRenderer { get; private set; }

	public TextMeshPro TextMesh { get; private set; }

	public BoxCollider2D BoxCollider { get; private set; }

	public PassiveButton PassiveButton { get; private set; }

	public ButtonRolloverHandler ButtonRollover { get; private set; }

	private void Awake()
	{
	}

	public void SetOptionEnabled(bool b)
	{
	}
}
