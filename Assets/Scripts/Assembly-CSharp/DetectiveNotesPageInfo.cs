using System;
using System.Collections.Generic;

[Serializable]
public class DetectiveNotesPageInfo
{
	public bool locationSet;

	public string locationName;

	public bool prepositionSet;

	public StringNames prepositionStringName;

	public NetworkedPlayerInfo victimPlayer;

	public List<DetectiveSuspect> suspects;

	public bool impostorSet;

	public string impostorString;

	public DetectiveNotesPageInfo(NetworkedPlayerInfo _victimPlayer)
	{
	}

	public void AddSuspect(NetworkedPlayerInfo suspect)
	{
	}

	public void SetPreposition(StringNames _prepositionString)
	{
	}

	public void SetLocation(string _locationName)
	{
	}

	public void SetImpostorType(string impString)
	{
	}
}
