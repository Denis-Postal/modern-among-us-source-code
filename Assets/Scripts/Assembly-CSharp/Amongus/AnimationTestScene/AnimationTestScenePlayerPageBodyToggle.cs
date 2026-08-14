using UnityEngine;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestScenePlayerPageBodyToggle : MonoBehaviour
	{
		[SerializeField]
		private PlayerBodyTypes bodyType;

		private AnimationTestSceneButton button;

		public PlayerBodyTypes BodyType => default(PlayerBodyTypes);

		public AnimationTestSceneButton Button => null;
	}
}
