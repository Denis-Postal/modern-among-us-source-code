public class RingBuffer<T>
{
	private readonly T[] Data;

	private int startIdx;

	public int Count { get; private set; }

	public int Capacity => 0;

	public T this[int i] => default(T);

	public RingBuffer(int size)
	{
	}

	public T First()
	{
		return default(T);
	}

	public T Last()
	{
		return default(T);
	}

	public void Add(T item)
	{
	}

	public T RemoveFirst()
	{
		return default(T);
	}

	public void Clear()
	{
	}
}
