using TMPro;
using UnityEngine;

[ExecuteAlways]
[DisallowMultipleComponent]
public class TMPTextRendererBridge : MonoBehaviour
{
	public TMP_Text Source;

	public TextRenderer Target;

	public TextRenderer.TextFont Font = TextRenderer.TextFont.MainMenuOutline;

	public float SizeMultiplier = 1f;

	public float CharacterSpacing;

	public int MaskLayer;

	public bool UseStencilMask;

	private string lastText;

	private Color lastColor;

	private float lastSize;

	private TextAlignmentOptions lastAlignment;

	private int lastMaskLayer;

	private bool lastUseStencilMask;

	private void Awake()
	{
		Ensure();
		Sync(force: true);
	}

	private void OnEnable()
	{
		Ensure();
		Sync(force: true);
	}

	private void OnValidate()
	{
		Ensure();
		Sync(force: true);
	}

	private void LateUpdate()
	{
		Sync(force: false);
	}

	public void ForceSync()
	{
		Ensure();
		Sync(force: true);
	}

	public static void InstallAll(GameObject root, TextRenderer.TextFont font, float sizeMultiplier, float characterSpacing, bool masked, int maskLayer)
	{
		if (root == null)
		{
			return;
		}
		TMP_Text[] componentsInChildren = root.GetComponentsInChildren<TMP_Text>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			TMP_Text source = componentsInChildren[i];
			if (source == null)
			{
				continue;
			}
			TMPTextRendererBridge bridge = source.GetComponent<TMPTextRendererBridge>();
			if (bridge == null)
			{
				bridge = source.gameObject.AddComponent<TMPTextRendererBridge>();
			}
			bridge.Source = source;
			bridge.Font = font;
			bridge.SizeMultiplier = sizeMultiplier;
			bridge.CharacterSpacing = characterSpacing;
			if (masked)
			{
				bridge.MaskLayer = maskLayer;
				bridge.UseStencilMask = true;
			}
			else if (!bridge.UseStencilMask)
			{
				bridge.MaskLayer = 0;
				bridge.UseStencilMask = false;
			}
			bridge.ForceSync();
		}
	}

	private void Ensure()
	{
		if (!Source)
		{
			Source = GetComponent<TMP_Text>();
		}
		if (!Target)
		{
			Target = GetComponent<TextRenderer>();
			if (!Target)
			{
				Target = gameObject.AddComponent<TextRenderer>();
			}
		}
		if (Source)
		{
			Source.enabled = false;
		}
	}

	private void Sync(bool force)
	{
		if (!Source || !Target)
		{
			return;
		}
		string text = Source.text ?? string.Empty;
		Color color = Source.color;
		float size = Mathf.Max(0.1f, Source.fontSize * SizeMultiplier);
		if (!force && lastText == text && lastColor == color && Mathf.Approximately(lastSize, size) && lastAlignment == Source.alignment && lastMaskLayer == MaskLayer && lastUseStencilMask == UseStencilMask)
		{
			return;
		}
		lastText = text;
		lastColor = color;
		lastSize = size;
		lastAlignment = Source.alignment;
		lastMaskLayer = MaskLayer;
		lastUseStencilMask = UseStencilMask;
		Target.Text = text;
		Target.Color = color;
		Target.Size = size;
		Target.Font = Font;
		Target.Alignment = ConvertAlignment(Source.alignment);
		Target.CharacterSpacing = CharacterSpacing;
		Target.OutlineColor = Color.black;
		Target.OutlineWidth = Font == TextRenderer.TextFont.Outline || Font == TextRenderer.TextFont.MainMenuOutline ? 0.08f : 0f;
		Target.SdfCutoff = 0.52f;
		Target.SdfSoftness = 0.02f;
		Target.MaskLayer = MaskLayer;
		Target.UseStencilMask = UseStencilMask;
		Target.RebuildTextMesh();
	}

	private static TextRenderer.TextAlignment ConvertAlignment(TextAlignmentOptions alignment)
	{
		if ((alignment & TextAlignmentOptions.Right) == TextAlignmentOptions.Right)
		{
			return TextRenderer.TextAlignment.Right;
		}
		if ((alignment & TextAlignmentOptions.Left) == TextAlignmentOptions.Left)
		{
			return TextRenderer.TextAlignment.Left;
		}
		return TextRenderer.TextAlignment.Center;
	}
}
