using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class StatsPopup : MonoBehaviour
{
	public TextMeshPro StatsText;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	[SerializeField]
	private UiElement[] SelectableButtons;

	private static readonly Dictionary<StatID, StringNames> BaseStatsToShow;

	private static readonly Dictionary<StatID, StringNames> RoleSpecificStatsToShow;

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private static void AppendStat(StringBuilder str, StringNames statName, object stat, params object[] additionalTranslationParams)
	{
	}

	public void DisplayGameStats()
	{
	}

	public void DisplayRoleStats()
	{
	}
}
