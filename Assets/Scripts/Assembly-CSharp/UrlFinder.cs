public static class UrlFinder
{
	private static readonly string[] Prefixes;

	private static readonly string[] Suffixes;

	public static bool TryFindUrl(char[] sourceText, out int startCensor, out int endCensor)
	{
		startCensor = default(int);
		endCensor = default(int);
		return false;
	}

	private static bool CheckPrefixes(char[] sourceText, out int startCensor, out int endCensor)
	{
		startCensor = default(int);
		endCensor = default(int);
		return false;
	}

	private static bool CheckSuffixes(char[] sourceText, int startAt, out int startCensor, out int endCensor)
	{
		startCensor = default(int);
		endCensor = default(int);
		return false;
	}

	private static int FindWord(char[] sourceText, string word, int startAt = 0)
	{
		return 0;
	}

	private static int FindWordStart(char[] sourceText, int startAt)
	{
		return 0;
	}

	private static int FindWordEnd(char[] sourceText, int startAt)
	{
		return 0;
	}
}
