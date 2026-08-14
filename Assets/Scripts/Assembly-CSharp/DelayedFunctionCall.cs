using UnityEngine;
using UnityEngine.Events;

public class DelayedFunctionCall : MonoBehaviour
{
	public UnityEvent onTimerElapsed;

	public float delayDuration;

	private float t;

	private void Update()
	{
	}
}
