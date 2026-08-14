using System.Collections.Generic;
using Hazel;
using InnerNet;

public class VoteBanSystem : InnerNetObject
{
	public static VoteBanSystem Instance;

	public Dictionary<int, int[]> Votes;

	public void Awake()
	{
	}

	public void CmdAddVote(int clientIdToVoteBan)
	{
	}

	private void AddVote(int srcClient, int clientId)
	{
	}

	public bool HasMyVote(int clientId)
	{
		return false;
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	public override void ClearOrDecrementDirt()
	{
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}
}
