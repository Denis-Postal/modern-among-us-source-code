using UnityEngine;
using UnityEngine.Events;

public class CrossplayChangedEvent : MonoBehaviour
{
	public bool onlyOnPlayStation;

	public UnityEvent OnCrossplayChanged;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void InvokeSelfCrossplayChanged()
	{
	}
}
