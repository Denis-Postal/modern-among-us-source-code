using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestSceneColorsPageBuilderPresetButton : MonoBehaviour
	{
		[SerializeField]
		private AnimationTestSceneButton button;

		[SerializeField]
		private Image image;

		public Sprite Sprite => null;

		public event Action<AnimationTestSceneColorsPageBuilderPresetButton> OnPressEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnPress(AnimationTestSceneButton button)
		{
		}
	}
}
