using System;
using Rewired;
using UnityEngine;

public class ControllerButtonBehaviourComplex : MonoBehaviour
{
	public enum ActionTriggerType
	{
		Any = 0,
		All = 1
	}

	[Serializable]
	public struct ActionTrigger
	{
		public enum ActionType
		{
			Axis_GEqual = 0,
			Axis_LEqual = 1,
			Button_Down = 2
		}

		public RewiredConstsEnum.Action action;

		public ActionType actionType;

		public float axisComparisonValue;

		public bool ConditionMet(Player player)
		{
			return false;
		}
	}

	public ActionTriggerType actionTriggerType;

	public ActionTrigger[] actionTriggers;

	public GameObject requiredMenuObject;

	private Player player;

	private void Start()
	{
	}

	private bool ConditionMet()
	{
		return false;
	}

	private void Update()
	{
	}
}
