using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Logger
{
	public enum Category
	{
		None = 0,
		Addressables = 1,
		Assets = 2,
		Data = 3,
		Gameplay = 4,
		Input = 5,
		Network = 6,
		Server = 7,
		UI = 8,
		Ads = 9
	}

	private static readonly Dictionary<Category, string> ColorDict;

	public static readonly Logger GlobalInstance;

	private static StringBuilder builder;

	private readonly Category category;

	private readonly string[] subCategories;

	public Logger()
	{
	}

	public Logger(Category category)
	{
	}

	public Logger(Category category, params string[] subCategories)
	{
	}

	public void Debug(object message, UnityEngine.Object context = null)
	{
	}

	public void Debug(string[] path, object message, UnityEngine.Object context = null)
	{
	}

	public void Info(object message, UnityEngine.Object context = null)
	{
	}

	public void Info(string[] path, object message, UnityEngine.Object context = null)
	{
	}

	public void Warning(object message, UnityEngine.Object context = null)
	{
	}

	public void Warning(string[] path, object message, UnityEngine.Object context = null)
	{
	}

	public void Error(object message, UnityEngine.Object context = null)
	{
	}

	public void Error(string[] path, object message, UnityEngine.Object context = null)
	{
	}

	public void Exception(Exception e, UnityEngine.Object context = null)
	{
	}

	private string FormatMessageForDebugConsole(object message, string[] path)
	{
		return null;
	}

	private string BuildDebugConsolePath(string[] path)
	{
		return null;
	}

	private string FormatCategoryAndSubCategoryForBreadcrumb(string[] path)
	{
		return null;
	}

	private string BuildBreadcrumbPath(string[] path)
	{
		return null;
	}

	private string FormatMessageForBreadcrumb(object message)
	{
		return null;
	}
}
