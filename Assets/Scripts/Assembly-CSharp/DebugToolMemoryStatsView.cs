using TMPro;
using Unity.Profiling;
using UnityEngine;

public class DebugToolMemoryStatsView : MonoBehaviour
{
	[SerializeField]
	private GameObject background;

	[SerializeField]
	private TextMeshProUGUI gcMemoryText;

	[SerializeField]
	private TextMeshProUGUI systemMemoryText;

	[SerializeField]
	private TextMeshProUGUI textureMemoryText;

	private string statsText;

	private ProfilerRecorder systemMemoryRecorder;

	private ProfilerRecorder gcMemoryRecorder;

	private ProfilerRecorder textureMemoryRecorder;

	private bool isVisible;

	private bool isRecording;

	public long GCMemory => 0L;

	public long SystemMemory => 0L;

	public long TextureMemory => 0L;

	public void StartRecording()
	{
	}

	public void StopRecording()
	{
	}

	private void Update()
	{
	}

	public void ToggleVisibility(bool visible)
	{
	}

	private void HideDetails()
	{
	}
}
