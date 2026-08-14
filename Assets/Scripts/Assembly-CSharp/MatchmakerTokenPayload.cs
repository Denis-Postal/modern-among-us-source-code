using System;

public class MatchmakerTokenPayload
{
	public readonly string Puid;

	public readonly int ClientVersion;

	public readonly DateTime ExpiresAt;

	public MatchmakerTokenPayload(string puid, int clientVersion, DateTime expiresAt)
	{
	}
}
