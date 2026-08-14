using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos
{
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu(null)]
	public sealed class UIPointer : UIBehaviour
	{
		[SerializeField]
		[Tooltip("Should the hardware pointer be hidden?")]
		private bool _hideHardwarePointer;

		[Tooltip("Sets the pointer to the last sibling in the parent hierarchy. Do not enable this on multiple UIPointers under the same parent transform or they will constantly fight each other for dominance.")]
		[SerializeField]
		private bool _autoSort;

		private Canvas _canvas;

		public bool autoSort
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		protected override void OnCanvasGroupChanged()
		{
		}

		public void OnScreenPositionChanged(Vector2 screenPosition)
		{
		}

		private void GetDependencies()
		{
		}
	}
}
