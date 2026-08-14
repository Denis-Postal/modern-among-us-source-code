public class StaticHttpRegionInfo : IRegionInfo
{
	public string Name { get; }

	public string PingServer { get; }

	public ServerInfo[] Servers { get; }

	public string TargetServer { get; }

	public StringNames TranslateName { get; }

	public StaticHttpRegionInfo(string name, StringNames translateName, string pingServer, ServerInfo[] servers, string targetServer = null)
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
