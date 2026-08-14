using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Innersloth.DebugTool
{
	public class DebugMemoryPage : DebugToolOverlayPage
	{
		[Header("Memory Details")]
		[SerializeField]
		private TextMeshProUGUI gcMemoryText;

		[SerializeField]
		private TextMeshProUGUI systemMemoryText;

		[SerializeField]
		private TextMeshProUGUI textureMemoryText;

		[SerializeField]
		private Button toggleMemoryRecordingButton;

		[SerializeField]
		private TextMeshProUGUI toggleMemoryRecordingText;

		[SerializeField]
		private Toggle toggleMemoryOverlayButton;

		private DebugToolMemoryStatsView memoryStatsView;

		private bool isVisible;

		private bool isRecording;

		private bool isOverlayEnabled;

		public override string Name => null;

		public override bool ConsumingNavActions => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void ToggleMemoryOverlay(bool enable)
		{
		}

		private void StartRecording()
		{
		}

		private void StopRecording()
		{
		}

		private void Update()
		{
		}

		public override void Show()
		{
		}

		public override void OnBackButtonPressed()
		{
		}

		private void HideDetails()
		{
		}
	}
}
