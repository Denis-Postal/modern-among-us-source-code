using TMPro;
using UnityEngine;

public class DetectiveImpostorType : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer impostorSpriteR;

	[SerializeField]
	private TextMeshPro impostorText;

	private RoleBehaviour myRole;

	private DetectiveNotesMinigame miniGame;

	public void Initialize(DetectiveNotesMinigame minigame, RoleBehaviour role)
	{
	}

	public void Click()
	{
	}
}
