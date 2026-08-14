using Hazel;

public class PlatformSpecificData
{
	public Platforms Platform;

	public string PlatformName;

	public ulong XboxPlatformId;

	public ulong PsnPlatformId;

	public void Deserialize(MessageReader reader)
	{
	}

	public void Serialize(MessageWriter writer)
	{
	}
}
