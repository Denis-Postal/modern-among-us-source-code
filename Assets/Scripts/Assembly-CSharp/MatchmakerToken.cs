using Newtonsoft.Json;

public class MatchmakerToken
{
	public readonly MatchmakerTokenPayload Content;

	public readonly string Hash;

	[JsonIgnore]
	public bool IsValid => false;

	[JsonConstructor]
	public MatchmakerToken(MatchmakerTokenPayload content, string hash)
	{
	}

	public static bool TryParse(string base64Json, out MatchmakerToken token)
	{
		token = null;
		return false;
	}
}
