using System;

[Serializable]
public struct LimitedTime
{
	public int limitedYear;

	public int limitedMonth;

	public int limitedDay;

	public int limitedHour;

	public int limitedMinute;

	public LimitedTime(int year, int month, int day, int hour, int minute)
	{
		limitedYear = 0;
		limitedMonth = 0;
		limitedDay = 0;
		limitedHour = 0;
		limitedMinute = 0;
	}

	public LimitedTime(DateTime time)
	{
		limitedYear = 0;
		limitedMonth = 0;
		limitedDay = 0;
		limitedHour = 0;
		limitedMinute = 0;
	}

	public bool IsLimitedTime()
	{
		return false;
	}

	public bool IsNowAfterThisTime()
	{
		return false;
	}

	public bool IsAfterThisTime(DateTime time)
	{
		return false;
	}

	public bool IsNowBeforeThisTime()
	{
		return false;
	}

	public bool IsBeforeThisTime(DateTime time)
	{
		return false;
	}

	public string TimeLeftFromNow()
	{
		return null;
	}

	public string TimeLeft(DateTime time)
	{
		return null;
	}

	public string TimeLeftFromNowShort()
	{
		return null;
	}

	public string TimeLeftShort(DateTime time)
	{
		return null;
	}

	public DateTime GetDateTime()
	{
		return default(DateTime);
	}
}
