using Newtonsoft.Json;

public class ServerInfo
{
	public readonly string Name;

	public readonly string Ip;

	public readonly ushort Port;

	public readonly bool UseDtls;

	public int Players;

	public int ConnectionFailures;

	[JsonIgnore]
	public string HttpUrl => null;

	public ServerInfo(string name, string ip, ushort port, bool useDtls = true)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}
}
