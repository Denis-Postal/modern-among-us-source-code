using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestSceneTab : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		private static readonly Color32 COLOR_NORMAL;

		private static readonly Color32 COLOR_OVER;

		private static readonly Color32 COLOR_DOWN;

		private static readonly Color32 COLOR_ACTIVE;

		private static readonly Color32 TEXT_COLOR_NORMAL;

		private static readonly Color32 TEXT_COLOR_OVER;

		private static readonly Color32 TEXT_COLOR_DOWN;

		private static readonly Color32 TEXT_COLOR_ACTIVE;

		[SerializeField]
		private Graphic graphic;

		[SerializeField]
		private TextMeshProUGUI text;

		[Space(10f)]
		[SerializeField]
		private AbstractAnimationTestScenePage page;

		private bool isActive;

		private PointerEventData overPointer;

		private PointerEventData downPointer;

		public AbstractAnimationTestScenePage Page => null;

		public bool IsActive => false;

		public event Action<AnimationTestSceneTab> OnClick
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

		protected virtual void Update()
		{
		}

		protected void OnPointerClick()
		{
		}

		public void SetActive(bool active)
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
	}
}
