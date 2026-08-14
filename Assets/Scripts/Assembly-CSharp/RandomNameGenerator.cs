using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class RandomNameGenerator : MonoBehaviour
{
	public TextAsset PatternConfig;

	private List<Pattern> Patterns;

	private Dictionary<string, WordGroup> WordGroups;

	private static System.Random randy;

	private IEnumerable<Pattern> UsablePatterns;

	private void Awake()
	{
	}

	public string GetName()
	{
		return null;
	}

	public bool ValidateName(string inName)
	{
		return false;
	}

	public void Reset()
	{
	}

	public void Parse(TextReader reader)
	{
	}
}
