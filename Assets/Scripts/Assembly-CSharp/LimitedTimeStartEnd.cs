using System;

[Serializable]
public struct LimitedTimeStartEnd
{
	public LimitedTime timeStart;

	public LimitedTime timeEnd;

	public bool IsAvailable()
	{
		return false;
	}

	public bool IsLimitedTime()
	{
		return false;
	}

	public bool HasEndDate()
	{
		return false;
	}

	public bool IsLimitedAndAvailable()
	{
		return false;
	}

	public bool HasEndDateAndAvailable()
	{
		return false;
	}
}
