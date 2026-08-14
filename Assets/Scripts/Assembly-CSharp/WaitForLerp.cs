using System;
using System.Collections;

public class WaitForLerp : IEnumerator
{
	private float duration;

	private float timer;

	private Action<float> act;

	public object Current => null;

	public WaitForLerp(float seconds, Action<float> act)
	{
	}

	public bool MoveNext()
	{
		return false;
	}

	public void Reset()
	{
	}
}
