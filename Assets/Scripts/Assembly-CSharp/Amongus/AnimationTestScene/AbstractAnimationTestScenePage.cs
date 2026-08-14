using UnityEngine;
using UnityEngine.UI;

namespace AmongUs.AnimationTestScene
{
	public abstract class AbstractAnimationTestScenePage : MonoBehaviour
	{
		[SerializeField]
		private Selectable defaultSelection;

		private AnimationTestScene testScene;

		protected AnimationTestScene Parent => null;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public void Initialize(AnimationTestScene testScene)
		{
		}

		public void SetActive(bool active)
		{
		}

		protected virtual void OnShow()
		{
		}

		protected virtual void OnHide()
		{
		}

		protected void Select(GameObject gameObject)
		{
		}

		protected bool GetButtonDown(RewiredConstsEnum.DebugAction action)
		{
			return false;
		}

		protected bool GetButton(RewiredConstsEnum.DebugAction action)
		{
			return false;
		}

		protected bool GetButtonUp(RewiredConstsEnum.DebugAction action)
		{
			return false;
		}
	}
}
