using UnityEngine;

public class DestroyableSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;

	private static object _lock = new object();

	public bool DontDestroy;

	public static bool InstanceExists
	{
		get
		{
			return _instance;
		}
	}

	public static T Instance
	{
		get
		{
			lock (_lock)
			{
				if (!_instance)
				{
					_instance = Object.FindObjectOfType<T>();
					if (!_instance)
					{
						GameObject gameObject = new GameObject("(singleton) " + typeof(T));
						_instance = gameObject.AddComponent<T>();
					}
				}
				return _instance;
			}
		}
	}

	public virtual void Awake()
	{
		if (!_instance)
		{
			_instance = this as T;
			if (DontDestroy)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		else if (_instance != this)
		{
			Object.Destroy(base.gameObject);
		}
		else if (DontDestroy)
		{
			Object.DontDestroyOnLoad(base.gameObject);
		}
	}

	public virtual void OnDestroy()
	{
		if (!DontDestroy)
		{
			lock (_lock)
			{
				_instance = null;
			}
		}
	}
}
