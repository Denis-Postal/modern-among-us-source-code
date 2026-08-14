using System.Collections.Generic;
using AmongUs.GameOptions;
using TMPro;
using UnityEngine;

public class CreateOptionsPicker : MonoBehaviour
{
	private const float MaxPlayerButtonWidth = 0.5f;

	public SpriteRenderer MaxPlayerButtonPrefab;

	private List<SpriteRenderer> MaxPlayerButtons;

	public Transform MaxPlayersRoot;

	public MapPickerMenu MapMenu;

	public ImpostorsOptionButton[] ImpostorButtons;

	public TextMeshPro LanguageButton;

	public TextMeshPro GameModeText;

	public TextMeshPro ImpostorText;

	public SettingsMode mode;

	public CrewVisualizer CrewArea;

	public CreateGameOptions optionsMenu;

	public void Awake()
	{
	}

	public void Start()
	{
	}

	public void Refresh()
	{
	}

	public IGameOptions GetTargetOptions()
	{
		return null;
	}

	private void SetTargetOptions(IGameOptions data)
	{
	}

	public void SetMaxPlayersButtons(int maxPlayers)
	{
	}

	private void UpdateMaxPlayersButtons(IGameOptions opts)
	{
	}

	public void SetImpostorButtons(int numImpostors)
	{
	}

	private void UpdateImpostorsButtons(int numImpostors)
	{
	}

	public void SetMap(int mapId)
	{
	}

	public void SetLanguageFilter(uint keyword)
	{
	}

	private void UpdateLanguageButton(uint flag)
	{
	}

	public void SetGameMode(GameModes mode)
	{
	}
}
