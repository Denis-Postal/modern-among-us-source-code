using Newtonsoft.Json;

public class DnsRegionInfo : IRegionInfo
{
	public readonly string Fqdn;

	public readonly string DefaultIp;

	public readonly ushort Port;

	public readonly bool UseDtls;

	private ServerInfo[] cachedServers;

	public string Name { get; }

	[JsonIgnore]
	public string PingServer => null;

	[JsonIgnore]
	public ServerInfo[] Servers => null;

	public StringNames TranslateName { get; }

	public string TargetServer { get; }

	public DnsRegionInfo(string fqdn, string name, StringNames translateName, string defaultIp, ushort port, bool useDtls = true)
	{
	}

	private void PopulateServers()
	{
	}

	private DnsRegionInfo(string fqdn, string name, StringNames translateName, ServerInfo[] servers)
	{
	}

	public bool Validate()
	{
		return false;
	}

	public IRegionInfo Duplicate()
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
