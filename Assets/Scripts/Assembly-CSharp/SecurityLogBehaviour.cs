using System.Collections.Generic;
using UnityEngine;

public class SecurityLogBehaviour : MonoBehaviour
{
	public enum SecurityLogLocations
	{
		North = 0,
		Southeast = 1,
		Southwest = 2
	}

	public struct SecurityLogEntry
	{
		public byte PlayerId;

		public SecurityLogLocations Location;

		public SecurityLogEntry(byte playerId, SecurityLogLocations location)
		{
			PlayerId = 0;
			Location = default(SecurityLogLocations);
		}
	}

	public const byte ConsoleMask = 240;

	public const byte PlayerMask = 15;

	public Color[] BarColors;

	public readonly List<SecurityLogEntry> LogEntries;

	public bool HasNew;

	public void LogPlayer(PlayerControl player, SecurityLogLocations location)
	{
	}
}
