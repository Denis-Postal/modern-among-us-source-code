using UnityEngine;

public class DisableScriptsForJoystick : MonoBehaviour
{
	public MonoBehaviour[] scripts;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnInputMethodChanged()
	{
	}
}
