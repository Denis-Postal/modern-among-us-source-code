using System.Collections.Generic;

public class PseudoRandomList<T>
{
	private List<T> options;

	private List<T> currentRemaining;

	private XXHash rand;

	private int offset;

	public PseudoRandomList()
	{
	}

	public PseudoRandomList(int seed)
	{
	}

	public void ClearWithNewSeed(int seed)
	{
	}

	public void Add(T item)
	{
	}

	public void AddRange(IEnumerable<T> list)
	{
	}

	public void Clear()
	{
	}

	public T PickRandom()
	{
		return default(T);
	}
}
