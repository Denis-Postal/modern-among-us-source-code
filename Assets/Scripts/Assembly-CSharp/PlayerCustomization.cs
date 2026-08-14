using UnityEngine;

public class PlayerCustomization
{
	private const string ColorKey = "PlayerCustomization.Color";

	private const string HatKey = "PlayerCustomization.Hat";

	private const string SkinKey = "PlayerCustomization.Skin";

	private const string VisorKey = "PlayerCustomization.Visor";

	private const string PetKey = "PlayerCustomization.Pet";

	private const string NameplateKey = "PlayerCustomization.Nameplate";

	public static int ColorId
	{
		get
		{
			return PlayerPrefs.GetInt(ColorKey, 0);
		}
	}

	public static string HatId => PlayerPrefs.GetString(HatKey, HatData.EmptyId);

	public static string SkinId => PlayerPrefs.GetString(SkinKey, SkinData.EmptyId);

	public static string VisorId => PlayerPrefs.GetString(VisorKey, VisorData.EmptyId);

	public static string PetId => PlayerPrefs.GetString(PetKey, PetData.EmptyId);

	public static string NameplateId => PlayerPrefs.GetString(NameplateKey, NamePlateData.EmptyId);

	public static void Equip(CosmeticData cosmetic)
	{
		if (cosmetic is HatData hat)
		{
			EquipHat(hat);
		}
		else if (cosmetic is SkinData skin)
		{
			EquipSkin(skin);
		}
		else if (cosmetic is VisorData visor)
		{
			EquipVisor(visor);
		}
		else if (cosmetic is PetData pet)
		{
			EquipPet(pet);
		}
		else if (cosmetic is NamePlateData nameplate)
		{
			EquipNameplate(nameplate);
		}
	}

	public static void EquipColor(int colorId)
	{
		PlayerPrefs.SetInt(ColorKey, colorId);
		PlayerPrefs.Save();
		if ((bool)PlayerControl.LocalPlayer)
		{
			PlayerControl.LocalPlayer.RpcSetColor((byte)colorId);
		}
	}

	public static void EquipPet(PetData pet)
	{
		string id = GetCosmeticId(pet, PetData.EmptyId);
		PlayerPrefs.SetString(PetKey, id);
		PlayerPrefs.Save();
		if ((bool)PlayerControl.LocalPlayer)
		{
			PlayerControl.LocalPlayer.RpcSetPet(id);
		}
	}

	public static void EquipSkin(SkinData skin)
	{
		string id = GetCosmeticId(skin, SkinData.EmptyId);
		PlayerPrefs.SetString(SkinKey, id);
		PlayerPrefs.Save();
		if ((bool)PlayerControl.LocalPlayer)
		{
			PlayerControl.LocalPlayer.RpcSetSkin(id);
		}
	}

	public static void EquipHat(HatData hat)
	{
		string id = GetCosmeticId(hat, HatData.EmptyId);
		PlayerPrefs.SetString(HatKey, id);
		PlayerPrefs.Save();
		if ((bool)PlayerControl.LocalPlayer)
		{
			PlayerControl.LocalPlayer.RpcSetHat(id);
		}
	}

	public static void EquipNameplate(NamePlateData nameplate)
	{
		string id = GetCosmeticId(nameplate, NamePlateData.EmptyId);
		PlayerPrefs.SetString(NameplateKey, id);
		PlayerPrefs.Save();
		if ((bool)PlayerControl.LocalPlayer)
		{
			PlayerControl.LocalPlayer.RpcSetNamePlate(id);
		}
	}

	public static void EquipVisor(VisorData visor)
	{
		string id = GetCosmeticId(visor, VisorData.EmptyId);
		PlayerPrefs.SetString(VisorKey, id);
		PlayerPrefs.Save();
		if ((bool)PlayerControl.LocalPlayer)
		{
			PlayerControl.LocalPlayer.RpcSetVisor(id);
		}
	}

	public static bool IsEquipped(CosmeticData cosmetic)
	{
		string id = GetCosmeticId(cosmetic, string.Empty);
		if (cosmetic is HatData)
		{
			return id == HatId;
		}
		if (cosmetic is SkinData)
		{
			return id == SkinId;
		}
		if (cosmetic is VisorData)
		{
			return id == VisorId;
		}
		if (cosmetic is PetData)
		{
			return id == PetId;
		}
		if (cosmetic is NamePlateData)
		{
			return id == NameplateId;
		}
		return false;
	}

	public static void TryUnlockAll()
	{
	}

	public static string GetCosmeticId(CosmeticData cosmetic, string fallback)
	{
		if (cosmetic == null)
		{
			return fallback;
		}
		if (!string.IsNullOrEmpty(cosmetic.ProductId))
		{
			return cosmetic.ProductId;
		}
		return string.IsNullOrEmpty(cosmetic.name) ? fallback : cosmetic.name;
	}
}
