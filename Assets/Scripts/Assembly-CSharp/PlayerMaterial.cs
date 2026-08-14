using UnityEngine;

public static class PlayerMaterial
{
	public struct Properties
	{
		public bool IsLocalPlayer;

		public MaskType MaskType;

		public int MaskLayer;

		public int ColorId;
	}

	public enum MaskType
	{
		None = 0,
		SimpleUI = 1,
		ComplexUI = 2,
		Exile = 3,
		ScrollingUI = 4
	}

	public static readonly int MaskLayer;

	private static readonly int BackColor;

	private static readonly int BodyColor;

	private static readonly int VisorColor;

	public static void SetMaskLayer(Material material, int maskLayer)
	{
		if (material != null)
		{
			material.SetFloat(Shader.PropertyToID("_MaskLayer"), maskLayer);
			material.SetFloat(Shader.PropertyToID("_Stencil"), maskLayer);
		}
	}

	public static void SetMaskLayerBasedOnLocalPlayer(SpriteRenderer sprite, bool isLocalPlayer)
	{
	}

	public static void SetColors(int colorId, Renderer rend)
	{
		if (rend != null)
		{
			SetColors(GetPlayerColor(colorId), rend);
		}
	}

	public static void SetColors(Color color, Renderer rend)
	{
		if (rend != null)
		{
			SetColors(color, rend.material);
		}
	}

	public static void SetColors(int colorId, Material material)
	{
		SetColors(GetPlayerColor(colorId), material);
	}

	public static void SetColors(Color color, Material material)
	{
		if (material == null)
		{
			return;
		}
		material.SetColor(Shader.PropertyToID("_BodyColor"), color);
		material.SetColor(Shader.PropertyToID("_BackColor"), color * 0.55f);
		material.SetColor(Shader.PropertyToID("_VisorColor"), new Color(0.584f, 0.792f, 0.863f, 1f));
	}

	private static Color GetPlayerColor(int colorId)
	{
		Color32[] colors = Palette.PlayerColors;
		if (colors != null && colors.Length > 0)
		{
			return colors[Mathf.Abs(colorId) % colors.Length];
		}
		Color32[] fallback =
		{
			new Color32(198, 17, 17, byte.MaxValue),
			new Color32(19, 46, 210, byte.MaxValue),
			new Color32(17, 128, 45, byte.MaxValue),
			new Color32(238, 84, 187, byte.MaxValue),
			new Color32(240, 125, 13, byte.MaxValue),
			new Color32(246, 246, 87, byte.MaxValue),
			new Color32(63, 71, 78, byte.MaxValue),
			new Color32(215, 225, 241, byte.MaxValue),
			new Color32(107, 47, 188, byte.MaxValue),
			new Color32(113, 73, 30, byte.MaxValue),
			new Color32(56, byte.MaxValue, 221, byte.MaxValue),
			new Color32(80, 240, 57, byte.MaxValue)
		};
		return fallback[Mathf.Abs(colorId) % fallback.Length];
	}
}
