using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class NormalPlayerTask : PlayerTask
{
	public enum TaskLength
	{
		None = 0,
		Common = 1,
		Short = 2,
		Long = 3
	}

	public enum TimerState
	{
		NotStarted = 0,
		Started = 1,
		Finished = 2
	}

	public TaskLength Length;

	public int taskStep;

	public int MaxStep;

	public bool ShowTaskStep;

	public bool ShowTaskTimer;

	public TimerState TimerStarted;

	public float TaskTimer;

	public byte[] Data;

	public ArrowBehaviour Arrow;

	[SerializeField]
	[Tooltip("To have multiple texts on multistage tasks")]
	private bool useMultipleText;

	[SerializeField]
	[Tooltip("For tasks that need a number of steps completed before stage 2")]
	private int maxNumStepsStage1;

	[SerializeField]
	[Tooltip("Used only if useMultipleText is selected")]
	private StringNames textStage1;

	[SerializeField]
	[Tooltip("Used only if useMultipleText is selected")]
	private StringNames textStage2;

	protected bool arrowSuspended;

	public override int TaskStep => 0;

	public override bool IsComplete => false;

	public override void Initialize()
	{
	}

	public void NextStep()
	{
	}

	public virtual void UpdateArrowAndLocation()
	{
	}

	protected virtual void FixedUpdate()
	{
	}

	public override bool ValidConsole(Console console)
	{
		return false;
	}

	public override void Complete()
	{
	}

	public override void AppendTaskText(StringBuilder sb)
	{
	}

	private bool ShouldYellowText()
	{
		return false;
	}

	private static List<Console> PickRandomConsoles(TaskTypes taskType, byte[] consoleIds)
	{
		return null;
	}

	private static List<Console> PickRandomConsoles(int taskStep, TaskTypes taskType)
	{
		return null;
	}
}
