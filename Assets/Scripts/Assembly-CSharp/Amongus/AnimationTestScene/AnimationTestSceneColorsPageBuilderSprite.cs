using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestSceneColorsPageBuilderSprite : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
	{
		private static readonly Color32 COLOR_NORMAL;

		private static readonly Color32 COLOR_OVER;

		private static readonly Color32 COLOR_SELECTED;

		[SerializeField]
		private Image image;

		[SerializeField]
		private int order;

		private bool isSelected;

		private Vector3 dragOffset;

		private Material cachedMaterial;

		private PointerEventData overPointer;

		private PointerEventData downPointer;

		private PointerEventData dragPointer;

		public RectTransform RectTransform => null;

		public int Order => 0;

		public float Scale => 0f;

		public string BuilderName { get; private set; }

		private Material Material => null;

		public bool IsActive => false;

		public event Action<AnimationTestSceneColorsPageBuilderSprite> OnClick
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

		private void Update()
		{
		}

		public void SetSelected(bool selected)
		{
		}

		public void SetOrder(int newOrder)
		{
		}

		public void SetName(string name)
		{
		}

		public void SetSprite(Sprite sprite)
		{
		}

		public void SetScale(float scale)
		{
		}

		public void SetOutlineColor(Color color)
		{
		}

		public void InstantiateAndCacheMaterial()
		{
		}

		protected void OnPointerClick()
		{
		}

		void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
		}

		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
		{
		}

		void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
		{
		}

		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
		}

		void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
		}

		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
		{
		}

		void IDragHandler.OnDrag(PointerEventData eventData)
		{
		}

		void IEndDragHandler.OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
