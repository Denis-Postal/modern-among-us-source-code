using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class TextMeshProExtensions
{
	public static float GetNotDumbRenderedHeight(this TextMeshPro self)
	{
		return 0f;
	}

	public static Vector2 CursorPos(this TextMeshPro self, int caretPos, float yOffset)
	{
		return default(Vector2);
	}

	public static Vector2 CursorPos(this TextMeshPro self)
	{
		return default(Vector2);
	}

	private static int TextInfoIndexOf(this TextMeshPro self, string str, int wordOffset = 0)
	{
		return 0;
	}

	public static bool GetLinkPosition(this TextMeshPro self, int linkIndex, out Vector3 bottomLeft, out Vector3 topRight)
	{
		bottomLeft = default(Vector3);
		topRight = default(Vector3);
		return false;
	}

	public static bool GetWordPosition(this TextMeshPro self, string str, List<string> wordsPositioned, out Vector3 bottomLeft, out Vector3 topRight, out int lineBreakCount)
	{
		bottomLeft = default(Vector3);
		topRight = default(Vector3);
		lineBreakCount = default(int);
		return false;
	}

	public static int GetSplitWordPositions(this TextMeshPro self, string str, List<Vector3> bottomLeft, List<Vector3> topRight)
	{
		return 0;
	}
}
