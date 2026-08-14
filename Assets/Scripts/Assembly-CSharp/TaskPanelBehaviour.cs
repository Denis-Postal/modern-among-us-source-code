using TMPro;
using UnityEngine;

public class TaskPanelBehaviour : MonoBehaviour
{
	[SerializeField]
	private Vector3 openPosition;

	[SerializeField]
	private Vector3 closedPosition;

	[SerializeField]
	private SpriteRenderer background;

	[SerializeField]
	private SpriteRenderer tab;

	[SerializeField]
	private TextMeshPro taskText;

	[SerializeField]
	private float animationTimeSeconds;

	private bool open;

	private float timer;

	public void ToggleOpen()
	{
	}

	private void Update()
	{
	}

	public void SetTaskText(string str)
	{
	}
}
