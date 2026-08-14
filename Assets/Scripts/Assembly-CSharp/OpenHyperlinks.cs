using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class OpenHyperlinks : MonoBehaviour
{
	[SerializeField]
	private TextMeshPro pTextMeshPro;

	[SerializeField]
	private Color linkColor;

	public string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Color LinkColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public bool GetWordPosition(string text, List<string> wordsPositioned, out Vector3 bottomLeft, out Vector3 topRight, out int lineBreakCount)
	{
		bottomLeft = default(Vector3);
		topRight = default(Vector3);
		lineBreakCount = default(int);
		return false;
	}

	public void UpdateTMPMesh()
	{
	}
}
