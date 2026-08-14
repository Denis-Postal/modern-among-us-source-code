using Innersloth.Assets;
using UnityEngine;

public class VisorLayer : MonoBehaviour
{
	private const float BackZLayer = -1.5f;

	private const float FrontZLayer = -3f;

	private const float ClimbZOffset = -0.01f;

	[SerializeField]
	private SpriteRenderer Image;

	private VisorData visorData;

	private AddressableAsset<VisorViewData> viewAsset;

	private PlayerMaterial.Properties matProperties;

	private VisorOptions options;

	public float ZIndexSpacing { get; set; }

	private float LocalZFrontLayer => 0f;

	private float LocalZBackLayer => 0f;

	public float DesiredLocalZPosition => 0f;

	public bool IsLoaded => visorData != null;

	public bool Visible
	{
		set
		{
			if (Image != null)
			{
				Image.enabled = value;
			}
		}
	}

	public float Alpha
	{
		set
		{
			if (Image != null)
			{
				Color color = Image.color;
				color.a = value;
				Image.color = color;
			}
		}
	}

	public CosmeticData GetData()
	{
		return visorData;
	}

	public void SetVisor(string visorId, int colorId)
	{
		SetVisor(DestroyableSingleton<HatManager>.Instance.GetVisorById(visorId), colorId);
	}

	public void SetVisor(VisorData data, int color)
	{
		visorData = data;
		PopulateFromViewData();
		SetMaterialColor(color);
		Visible = visorData != null && !visorData.IsEmpty;
	}

	private void PopulateFromViewData()
	{
		VisorViewData viewData = visorData != null ? CosmeticAssetLoader.LoadReference<VisorViewData>(visorData.ViewDataRef, visorData.name) : null;
		if (Image != null)
		{
			Image.sprite = viewData != null ? viewData.IdleFrame : null;
		}
	}

	public void SetOptions(VisorOptions options)
	{
	}

	public void SetFlipX(bool flipX)
	{
		if (Image != null)
		{
			Image.flipX = flipX;
		}
	}

	public void SetLocalPlayer(bool localPlayer)
	{
	}

	public void SetIdleAnim(int colorId)
	{
	}

	public void SetFloorAnim()
	{
	}

	public void SetClimbAnim(PlayerBodyTypes bodyType)
	{
	}

	public void SetMaskType(PlayerMaterial.MaskType maskType)
	{
	}

	public void SetMaterialColor(int color)
	{
		if (Image != null)
		{
			PlayerMaterial.SetColors(color, Image);
		}
	}

	public void SetMaskLayer(int layer)
	{
		if (Image != null)
		{
			PlayerMaterial.SetMaskLayer(Image.material, layer);
		}
	}

	private void UpdateMaterial()
	{
	}

	public void SetVisorColor(Color color)
	{
		if (Image != null)
		{
			Image.color = color;
		}
	}

	private void OnDestroy()
	{
	}

	private void UnloadAsset()
	{
	}
}
