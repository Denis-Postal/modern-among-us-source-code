using UnityEngine;

public class ControllerDisconnectHandler : MonoBehaviour
{
	private bool isConnected;

	public GameObject ContinueBackground;

	public GameObject ContinueText;

	public GameObject obj;

	[Header("Console Controller Navigation")]
	public UiElement ContinueButton;

	private void Update()
	{
	}

	public void Close()
	{
	}

	private void OnDisable()
	{
	}

	private void OnStateChange(uint index, bool newIsConnected)
	{
	}
}
