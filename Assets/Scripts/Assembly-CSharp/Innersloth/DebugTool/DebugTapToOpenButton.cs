using UnityEngine;
using UnityEngine.UI;

namespace Innersloth.DebugTool
{
	public class DebugTapToOpenButton : MonoBehaviour
	{
		[SerializeField]
		private float maxSecondsBetweenTaps;

		[SerializeField]
		private DebugToolOverlay debugOverlay;

		[SerializeField]
		private Button tapButton;

		private float lastTapTime;

		private int numTapsSoFar;

		private void Awake()
		{
		}

		public void SetRaycastTarget(bool raycast)
		{
		}

		private void Tap()
		{
		}
	}
}
