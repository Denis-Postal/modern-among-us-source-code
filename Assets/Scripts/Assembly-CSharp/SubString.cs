public struct SubString
{
	public readonly int Start;

	public readonly int Length;

	public readonly string Source;

	public SubString(string source, int start, int length)
	{
		Start = 0;
		Length = 0;
		Source = null;
	}

	public override string ToString()
	{
		return null;
	}

	public int GetKvpValue()
	{
		return 0;
	}

	public int ToInt()
	{
		return 0;
	}

	public bool StartsWith(string v)
	{
		return false;
	}
}
