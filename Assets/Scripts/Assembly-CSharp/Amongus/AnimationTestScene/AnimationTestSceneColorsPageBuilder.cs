using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestSceneColorsPageBuilder : MonoBehaviour
	{
		private const float DEFAULT_SCALE = 0.5f;

		private static readonly string[] VALID_FILE_TYPES;

		[SerializeField]
		[Header("File Import")]
		private TMP_InputField importInputField;

		[SerializeField]
		private AnimationTestSceneButton findFileButton;

		[SerializeField]
		private AnimationTestSceneButton importButton;

		[SerializeField]
		[Header("Inspector")]
		private GameObject inspectorEmptyPanel;

		[SerializeField]
		private GameObject inspectorSelectionPanel;

		[SerializeField]
		private TextMeshProUGUI inspectorNameText;

		[SerializeField]
		private TextMeshProUGUI inspectorScaleText;

		[SerializeField]
		private AnimationTestSceneButton inspectorScaleDownButton;

		[SerializeField]
		private AnimationTestSceneButton inspectorScaleUpButton;

		[SerializeField]
		private AnimationTestSceneButton inspectorOrderTopButton;

		[SerializeField]
		private AnimationTestSceneButton inspectorOrderUpButton;

		[SerializeField]
		private AnimationTestSceneButton inspectorOrderDownButton;

		[SerializeField]
		private AnimationTestSceneButton inspectorOrderBottomButton;

		[SerializeField]
		private AnimationTestSceneButton inspectorDeleteButton;

		[Header("Composition")]
		[SerializeField]
		private RectTransform canvas;

		[SerializeField]
		private AnimationTestSceneButton renderButton;

		[Header("Prefabs")]
		[SerializeField]
		private AnimationTestSceneColorsPageBuilderSprite builderSpritePrefab;

		private List<AnimationTestSceneColorsPageBuilderSprite> builderSprites;

		private AnimationTestSceneColorsPageBuilderPresetButton[] presetButtons;

		private AnimationTestSceneColorsPageBuilderSprite selection;

		public event Action OnRenderEvent
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

		public AnimationTestSceneColorsPageBuilderSprite[] GetComposition()
		{
			return null;
		}

		private void OnFindFileButtonPressed(AnimationTestSceneButton button)
		{
		}

		private void OnImportPressed(AnimationTestSceneButton button)
		{
		}

		private void OnPresetPressed(AnimationTestSceneColorsPageBuilderPresetButton preset)
		{
		}

		public AnimationTestSceneColorsPageBuilderSprite AddBuilderSprite(Sprite sprite, string name)
		{
			return null;
		}

		private void OnBuilderSpritePressed(AnimationTestSceneColorsPageBuilderSprite builderSprite)
		{
		}

		private void ChangeSelection(AnimationTestSceneColorsPageBuilderSprite builderSprite)
		{
		}

		private void ChangeSelectionScale(float amount)
		{
		}

		private void ChangeSelectionOrder(int amount)
		{
		}

		private void UpdateLayerOrders()
		{
		}

		private void DeleteSelection()
		{
		}

		private void UpdateInspector()
		{
		}
	}
}
