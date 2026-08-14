using System.Collections.Generic;
using UnityEngine;

public class EmailTextBehaviour : MonoBehaviour
{
	public static readonly HashSet<char> SymbolChars;

	public TextBoxTMP nameSource;

	public string GetEmailValidEmail()
	{
		return null;
	}

	public string GetEmailWithoutValidityCheck()
	{
		return null;
	}

	private bool IsValidEmail(string text)
	{
		return false;
	}

	public bool ShakeIfInvalid()
	{
		return false;
	}

	public bool ShakeIfDoesntMatch(string email1, string email2)
	{
		return false;
	}
}
