using UnityEngine;

public class IncubateEggMinigameEmote : MonoBehaviour
{
	private const string IS_VISIBLE_BOOL = "IsVisible";

	[SerializeField]
	private Animator animator;

	public bool IsVisible => false;

	public void SetVisible(bool visible)
	{
	}
}
