using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
	public static class SceneManagerCallbacks
	{
		private static bool initialized;

		static SceneManagerCallbacks()
		{
			Init();
		}

		private static void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
		{
		}

		private static void SceneManager_sceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public static void Init()
		{
			if (initialized)
			{
				return;
			}
			initialized = true;
			SceneManager.activeSceneChanged += SceneManager_activeSceneChanged;
			SceneManager.sceneLoaded += SceneManager_sceneLoaded;
		}
	}

	public string TargetScene;

	public bool disallowBasedOnSwitchParentalControls;

	public bool disallowBasedOnAssetPackDownloads;

	public GameObject ConnectIcon;

	public Button.ButtonClickedEvent BeforeSceneChange = new Button.ButtonClickedEvent();

	private AsyncOperation loadOp;

	private void Awake()
	{
		SceneManagerCallbacks.Init();
		if (ConnectIcon != null)
		{
			ConnectIcon.SetActive(false);
		}
	}

	public void Click()
	{
		if (BeforeSceneChange != null)
		{
			BeforeSceneChange.Invoke();
		}
		ChangeScene();
	}

	private void ChangeScene()
	{
		ChangeScene(TargetScene);
	}

	public static void ChangeScene(string target)
	{
		if (string.IsNullOrEmpty(target))
		{
			Debug.LogWarning("SceneChanger.ChangeScene called with an empty target scene.");
			return;
		}
		SceneManagerCallbacks.Init();
		SceneManager.LoadScene(target);
	}

	public void ExitGame()
	{
		Application.Quit();
	}

	public void BeginLoadingScene()
	{
		BeginLoadingSceneInternal(LoadSceneMode.Single);
	}

	public void BeginLoadingSceneAdditive()
	{
		BeginLoadingSceneInternal(LoadSceneMode.Additive);
	}

	private void BeginLoadingSceneInternal(LoadSceneMode mode)
	{
		if (loadOp != null || string.IsNullOrEmpty(TargetScene))
		{
			return;
		}
		if (ConnectIcon != null)
		{
			ConnectIcon.SetActive(true);
		}
		if (BeforeSceneChange != null)
		{
			BeforeSceneChange.Invoke();
		}
		SceneManagerCallbacks.Init();
		loadOp = SceneManager.LoadSceneAsync(TargetScene, mode);
		if (loadOp != null)
		{
			loadOp.allowSceneActivation = false;
		}
	}

	public void AllowFinishLoadingScene()
	{
		if (loadOp != null)
		{
			loadOp.allowSceneActivation = true;
			loadOp = null;
			return;
		}
		ChangeScene();
	}
}
