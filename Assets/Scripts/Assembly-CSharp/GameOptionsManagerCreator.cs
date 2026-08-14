using UnityEngine;
using InnerNet;

public class GameOptionsManagerCreator : MonoBehaviour
{
	private void Awake()
	{
		if (GameOptionsManager.Instance == null)
		{
			new GameOptionsManager(new UnityLogger());
		}
	}

	private void Start()
	{
		if (GameOptionsManager.Instance != null)
		{
			GameOptionsManager.Instance.Initialize();
		}
	}
}
