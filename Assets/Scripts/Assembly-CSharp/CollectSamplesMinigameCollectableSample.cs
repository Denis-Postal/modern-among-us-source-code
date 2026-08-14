using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CollectSamplesMinigameCollectableSample : MonoBehaviour
{
	[SerializeField]
	private PassiveButton button;

	[SerializeField]
	private AudioClip collectSfx;

	public event Action<CollectSamplesMinigameCollectableSample> OnPressEvent
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

	private void OnButtonPressed()
	{
	}
}
