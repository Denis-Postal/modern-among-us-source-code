using System;
using UnityEngine;

namespace Assets.CoreScripts
{
	public class UnityTelemetry : DestroyableSingleton<UnityTelemetry>
	{
		private static readonly string[] ColorNames;

		private bool amHost;

		private bool gameStarted;

		private DateTime timeStarted;

		public void Init()
		{
		}

		public void StartGame(bool isHost, int playerCount, int impostorCount, NetworkModes gameMode, uint timesImpostor, uint gamesPlayed, uint crewStreak)
		{
		}

		public void StartGameCosmetics(int colorId, string hatId, string skinId, string petId, string visorId, string nameplateId)
		{
		}

		public void WriteMeetingStarted(bool isEmergency)
		{
		}

		public void WriteMeetingEnded(float duration)
		{
		}

		public void WritePosition(byte playerNum, Vector2 worldPos)
		{
		}

		public void WriteMurder()
		{
		}

		public void WriteSabotageUsed(SystemTypes systemType)
		{
		}

		public void CardSwipeComplete(int attempts)
		{
		}

		public void WriteUse(byte playerNum, TaskTypes taskType, Vector3 worldPos)
		{
		}

		public void WriteCompleteTask(TaskTypes taskType)
		{
		}

		internal void WriteDisconnect(DisconnectReasons reason)
		{
		}

		public void EndGame(GameOverReason endReason)
		{
		}

		public void SendWho()
		{
		}

		public void WonGame(int colorId, string hatId, string skinId, string petId, string visorId, string nameplateId)
		{
		}
	}
}
