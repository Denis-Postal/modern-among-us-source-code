using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

internal class SelectableHyperLinkHelper : MonoBehaviour
{
	private static readonly Regex linkReg;

	public static void SanitizeLinkText(string fullText, out string result)
	{
		result = null;
	}

	public static void ExtractUrl(string fullText, out string url, out string visibleTextPart)
	{
		url = null;
		visibleTextPart = null;
	}

	public static void DecomposeHyperlinkText(string textToDecompose, List<ITextPart> textConstituents, List<SelectableHyperLink> selectableHyperLinks)
	{
	}

	private static void GetFirstUrl(string textToDecompose, out string nonUrlPart, out string urlPart)
	{
		nonUrlPart = null;
		urlPart = null;
	}

	public static void AddSelectableUiForHyperlinks(List<SelectableHyperLink> selectableHyperLinks, string menuName)
	{
	}

	public static void DestroyGOs(List<SelectableHyperLink> selectableHyperLinks, string menuName)
	{
	}

	public static void UpdateHyperlinkPositions(TextMeshPro tmp, List<SelectableHyperLink> selectableHyperLinks, string menuName)
	{
	}

	public static string DecomposeAnnouncementText(TextMeshPro tmp, List<SelectableHyperLink> selectableHyperLinks, string menuName, string text)
	{
		return null;
	}

	public static string RecomposeAnnouncementText(List<ITextPart> textConstituents)
	{
		return null;
	}
}
