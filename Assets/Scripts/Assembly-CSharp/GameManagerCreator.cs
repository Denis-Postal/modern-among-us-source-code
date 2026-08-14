using AmongUs.GameOptions;
using UnityEngine;

public class GameManagerCreator : MonoBehaviour
{
	public NormalGameManager NormalGameManagerPrefab;

	public HideAndSeekManager HideAndSeekManagerPrefab;

	public static GameManagerCreator Instance { get; private set; }

	public static GameManager CreateGameManager(GameModes mode)
	{
		if (Instance == null)
		{
			Instance = FindObjectOfType<GameManagerCreator>();
		}
		if (Instance == null)
		{
			return null;
		}
		GameManager prefab = mode == GameModes.HideNSeek ? Instance.HideAndSeekManagerPrefab : Instance.NormalGameManagerPrefab;
		if (prefab == null)
		{
			return null;
		}
		GameManager gameManager = Object.Instantiate(prefab);
		gameManager.name = prefab.name;
		return gameManager;
	}

	private void Awake()
	{
		Instance = this;
		if (GameManager.Instance == null)
		{
			CreateGameManager(GameModes.Normal);
		}
	}
}
