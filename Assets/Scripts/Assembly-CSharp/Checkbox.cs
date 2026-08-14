using UnityEngine;

public class Checkbox : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer checkmark;

	[SerializeField]
	private PassiveButton button;

	private bool oldValue;

	public bool IsChecked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Toggle()
	{
	}

	private void Awake()
	{
	}
}
