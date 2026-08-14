using System;
using AmongUs.GameOptions;
using Hazel;

public class GameOptionsManager
{
	private readonly GameOptionsFactory gameOptionsFactory;

	private readonly ILogger logger;

	private GameModes currentGameMode;

	private IGameOptions currentGameOptions;

	private NormalGameOptionsV10 currentNormalGameOptions;

	private HideNSeekGameOptionsV10 currentHideNSeekGameOptions;

	private IGameOptions currentHostOptions;

	private NormalGameOptionsV10 normalGameHostOptions;

	private HideNSeekGameOptionsV10 hideNSeekGameHostOptions;

	private IGameOptions currentSearchOptions;

	private NormalGameOptionsV10 normalGameSearchOptions;

	private HideNSeekGameOptionsV10 hideNSeekGameSearchOptions;

	public static GameOptionsManager Instance { get; private set; }

	public IGameOptions CurrentGameOptions
	{
		get
		{
			if (currentGameOptions == null)
			{
				Initialize();
			}
			return currentGameOptions;
		}
		set
		{
			currentGameOptions = value;
		}
	}

	public IGameOptions GameHostOptions
	{
		get
		{
			if (currentHostOptions == null)
			{
				Initialize();
			}
			return currentHostOptions;
		}
		set
		{
			currentHostOptions = value;
			if (value is NormalGameOptionsV10)
			{
				normalGameHostOptions = (NormalGameOptionsV10)value;
			}
			else if (value is HideNSeekGameOptionsV10)
			{
				hideNSeekGameHostOptions = (HideNSeekGameOptionsV10)value;
			}
		}
	}

	public IGameOptions GameSearchOptions
	{
		get
		{
			if (currentSearchOptions == null)
			{
				Initialize();
			}
			return currentSearchOptions;
		}
		set
		{
			currentSearchOptions = value;
		}
	}

	public bool HasOptions => CurrentGameOptions != null;

	public Type GetGameOptions()
	{
		return CurrentGameOptions != null ? CurrentGameOptions.GetType() : typeof(NormalGameOptionsV10);
	}

	public GameOptionsManager(ILogger logger)
	{
		this.logger = logger;
		gameOptionsFactory = new GameOptionsFactory(logger);
		Instance = this;
		Initialize();
	}

	public void Initialize()
	{
		LoadOrCreateNormalGameHostOptions();
		LoadOrCreateNormalGameSearchOptions();
		currentGameMode = GameModes.Normal;
		currentHostOptions = normalGameHostOptions;
		currentSearchOptions = normalGameSearchOptions;
		currentGameOptions = currentHostOptions;
	}

	public void SwitchGameMode(GameModes gameMode)
	{
		currentGameMode = gameMode;
		if (gameMode == GameModes.HideNSeek)
		{
			LoadOrCreateHideNSeekGameHostOptions();
			LoadOrCreateHideNSeekGameSearchOptions();
			currentHostOptions = hideNSeekGameHostOptions;
			currentSearchOptions = hideNSeekGameSearchOptions;
		}
		else
		{
			LoadOrCreateNormalGameHostOptions();
			LoadOrCreateNormalGameSearchOptions();
			currentHostOptions = normalGameHostOptions;
			currentSearchOptions = normalGameSearchOptions;
		}
		currentGameOptions = currentHostOptions;
	}

	private void LoadOrCreateNormalGameHostOptions()
	{
		if (normalGameHostOptions == null)
		{
			normalGameHostOptions = new NormalGameOptionsV10(logger);
		}
	}

	private void LoadOrCreateHideNSeekGameHostOptions()
	{
		if (hideNSeekGameHostOptions == null)
		{
			hideNSeekGameHostOptions = new HideNSeekGameOptionsV10(logger);
		}
	}

	private void LoadOrCreateNormalGameSearchOptions()
	{
		if (normalGameSearchOptions == null)
		{
			normalGameSearchOptions = new NormalGameOptionsV10(logger);
		}
	}

	private void LoadOrCreateHideNSeekGameSearchOptions()
	{
		if (hideNSeekGameSearchOptions == null)
		{
			hideNSeekGameSearchOptions = new HideNSeekGameOptionsV10(logger);
		}
	}

	private bool TryLoadLegacyOptionsFile(string filename, out IGameOptions legacyGameOptions)
	{
		legacyGameOptions = null;
		return false;
	}

	private void SaveNormalHostOptions()
	{
	}

	private void SaveNormalSearchOptions()
	{
	}

	private void SaveHideNSeekHostOptions()
	{
	}

	private void SaveHideNSeekSearchOptions()
	{
	}

	private NormalGameOptionsV10 MigrateNormalGameOptions(IGameOptions gameOptions)
	{
		return null;
	}

	private HideNSeekGameOptionsV10 MigrateHideNSeekGameOptions(IGameOptions gameOptions)
	{
		return null;
	}
}
