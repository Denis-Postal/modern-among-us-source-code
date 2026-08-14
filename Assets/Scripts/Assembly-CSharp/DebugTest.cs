using System.Text;
using Rewired;
using TMPro;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
	private TextMeshPro _guiText;

	private StringBuilder _sb;

	private byte[] deviceIdBuffer;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void Log(object text)
	{
	}

	private void Log(byte[] buffer)
	{
	}

	private void LogLine(object text = null)
	{
	}

	private void LogLine(string prefix, object text)
	{
	}

	private void Log(Joystick joy)
	{
	}
}
