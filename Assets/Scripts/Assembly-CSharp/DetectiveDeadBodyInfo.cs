using System.Collections.Generic;

public class DetectiveDeadBodyInfo
{
	public byte victimID;

	public Dictionary<byte, string> PlayerLocationsAtDeath;

	public DetectiveDeadBodyInfo(byte _victimID)
	{
	}

	public string GetPlayerLocation(byte playerID)
	{
		return null;
	}
}
