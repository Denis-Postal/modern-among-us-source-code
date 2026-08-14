using System.Collections.Generic;
using UnityEngine;

public class LightSource : MonoBehaviour
{
	public const string FLASHLIGHT_KEYWORD = "FLASHLIGHT";

	private const float FLASHLIGHT_LERP_SPEED = 5f;

	private const float FLASHLIGHT_LERP_SPEED_CONSOLE = 10f;

	private const float DEFAULT_PLAYER_RADIUS = 0.5f;

	public static Dictionary<GameObject, NoShadowBehaviour> NoShadows;

	public static Dictionary<GameObject, OneWayShadows> OneWayShadows;

	[SerializeField]
	private float viewDistance;

	[SerializeField]
	private Material lightCutawayMaterial;

	[SerializeField]
	private Mesh lightChildMesh;

	[SerializeField]
	[Space(10f)]
	private LightSourceRendererType rendererType;

	[SerializeField]
	private bool useFlashlight;

	[Header("GPU Settings")]
	[SerializeField]
	private Material gpuShadowCasterMaterial;

	[SerializeField]
	private int gpuShadowmapResolution;

	[SerializeField]
	private RenderTextureFormat gpuPreferredRTFormat;

	[SerializeField]
	[Header("Raycast Settings")]
	private int raycastMinRayCount;

	[SerializeField]
	private float raycastTolerance;

	private LightSourceRenderer renderer;

	private GameObject lightChild;

	private MeshFilter lightChildMeshFilter;

	private Controller controller;

	private float flashlightSize;

	private Vector2 lastFlashlightDirection;

	private Vector3 lightOffset;

	private Transform touchFlashlightTarget;

	public float ViewDistance => 0f;

	public float PlayerRadius => 0f;

	public Material LightCutawayMaterial => null;

	public GameObject LightChild => null;

	public Mesh LightChildMesh => null;

	public MeshFilter LightChildMeshFilter => null;

	public Vector3 LightOffset => default(Vector3);

	public float FlashlightSize => 0f;

	public Material GpuShadowCasterMaterial => null;

	public int GpuShadowmapResolution => 0;

	public RenderTextureFormat GpuPreferredRTFormat => default(RenderTextureFormat);

	public int RaycastMinimumRayCount => 0;

	public float RaycastTolerance => 0f;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Initialize(Vector3 lightOffset)
	{
	}

	public void SetViewDistance(float distance)
	{
	}

	public void SetupLightingForGameplay(bool enableFlashlight, float flashlightSize, Transform touchFlashlightTarget)
	{
	}

	private float CalculateFlashlightSize()
	{
		return 0f;
	}

	private void SetFlashlightEnabled(bool enabled)
	{
	}

	private void UpdateShadowType()
	{
	}

	private void UpdateFlashlightAngle()
	{
	}

	private float GetFlashlightAngle()
	{
		return 0f;
	}

	private float GetVirtualJFAngle()
	{
		return 0f;
	}

	private float GetKeyboardMouseFAngle()
	{
		return 0f;
	}

	private float GetControllerFAngle()
	{
		return 0f;
	}

	private float GetScreenFAngle()
	{
		return 0f;
	}

	private float GetAngleDot()
	{
		return 0f;
	}

	private float GetAngleMove()
	{
		return 0f;
	}
}
