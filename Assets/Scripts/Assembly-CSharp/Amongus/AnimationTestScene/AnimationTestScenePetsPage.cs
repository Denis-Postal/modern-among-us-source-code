using UnityEngine;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestScenePetsPage : AbstractAnimationTestScenePage
	{
		private const float SCALE_NORMAL = 75f;

		private const float SCALE_ZOOMED = 150f;

		[Header("Pet Page")]
		[SerializeField]
		private GameObject emptyPage;

		[Space(10f)]
		[SerializeField]
		private GameObject visiblePage;

		[SerializeField]
		private RectTransform zoomedContainer;

		[SerializeField]
		private RectTransform idleContainer;

		[SerializeField]
		private RectTransform walkingContainer;

		[SerializeField]
		private RectTransform scaredContainer;

		[SerializeField]
		private RectTransform mourningContainer;

		[SerializeField]
		private RectTransform pettingContainer;

		private PetData petData;

		private byte color;

		private PetBehaviour[] petViews;

		private PetBehaviour zoomed;

		private PetBehaviour idle;

		private PetBehaviour walking;

		private PetBehaviour scared;

		private PetBehaviour mourning;

		private PetBehaviour petting;

		protected override void OnShow()
		{
		}

		protected override void OnHide()
		{
		}

		private void TryLoadPet()
		{
		}

		private void ClearPet()
		{
		}

		private void LoadPet(PetData newPet, byte newColor)
		{
		}

		private void OnLoadSuccess(PetBehaviour prefab)
		{
		}

		private void OnLoadError()
		{
		}

		public PetBehaviour InstantiatePet(PetBehaviour prefab, RectTransform container, float scale)
		{
			return null;
		}
	}
}
