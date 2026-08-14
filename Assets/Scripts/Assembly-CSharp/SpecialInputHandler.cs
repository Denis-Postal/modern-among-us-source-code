using UnityEngine;

public class SpecialInputHandler : MonoBehaviour
{
	public static int count;

	public static int disableVirtualCursorCount;

	public static int suppressInGamePlayerListCount;

	[SerializeField]
	private bool _disableVirtualCursor;

	[SerializeField]
	private bool _suppressInGamePlayerList;

	public bool disableVirtualCursor
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool suppressInGamePlayerList
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
