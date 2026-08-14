using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputDisplayHider : MonoBehaviour
{
	private const string HiddenNamePart = "InputDisplayGlyph";

	private static InputDisplayHider instance;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	private static void Bootstrap()
	{
		if ((bool)instance)
		{
			return;
		}
		GameObject gameObject = new GameObject(nameof(InputDisplayHider));
		instance = gameObject.AddComponent<InputDisplayHider>();
	}

	private void Awake()
	{
		if ((bool)instance && instance != this)
		{
			Destroy(gameObject);
			return;
		}
		instance = this;
		DontDestroyOnLoad(gameObject);
		SceneManager.sceneLoaded -= OnSceneLoaded;
		SceneManager.sceneLoaded += OnSceneLoaded;
		HideInputDisplays();
	}

	private void OnDestroy()
	{
		if (instance == this)
		{
			SceneManager.sceneLoaded -= OnSceneLoaded;
			instance = null;
		}
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		StartCoroutine(HideAfterSceneLoad());
	}

	private IEnumerator HideAfterSceneLoad()
	{
		yield return null;
		HideInputDisplays();
	}

	private static void HideInputDisplays()
	{
		for (int i = 0; i < SceneManager.sceneCount; i++)
		{
			Scene scene = SceneManager.GetSceneAt(i);
			if (!scene.isLoaded)
			{
				continue;
			}
			GameObject[] roots = scene.GetRootGameObjects();
			for (int j = 0; j < roots.Length; j++)
			{
				HideInputDisplaysIn(roots[j].transform);
			}
		}
	}

	private static void HideInputDisplaysIn(Transform root)
	{
		Transform[] children = root.GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < children.Length; i++)
		{
			GameObject gameObject = children[i].gameObject;
			if (gameObject.name.IndexOf(HiddenNamePart, System.StringComparison.OrdinalIgnoreCase) >= 0)
			{
				gameObject.SetActive(false);
			}
		}
	}
}
