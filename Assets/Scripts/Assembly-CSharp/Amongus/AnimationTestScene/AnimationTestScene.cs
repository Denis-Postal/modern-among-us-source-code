using Rewired;
using Rewired.Integration.UnityUI;
using UnityEngine;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestScene : MonoBehaviour
	{
		[SerializeField]
		private Canvas canvas;

		[Header("Audio")]
		[SerializeField]
		private AudioSource onTabChangeSfx;

		[Header("Rewired")]
		[SerializeField]
		private RewiredEventSystem rewiredEventSystem;

		[SerializeField]
		private RewiredStandaloneInputModule rewiredStandaloneInputModule;

		[SerializeField]
		[Header("Prefabs")]
		private InputManager rewiredInputManagerPrefab;

		private AnimationTestSceneCosmeticData cosmeticData;

		private AnimationTestSceneTab[] tabs;

		private AbstractAnimationTestScenePage[] pages;

		private AnimationTestSceneTab currentTab;

		private InputManager rewiredInputManager;

		private Player inputPlayer;

		public AnimationTestSceneCosmeticData CosmeticData => null;

		protected virtual void Awake()
		{
		}

		protected void Update()
		{
		}

		private void ProcessPageInput()
		{
		}

		private void OnTabClicked(AnimationTestSceneTab tab)
		{
		}

		private void ChangePage(int direction)
		{
		}

		private void ChangePage(AnimationTestSceneTab tab)
		{
		}

		private void ChangePage(AbstractAnimationTestScenePage newPage)
		{
		}

		public bool GetButtonDown(RewiredConstsEnum.DebugAction action)
		{
			return false;
		}

		public bool GetButton(RewiredConstsEnum.DebugAction action)
		{
			return false;
		}

		public bool GetButtonUp(RewiredConstsEnum.DebugAction action)
		{
			return false;
		}

		public void ReturnToStartPage()
		{
		}

		public void ToggleCanvas(bool visible)
		{
		}

		public static void AddDebugCommand()
		{
		}

		public static void RemoveDebugCommand()
		{
		}

		public void OpenDebugConsole()
		{
		}
	}
}
