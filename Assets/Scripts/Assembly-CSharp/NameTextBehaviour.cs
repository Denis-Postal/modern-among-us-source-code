using System.Collections.Generic;
using UnityEngine;

public class NameTextBehaviour : MonoBehaviour
{
	public static readonly HashSet<char> SymbolChars;

	public static NameTextBehaviour Instance;

	public TextBoxTMP nameSource;

	public void Start()
	{
	}

	public void UpdateName()
	{
	}

	public static bool IsValidName(string text)
	{
		return false;
	}

	public bool ShakeIfInvalid()
	{
		return false;
	}
}
