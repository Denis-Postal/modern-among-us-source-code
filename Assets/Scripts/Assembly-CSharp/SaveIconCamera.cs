using UnityEngine;

[RequireComponent(typeof(Camera))]
public class SaveIconCamera : DestroyableSingleton<SaveIconCamera>
{
	private Camera cam;

	public ConditionalRenderTexture platformRenderTextures;

	private RenderTexture targetTexture;

	public PlayerControl saveIconDummy;

	public LayerMask layerToRenderWith;

	private int layerIndex;

	private static object lockObject;

	private static bool needsRender;

	private static byte[] renderedPNG;

	private new void Awake()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	[ContextMenu("Test Render Icon")]
	private void TestIcon()
	{
	}

	public static byte[] RenderSaveIcon()
	{
		return null;
	}

	private byte[] RenderSaveIconLocal()
	{
		return null;
	}
}
