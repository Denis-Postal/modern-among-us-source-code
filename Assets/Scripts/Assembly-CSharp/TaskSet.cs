using System;

[Serializable]
public class TaskSet
{
	public TaskTypes taskType;

	public IntRange taskStep;

	public bool Contains(PlayerTask t)
	{
		return false;
	}
}
