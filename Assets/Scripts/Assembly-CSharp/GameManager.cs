using System;
using System.Collections.Generic;
using Hazel;
using InnerNet;
using UnityEngine;

public abstract class GameManager : InnerNetObject, IDisconnectHandler
{
	[SerializeField]
	private GameSettingsCategoryList gameSettingsList;

	public Dictionary<StringNames, BaseGameSetting> AllGameSettingData;

	[SerializeField]
	protected DeadBody[] deadBodyPrefab;

	protected readonly Logger logger;

	protected readonly List<GameLogicComponent> LogicComponents;

	public GameSettingsCategoryList GameSettingsList => gameSettingsList;

	public static GameManager Instance { get; private set; }

	public bool ShouldCheckForGameEnd { get; set; }

	public bool GameHasStarted { get; set; }

	public LogicGameFlow LogicFlow { get; protected set; }

	public LogicMinigame LogicMinigame { get; protected set; }

	public LogicRoleSelection LogicRoleSelection { get; protected set; }

	public LogicUsables LogicUsables { get; protected set; }

	public LogicOptions LogicOptions { get; protected set; }

	public bool IsPersistent => false;

	public virtual bool RevealTeams => false;

	public override bool IsDirty => false;

	public abstract void InitComponents();

	public abstract PlayerBodyTypes GetBodyType(PlayerControl player);

	public virtual void StartGame()
	{
	}

	public virtual void EndGame()
	{
	}

	public virtual void OnPlayerDeath(PlayerControl player, bool assignGhostRole)
	{
	}

	public virtual void FinishTask(PlayerTask task)
	{
	}

	private void Awake()
	{
		Instance = this;
		BuildSettingsLookup();
		InitComponents();
	}

	public virtual DeadBody GetDeadBody(RoleBehaviour impostorRole)
	{
		return null;
	}

	public bool CheckTaskCompletion()
	{
		return false;
	}

	public bool CheckEndGameViaTasks()
	{
		return false;
	}

	public void ReviveEveryoneFreeplay()
	{
	}

	protected T AddGameLogic<T>(T logic) where T : GameLogicComponent
	{
		return null;
	}

	[Obsolete("We really need to refactor IntroCutscene.cs, which is the file that needed this method to exist at all. Don't use this more.")]
	public GameLogicComponent GetLogicComponent<T>()
	{
		return null;
	}

	protected virtual void FixedUpdate()
	{
	}

	public static void DestroyInstance()
	{
	}

	public override void OnDestroy()
	{
	}

	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason)
	{
	}

	public void HandleDisconnect()
	{
	}

	protected virtual void OnPlayerDisconnect(PlayerControl pc)
	{
	}

	public virtual bool DidHumansWin(GameOverReason reason)
	{
		return false;
	}

	public virtual bool DidImpostorsWin(GameOverReason reason)
	{
		return false;
	}

	public abstract MapOptions GetMapOptions();

	public virtual bool CanReportBodies()
	{
		return false;
	}

	public virtual bool SabotagesEnabled()
	{
		return false;
	}

	public virtual bool ShowCrewmatesKilled()
	{
		return false;
	}

	[Obsolete]
	public virtual bool IsNormal()
	{
		return false;
	}

	[Obsolete]
	public virtual bool IsHideAndSeek()
	{
		return false;
	}

	public virtual void SetSpecialCosmetics(PlayerControl p)
	{
	}

	public BaseGameSetting GetSettingDataByName(StringNames name)
	{
		if (AllGameSettingData == null)
		{
			BuildSettingsLookup();
		}
		BaseGameSetting setting;
		return AllGameSettingData != null && AllGameSettingData.TryGetValue(name, out setting) ? setting : null;
	}

	private void BuildSettingsLookup()
	{
		AllGameSettingData = new Dictionary<StringNames, BaseGameSetting>();
		if (gameSettingsList == null)
		{
			return;
		}
		AddSetting(gameSettingsList.MapNameSetting);
		if (gameSettingsList.OverviewSettings != null)
		{
			for (int i = 0; i < gameSettingsList.OverviewSettings.Count; i++)
			{
				AddSetting(gameSettingsList.OverviewSettings[i]);
			}
		}
		if (gameSettingsList.AllCategories != null)
		{
			for (int i = 0; i < gameSettingsList.AllCategories.Count; i++)
			{
				RulesCategory rulesCategory = gameSettingsList.AllCategories[i];
				if (rulesCategory.AllGameSettings == null)
				{
					continue;
				}
				for (int j = 0; j < rulesCategory.AllGameSettings.Count; j++)
				{
					AddSetting(rulesCategory.AllGameSettings[j]);
				}
			}
		}
	}

	private void AddSetting(BaseGameSetting setting)
	{
		if (setting != null)
		{
			AllGameSettingData[setting.Title] = setting;
		}
	}

	public void RpcEndGame(GameOverReason endReason, bool showAd)
	{
	}

	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	public override void ClearOrDecrementDirt()
	{
	}

	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return false;
	}

	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}
}
