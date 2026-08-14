public class StaticRegionInfo : IRegionInfo
{
	public string Name { get; }

	public string PingServer { get; }

	public ServerInfo[] Servers { get; }

	public string TargetServer { get; }

	public StringNames TranslateName { get; }

	public StaticRegionInfo(string name, StringNames translateName, string pingServer, ServerInfo[] servers)
	{
	}

	public IRegionInfo Duplicate()
	{
		return null;
	}

	public bool Validate()
	{
		return false;
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
