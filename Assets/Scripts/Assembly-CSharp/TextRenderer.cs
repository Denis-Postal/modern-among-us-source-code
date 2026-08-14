using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;

[ExecuteAlways]
[ExecuteInEditMode]
[DisallowMultipleComponent]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class TextRenderer : MonoBehaviour
{
	public enum TextFont
	{
		Normal,
		MainMenu,
		Outline,
		MainMenuOutline
	}

	public enum TextAlignment
	{
		Left,
		Center,
		Right
	}

	[TextArea]
	public string Text = "Text";

	public float Size = 3f;

	public Color Color = UnityEngine.Color.white;

	public TextFont Font = TextFont.Normal;

	public TextAlignment Alignment = TextAlignment.Center;

	public float LineSpacing = 1f;

	public float CharacterSpacing;

	public bool OverrideSorting;

	public int SortingOrder;

	public float SdfCutoff = 0.78f;

	public float SdfSoftness = 0.02f;

	public float OutlineWidth = 0.08f;

	public Color OutlineColor = UnityEngine.Color.black;

	public int MaskLayer;

	public bool UseStencilMask;

	public int VertexCount;

	public string LastStatus;

	private Mesh mesh;

	private MeshFilter meshFilter;

	private MeshRenderer meshRenderer;

	private Material runtimeMaterial;

	private string lastText;

	private float lastSize;

	private Color lastColor;

	private TextFont lastFont;

	private TextAlignment lastAlignment;

	private float lastLineSpacing;

	private float lastCharacterSpacing;

	private int lastSortingOrder;

	private bool lastOverrideSorting;

	private float lastSdfCutoff;

	private float lastSdfSoftness;

	private float lastOutlineWidth;

	private Color lastOutlineColor;

	private int lastMaskLayer;

	private bool lastUseStencilMask;

	private int meshOwnerId;

	private static BitmapFontData normalFont;

	private static BitmapFontData mainMenuFont;

	private void Reset()
	{
		Rebuild(force: true);
	}

	private void Awake()
	{
		Rebuild(force: true);
	}

	private void Start()
	{
		Rebuild(force: true);
	}

	private void OnEnable()
	{
		Rebuild(force: true);
	}

	private void OnValidate()
	{
		Rebuild(force: true);
	}

	private void Update()
	{
		Rebuild(force: false);
	}

	private void LateUpdate()
	{
		Rebuild(force: false);
	}

	private void OnDestroy()
	{
		if (runtimeMaterial)
		{
			DestroyImmediate(runtimeMaterial);
		}
		if (mesh)
		{
			DestroyImmediate(mesh);
		}
	}

	[ContextMenu("Rebuild Text Mesh")]
	public void RebuildTextMesh()
	{
		Rebuild(force: true);
	}

	private void Rebuild(bool force)
	{
		EnsureComponents();
		if (Size <= 0f)
		{
			Size = 3f;
		}
		if (!force && lastText == Text && Mathf.Approximately(lastSize, Size) && lastColor == Color && lastFont == Font && lastAlignment == Alignment && Mathf.Approximately(lastLineSpacing, LineSpacing) && Mathf.Approximately(lastCharacterSpacing, CharacterSpacing) && lastOverrideSorting == OverrideSorting && lastSortingOrder == SortingOrder && Mathf.Approximately(lastSdfCutoff, SdfCutoff) && Mathf.Approximately(lastSdfSoftness, SdfSoftness) && Mathf.Approximately(lastOutlineWidth, OutlineWidth) && lastOutlineColor == OutlineColor && lastMaskLayer == MaskLayer && lastUseStencilMask == UseStencilMask)
		{
			return;
		}
		lastText = Text;
		lastSize = Size;
		lastColor = Color;
		lastFont = Font;
		lastAlignment = Alignment;
		lastLineSpacing = LineSpacing;
		lastCharacterSpacing = CharacterSpacing;
		lastOverrideSorting = OverrideSorting;
		lastSortingOrder = SortingOrder;
		lastSdfCutoff = SdfCutoff;
		lastSdfSoftness = SdfSoftness;
		lastOutlineWidth = OutlineWidth;
		lastOutlineColor = OutlineColor;
		lastMaskLayer = MaskLayer;
		lastUseStencilMask = UseStencilMask;

		LoadFonts();
		BitmapFontData font = (Font == TextFont.MainMenu || Font == TextFont.MainMenuOutline) ? mainMenuFont : normalFont;
		if (font == null || font.Atlas == null)
		{
			ClearMesh("Missing manual font data");
			return;
		}
		meshRenderer.sharedMaterial = GetAtlasMaterial(font.Atlas, SdfCutoff, SdfSoftness, UsesOutline() ? OutlineWidth : 0f, OutlineColor, font.AlphaScale);
		ApplyMaskLayer(meshRenderer.sharedMaterial);
		meshRenderer.sortingOrder = OverrideSorting ? SortingOrder : 0;
		BuildMesh(font);
	}

	private void EnsureComponents()
	{
		if (!meshFilter)
		{
			meshFilter = GetComponent<MeshFilter>();
		}
		if (!meshRenderer)
		{
			meshRenderer = GetComponent<MeshRenderer>();
		}
		if (!mesh)
		{
			mesh = new Mesh();
			mesh.name = "TextRenderer Mesh " + GetInstanceID();
			meshOwnerId = GetInstanceID();
			meshFilter.sharedMesh = mesh;
		}
		else if (meshOwnerId != GetInstanceID() || meshFilter.sharedMesh != mesh)
		{
			mesh = new Mesh();
			mesh.name = "TextRenderer Mesh " + GetInstanceID();
			meshOwnerId = GetInstanceID();
			meshFilter.sharedMesh = mesh;
		}
		meshRenderer.enabled = true;
		meshRenderer.sortingOrder = OverrideSorting ? SortingOrder : 0;

		Behaviour tmp = GetComponent("TextMeshPro") as Behaviour;
		if (tmp)
		{
			tmp.enabled = false;
		}
	}

	private void BuildMesh(BitmapFontData font)
	{
		mesh.Clear();
		string text = Text ?? string.Empty;
		if (text.Length == 0)
		{
			ClearMesh("Empty text");
			return;
		}

		float scale = Size / Mathf.Max(1f, font.PointSize);
		float lineHeight = Mathf.Max(1f, font.LineHeight) * scale * Mathf.Max(0.01f, LineSpacing);
		List<float> lineWidths = MeasureLines(font, text, scale);
		List<Vector3> verts = new List<Vector3>(text.Length * 4);
		List<Vector2> uvs = new List<Vector2>(text.Length * 4);
		List<Color> colors = new List<Color>(text.Length * 4);
		List<int> tris = new List<int>(text.Length * 6);
		float outlinePixels = UsesOutline() ? (Mathf.Clamp(OutlineWidth, 0f, 0.08f) * 16f) : 0f;
		float glyphPaddingPixels = UsesOutline() ? (Mathf.Ceil(outlinePixels) + 1f) : 0f;

		int lineIndex = 0;
		float x = GetLineStartX(lineWidths, lineIndex);
		float y = 0f;
		for (int i = 0; i < text.Length; i++)
		{
			char c = text[i];
			if (c == '\r')
			{
				continue;
			}
			if (c == '\n')
			{
				lineIndex++;
				x = GetLineStartX(lineWidths, lineIndex);
				y -= lineHeight;
				continue;
			}
			if (!font.TryGetGlyph(c, out BitmapGlyph glyph))
			{
				x += font.SpaceAdvance * scale;
				continue;
			}
			if (c != ' ' && glyph.Width > 0f && glyph.Height > 0f)
			{
				AddGlyph(font, glyph, x, y, scale, glyphPaddingPixels, Color, verts, uvs, colors, tris);
			}
			x += glyph.Advance * scale + CharacterSpacing;
		}

		mesh.SetVertices(verts);
		mesh.SetUVs(0, uvs);
		mesh.SetColors(colors);
		mesh.SetTriangles(tris, 0);
		mesh.RecalculateBounds();
		VertexCount = verts.Count;
		LastStatus = "OK manual glyphs";
	}

	private List<float> MeasureLines(BitmapFontData font, string text, float scale)
	{
		List<float> widths = new List<float>();
		float width = 0f;
		for (int i = 0; i < text.Length; i++)
		{
			char c = text[i];
			if (c == '\r')
			{
				continue;
			}
			if (c == '\n')
			{
				widths.Add(width);
				width = 0f;
				continue;
			}
			if (font.TryGetGlyph(c, out BitmapGlyph glyph))
			{
				width += glyph.Advance * scale + CharacterSpacing;
			}
			else
			{
				width += font.SpaceAdvance * scale + CharacterSpacing;
			}
		}
		widths.Add(width);
		return widths;
	}

	private float GetLineStartX(List<float> lineWidths, int lineIndex)
	{
		if (lineIndex < 0 || lineIndex >= lineWidths.Count)
		{
			return 0f;
		}
		if (Alignment == TextAlignment.Right)
		{
			return -lineWidths[lineIndex];
		}
		if (Alignment == TextAlignment.Center)
		{
			return lineWidths[lineIndex] * -0.5f;
		}
		return 0f;
	}

	private void AddGlyph(BitmapFontData font, BitmapGlyph glyph, float x, float y, float scale, float paddingPixels, Color color, List<Vector3> verts, List<Vector2> uvs, List<Color> colors, List<int> tris)
	{
		float padding = paddingPixels * scale;
		float left = x + glyph.BearingX * scale - padding;
		float right = left + (glyph.Width + paddingPixels * 2f) * scale;
		float top = y + glyph.BearingY * scale + padding;
		float bottom = top - (glyph.Height + paddingPixels * 2f) * scale;
		int start = verts.Count;
		verts.Add(new Vector3(left, bottom, 0f));
		verts.Add(new Vector3(left, top, 0f));
		verts.Add(new Vector3(right, top, 0f));
		verts.Add(new Vector3(right, bottom, 0f));

		float invW = 1f / font.Atlas.width;
		float invH = 1f / font.Atlas.height;
		float u0 = Mathf.Clamp(glyph.X - paddingPixels, 0f, font.Atlas.width) * invW;
		float v0 = Mathf.Clamp(glyph.Y - paddingPixels, 0f, font.Atlas.height) * invH;
		float u1 = Mathf.Clamp(glyph.X + glyph.Width + paddingPixels, 0f, font.Atlas.width) * invW;
		float v1 = Mathf.Clamp(glyph.Y + glyph.Height + paddingPixels, 0f, font.Atlas.height) * invH;
		uvs.Add(new Vector2(u0, v0));
		uvs.Add(new Vector2(u0, v1));
		uvs.Add(new Vector2(u1, v1));
		uvs.Add(new Vector2(u1, v0));

		colors.Add(color);
		colors.Add(color);
		colors.Add(color);
		colors.Add(color);
		tris.Add(start);
		tris.Add(start + 1);
		tris.Add(start + 2);
		tris.Add(start);
		tris.Add(start + 2);
		tris.Add(start + 3);
	}

	private void ClearMesh(string status)
	{
		if (mesh)
		{
			mesh.Clear();
		}
		VertexCount = 0;
		LastStatus = status;
	}

	private bool UsesOutline()
	{
		return Font == TextFont.Outline || Font == TextFont.MainMenuOutline;
	}

	private Material GetAtlasMaterial(Texture atlas, float cutoff, float softness, float outlineWidth, Color outlineColor, float alphaScale)
	{
		if (!runtimeMaterial)
		{
			Shader shader = Shader.Find("Unlit/TextRendererSDF");
			if (!shader)
			{
				shader = Shader.Find("Sprites/Default");
			}
			runtimeMaterial = new Material(shader);
			runtimeMaterial.name = "TextRenderer Manual Atlas";
			runtimeMaterial.renderQueue = 3000;
		}
		if (runtimeMaterial.HasProperty("_MainTex"))
		{
			runtimeMaterial.SetTexture("_MainTex", atlas);
		}
		if (runtimeMaterial.HasProperty("_Color"))
		{
			runtimeMaterial.SetColor("_Color", UnityEngine.Color.white);
		}
		if (runtimeMaterial.HasProperty("_Cutoff"))
		{
			runtimeMaterial.SetFloat("_Cutoff", Mathf.Clamp01(cutoff));
		}
		if (runtimeMaterial.HasProperty("_Softness"))
		{
			runtimeMaterial.SetFloat("_Softness", Mathf.Clamp(softness, 0.001f, 0.03f));
		}
		if (runtimeMaterial.HasProperty("_Invert"))
		{
			runtimeMaterial.SetFloat("_Invert", 0f);
		}
		if (runtimeMaterial.HasProperty("_OutlineWidth"))
		{
			runtimeMaterial.SetFloat("_OutlineWidth", Mathf.Clamp(outlineWidth, 0f, 0.08f));
		}
		if (runtimeMaterial.HasProperty("_OutlineColor"))
		{
			runtimeMaterial.SetColor("_OutlineColor", outlineColor);
		}
		if (runtimeMaterial.HasProperty("_AlphaScale"))
		{
			runtimeMaterial.SetFloat("_AlphaScale", Mathf.Max(1f, alphaScale));
		}
		if (runtimeMaterial.HasProperty("_SolidFill"))
		{
			runtimeMaterial.SetFloat("_SolidFill", 1f);
		}
		return runtimeMaterial;
	}

	public void SetMaskLayer(int maskLayer)
	{
		MaskLayer = maskLayer;
		UseStencilMask = maskLayer > 0;
		Rebuild(force: true);
	}

	private void ApplyMaskLayer(Material material)
	{
		if (material == null)
		{
			return;
		}
		if (material.HasProperty("_Stencil"))
		{
			material.SetFloat("_Stencil", UseStencilMask ? MaskLayer : 0);
		}
		if (material.HasProperty("_StencilComp"))
		{
			material.SetFloat("_StencilComp", UseStencilMask ? 3 : 8);
		}
		if (material.HasProperty("_StencilOp"))
		{
			material.SetFloat("_StencilOp", 0);
		}
		if (material.HasProperty("_StencilReadMask"))
		{
			material.SetFloat("_StencilReadMask", 255);
		}
		if (material.HasProperty("_StencilWriteMask"))
		{
			material.SetFloat("_StencilWriteMask", 255);
		}
		if (material.HasProperty("_ColorMask"))
		{
			material.SetFloat("_ColorMask", 15);
		}
	}

	private static void LoadFonts()
	{
		if (normalFont == null)
		{
			normalFont = LoadFont("LiberationSans SDF", "fonts & materials/LiberationSans SDF Atlas");
		}
		if (mainMenuFont == null)
		{
			mainMenuFont = LoadFont("Brook SDF", "fonts & materials/Brook SDF Atlas");
		}
	}

	private static BitmapFontData LoadFont(string assetName, string atlasResourcePath)
	{
		Texture2D atlas = Resources.Load<Texture2D>(atlasResourcePath);
		string path = Path.Combine(Application.dataPath, "Resources/fonts & materials/" + assetName + ".asset");
		if (!File.Exists(path))
		{
			return null;
		}
		try
		{
			return BitmapFontData.Parse(File.ReadAllLines(path), atlas);
		}
		catch (Exception ex)
		{
			Debug.LogWarning("TextRenderer failed to parse " + assetName + ": " + ex.Message);
			return null;
		}
	}

	private sealed class BitmapFontData
	{
		public Texture2D Atlas;

		public float PointSize = 64f;

		public float LineHeight = 72f;

		public float SpaceAdvance = 20f;

		public float AlphaScale = 1.75f;

		private readonly Dictionary<int, BitmapGlyph> glyphs = new Dictionary<int, BitmapGlyph>();

		private readonly Dictionary<char, BitmapGlyph> characters = new Dictionary<char, BitmapGlyph>();

		public bool TryGetGlyph(char c, out BitmapGlyph glyph)
		{
			return characters.TryGetValue(c, out glyph);
		}

		public static BitmapFontData Parse(string[] lines, Texture2D atlas)
		{
			BitmapFontData data = new BitmapFontData();
			data.Atlas = atlas;
			if (atlas != null && atlas.name.IndexOf("Brook", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				data.AlphaScale = 1.85f;
			}
			bool inGlyphTable = false;
			bool inCharacterTable = false;
			BitmapGlyph currentGlyph = null;
			int currentUnicode = -1;
			int currentGlyphIndex = -1;

			for (int i = 0; i < lines.Length; i++)
			{
				string line = lines[i].Trim();
				if (line == "m_GlyphTable:")
				{
					inGlyphTable = true;
					inCharacterTable = false;
					continue;
				}
				if (line == "m_CharacterTable:")
				{
					if (currentGlyph != null)
					{
						data.glyphs[currentGlyph.Index] = currentGlyph;
					}
					currentGlyph = null;
					inGlyphTable = false;
					inCharacterTable = true;
					continue;
				}
				if (line.StartsWith("m_PointSize:"))
				{
					data.PointSize = ParseFloatValue(line);
					continue;
				}
				if (line.StartsWith("m_LineHeight:"))
				{
					data.LineHeight = ParseFloatValue(line);
					continue;
				}

				if (inGlyphTable)
				{
					if (line.StartsWith("- m_Index:"))
					{
						if (currentGlyph != null)
						{
							data.glyphs[currentGlyph.Index] = currentGlyph;
						}
						currentGlyph = new BitmapGlyph();
						currentGlyph.Index = ParseIntValue(line);
						continue;
					}
					if (currentGlyph == null)
					{
						continue;
					}
					if (line.StartsWith("m_Width:"))
					{
						float value = ParseFloatValue(line);
						if (currentGlyph.Width <= 0f)
						{
							currentGlyph.Width = value;
						}
						else
						{
							currentGlyph.RectWidth = value;
						}
						continue;
					}
					if (line.StartsWith("m_Height:"))
					{
						float value = ParseFloatValue(line);
						if (currentGlyph.Height <= 0f)
						{
							currentGlyph.Height = value;
						}
						else
						{
							currentGlyph.RectHeight = value;
						}
						continue;
					}
					if (line.StartsWith("m_HorizontalBearingX:"))
					{
						currentGlyph.BearingX = ParseFloatValue(line);
						continue;
					}
					if (line.StartsWith("m_HorizontalBearingY:"))
					{
						currentGlyph.BearingY = ParseFloatValue(line);
						continue;
					}
					if (line.StartsWith("m_HorizontalAdvance:"))
					{
						currentGlyph.Advance = ParseFloatValue(line);
						continue;
					}
					if (line.StartsWith("m_X:"))
					{
						currentGlyph.X = ParseFloatValue(line);
						continue;
					}
					if (line.StartsWith("m_Y:"))
					{
						currentGlyph.Y = ParseFloatValue(line);
						continue;
					}
				}
				else if (inCharacterTable)
				{
					if (line.StartsWith("- m_ElementType:"))
					{
						AddCharacter(data, currentUnicode, currentGlyphIndex);
						currentUnicode = -1;
						currentGlyphIndex = -1;
						continue;
					}
					if (line.StartsWith("m_Unicode:"))
					{
						currentUnicode = ParseIntValue(line);
						continue;
					}
					if (line.StartsWith("m_GlyphIndex:"))
					{
						currentGlyphIndex = ParseIntValue(line);
					}
				}
			}

			if (currentGlyph != null)
			{
				data.glyphs[currentGlyph.Index] = currentGlyph;
			}
			AddCharacter(data, currentUnicode, currentGlyphIndex);
			if (data.characters.TryGetValue(' ', out BitmapGlyph space))
			{
				data.SpaceAdvance = Mathf.Max(1f, space.Advance);
			}
			return data;
		}

		private static void AddCharacter(BitmapFontData data, int unicode, int glyphIndex)
		{
			if (unicode < 0 || glyphIndex < 0)
			{
				return;
			}
			if (data.glyphs.TryGetValue(glyphIndex, out BitmapGlyph glyph))
			{
				data.characters[(char)unicode] = glyph;
			}
		}

		private static int ParseIntValue(string line)
		{
			string value = line.Substring(line.IndexOf(':') + 1).Trim();
			return int.Parse(value, CultureInfo.InvariantCulture);
		}

		private static float ParseFloatValue(string line)
		{
			string value = line.Substring(line.IndexOf(':') + 1).Trim();
			return float.Parse(value, CultureInfo.InvariantCulture);
		}
	}

	private sealed class BitmapGlyph
	{
		public int Index;

		public float Width;

		public float Height;

		public float BearingX;

		public float BearingY;

		public float Advance;

		public float X;

		public float Y;

		public float RectWidth;

		public float RectHeight;
	}
}
