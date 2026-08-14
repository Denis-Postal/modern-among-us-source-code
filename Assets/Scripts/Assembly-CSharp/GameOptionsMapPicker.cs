using System.Collections.Generic;
using AmongUs.GameOptions;
using TMPro;
using UnityEngine;

public class GameOptionsMapPicker : OptionBehaviour
{
	[SerializeField]
	protected List<MapIconByName> AllMapIcons;

	[SerializeField]
	protected float StartPosX;

	[SerializeField]
	protected float SpacingX;

	[SerializeField]
	protected float MapButtonY;

	[SerializeField]
	private SpriteRenderer MapImage;

	[SerializeField]
	private SpriteRenderer MapName;

	[SerializeField]
	protected MapSelectButton MapButtonOrigin;

	[SerializeField]
	protected Collider2D ButtonClickMask;

	[SerializeField]
	protected TextMeshPro Labeltext;

	protected List<MapSelectButton> mapButtons;

	protected MapSelectButton selectedButton;

	protected int selectedMapId;

	private int oldValue;

	protected ByteOptionNames optionName;

	public List<MapSelectButton> MapButtons => mapButtons;

	public override void SetUpFromData(BaseGameSetting data, int maskLayer)
	{
		base.SetUpFromData(data, maskLayer);
		MapSelectionGameSetting mapSelectionGameSetting = data as MapSelectionGameSetting;
		optionName = mapSelectionGameSetting != null ? mapSelectionGameSetting.OptionName : ByteOptionNames.MapId;
		if ((bool)Labeltext && data != null)
		{
			Labeltext.gameObject.SetActive(true);
			Labeltext.text = DestroyableSingleton<TranslationController>.InstanceExists ? DestroyableSingleton<TranslationController>.Instance.GetString(data.Title) : data.Title.ToString();
			Labeltext.gameObject.layer = maskLayer;
		}
		Initialize(maskLayer);
	}

	public virtual void Initialize(int maskLayer)
	{
		SetupMapButtons(maskLayer);
		Initialize();
	}

	protected void SetupMapButtons(int maskLayer)
	{
		if (mapButtons != null && mapButtons.Count > 0 && HasLiveButtons())
		{
			for (int i = 0; i < mapButtons.Count; i++)
			{
				if ((bool)mapButtons[i])
				{
					mapButtons[i].gameObject.SetActive(true);
					mapButtons[i].SetImage(GetMapIcon(mapButtons[i].MapID), maskLayer);
					SetupButtonClick(mapButtons[i]);
				}
			}
			return;
		}
		mapButtons = new List<MapSelectButton>();
		if (AllMapIcons == null || MapButtonOrigin == null)
		{
			return;
		}
		for (int j = 0; j < AllMapIcons.Count; j++)
		{
			MapIconByName mapIconByName = AllMapIcons[j];
			if (mapIconByName == null)
			{
				continue;
			}
			MapSelectButton mapSelectButton = j == 0 ? MapButtonOrigin : Object.Instantiate(MapButtonOrigin, MapButtonOrigin.transform.parent);
			mapSelectButton.gameObject.SetActive(true);
			mapSelectButton.MapID = (int)mapIconByName.Name;
			mapSelectButton.transform.localPosition = new Vector3(StartPosX + SpacingX * j, MapButtonY, mapSelectButton.transform.localPosition.z);
			mapSelectButton.SetImage(mapIconByName.MapIcon, maskLayer);
			SetupButtonClick(mapSelectButton);
			mapButtons.Add(mapSelectButton);
		}
	}

	public void ClearMapButtons()
	{
		if (mapButtons != null)
		{
			for (int i = 0; i < mapButtons.Count; i++)
			{
				MapSelectButton mapSelectButton = mapButtons[i];
				if (mapSelectButton == null)
				{
					continue;
				}
				if (mapSelectButton == MapButtonOrigin)
				{
					mapSelectButton.gameObject.SetActive(false);
				}
				else
				{
					mapSelectButton.gameObject.SetActive(false);
					Object.Destroy(mapSelectButton.gameObject);
				}
			}
			mapButtons.Clear();
		}
		mapButtons = null;
		selectedButton = null;
		HidePreview();
	}

	public void SetInactiveButton(bool isEnabled)
	{
		if (selectedButton != null && selectedButton.Button != null)
		{
			selectedButton.Button.enabled = isEnabled;
		}
	}

	private void FixedUpdate()
	{
		IGameOptions gameOptions = GameOptionsManager.Instance != null ? GameOptionsManager.Instance.GameHostOptions : null;
		int num = gameOptions != null ? gameOptions.GetByte(optionName) : selectedMapId;
		if (oldValue != num)
		{
			SelectMap(num);
		}
	}

	public void SelectMap(int mapId)
	{
		selectedMapId = mapId;
		oldValue = mapId;
		if (mapButtons != null)
		{
			for (int i = 0; i < mapButtons.Count; i++)
			{
				MapSelectButton mapSelectButton = mapButtons[i];
				if (!(mapSelectButton == null))
				{
					bool flag = mapSelectButton.MapID == mapId;
					if (flag)
					{
						selectedButton = mapSelectButton;
					}
					SetButtonSelected(mapSelectButton, flag);
				}
			}
		}
		SelectMap(GetMapInfo(mapId));
		OnValueChanged?.Invoke(this);
	}

	public void SelectMap(MapIconByName mapInfo)
	{
		if (mapInfo == null)
		{
			return;
		}
		selectedMapId = (int)mapInfo.Name;
		oldValue = selectedMapId;
		if ((bool)MapImage)
		{
			MapImage.gameObject.SetActive(true);
			MapImage.sprite = mapInfo.MapImage;
		}
		if ((bool)MapName)
		{
			MapName.gameObject.SetActive(true);
			MapName.sprite = mapInfo.NameImage;
		}
	}

	public override float GetFloat()
	{
		return selectedMapId;
	}

	public override int GetInt()
	{
		return selectedMapId;
	}

	protected virtual void UpdateValue()
	{
		IGameOptions gameOptions = GameOptionsManager.Instance != null ? GameOptionsManager.Instance.GameHostOptions : null;
		int mapId = gameOptions != null ? gameOptions.GetByte(optionName) : 0;
		SelectMap(mapId);
	}

	public override void Initialize()
	{
		UpdateValue();
	}

	private void SetupButtonClick(MapSelectButton mapSelectButton)
	{
		if (mapSelectButton == null || mapSelectButton.Button == null)
		{
			return;
		}
		int id = mapSelectButton.MapID;
		mapSelectButton.Button.OnClick.RemoveAllListeners();
		mapSelectButton.Button.OnClick.AddListener(delegate
		{
			SelectMap(id);
		});
		if ((bool)ButtonClickMask)
		{
			mapSelectButton.Button.ClickMask = ButtonClickMask;
		}
	}

	private MapIconByName GetMapInfo(int mapId)
	{
		if (AllMapIcons == null)
		{
			return null;
		}
		for (int i = 0; i < AllMapIcons.Count; i++)
		{
			if (AllMapIcons[i] != null && (int)AllMapIcons[i].Name == mapId)
			{
				return AllMapIcons[i];
			}
		}
		return AllMapIcons.Count > 0 ? AllMapIcons[0] : null;
	}

	private Sprite GetMapIcon(int mapId)
	{
		MapIconByName mapInfo = GetMapInfo(mapId);
		return mapInfo != null ? mapInfo.MapIcon : null;
	}

	private void SetButtonSelected(MapSelectButton mapSelectButton, bool selected)
	{
		SpriteRenderer[] componentsInChildren = mapSelectButton.GetComponentsInChildren<SpriteRenderer>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if ((bool)componentsInChildren[i])
			{
				componentsInChildren[i].color = selected ? Color.white : new Color(1f, 1f, 1f, 0.55f);
			}
		}
	}

	private bool HasLiveButtons()
	{
		for (int i = 0; i < mapButtons.Count; i++)
		{
			if ((bool)mapButtons[i])
			{
				return true;
			}
		}
		return false;
	}

	private void HidePreview()
	{
		if ((bool)MapImage)
		{
			MapImage.gameObject.SetActive(false);
		}
		if ((bool)MapName)
		{
			MapName.gameObject.SetActive(false);
		}
		if ((bool)Labeltext)
		{
			Labeltext.gameObject.SetActive(false);
		}
	}
}
