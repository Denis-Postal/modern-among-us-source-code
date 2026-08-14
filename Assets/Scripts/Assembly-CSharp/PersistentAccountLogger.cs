using System.IO;

public class PersistentAccountLogger : DestroyableSingleton<PersistentAccountLogger>
{
	private StreamWriter sw;

	private void Start()
	{
	}

	public void AddStringToLog(string str)
	{
	}

	private void OnApplicationQuit()
	{
	}
}
