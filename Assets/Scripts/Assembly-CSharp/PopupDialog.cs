using TMPro;
using UnityEngine;

public class PopupDialog : MonoBehaviour
{
	public TextMeshPro workingText;

	public float secondsBetweenDots;

	public int maxDots;

	public string currentProgressText;

	private float textUpdateTimer;

	private static PopupDialog instance;

	public static void Display()
	{
	}

	public static void Dispose()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void Update()
	{
	}
}
