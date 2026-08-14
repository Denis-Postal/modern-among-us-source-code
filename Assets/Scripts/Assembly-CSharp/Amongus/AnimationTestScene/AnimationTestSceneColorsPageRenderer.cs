using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestSceneColorsPageRenderer : MonoBehaviour
	{
		[SerializeField]
		private AnimationTestSceneButton returnButton;

		[SerializeField]
		private RectTransform container;

		public event Action OnReturnEvent
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

		public void Clear()
		{
		}

		public void Render(AnimationTestSceneColorsPageBuilderSprite[] layers)
		{
		}

		private GameObject CreateColorCopy(GameObject composition, CrewmateColor color)
		{
			return null;
		}

		private GameObject CreateComposition(AnimationTestSceneColorsPageBuilderSprite[] layers)
		{
			return null;
		}

		private static void CenterChildren(Transform parent)
		{
		}
	}
}
