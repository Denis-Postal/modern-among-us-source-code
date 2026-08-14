using System;
using UnityEngine;

[DefaultExecutionOrder(-10)]
public class CrossplayConditionalObject : MonoBehaviour
{
	public enum CrossplayConditionalType
	{
		ShowIfCrossplayEnabled = 0,
		HideIfCrossplayEnabled = 1
	}

	public bool onlyOnPlayStation;

	public CrossplayConditionalType crossplayConditionalType;

	public static Action OnCrossplayChanged;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateEnabledState()
	{
	}
}
