using UnityEngine;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestSceneColorsPage : AbstractAnimationTestScenePage
	{
		public enum State
		{
			Builder = 0,
			Render = 1
		}

		public static readonly RuntimePlatform[] SupportedPlatforms;

		[SerializeField]
		private AnimationTestSceneColorsPageBuilder builder;

		[SerializeField]
		private AnimationTestSceneColorsPageRenderer renderer;

		private State state;

		protected override void Awake()
		{
		}

		protected override void OnShow()
		{
		}

		private void SetState(State state)
		{
		}

		private void OnRender()
		{
		}

		private void OnRendererClose()
		{
		}
	}
}
