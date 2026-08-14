using System;
using System.Collections.Generic;

public class ThreadSafeActionQueue
{
	private readonly Queue<Action> pendingCallbacks;

	public void Enqueue(Action action)
	{
	}

	public void Drain()
	{
	}
}
