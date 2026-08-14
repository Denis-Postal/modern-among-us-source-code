using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VibrationManager : DestroyableSingleton<VibrationManager>
{
	public enum VibrationFalloff
	{
		None = 0,
		Linear = 1,
		InverseLinear = 2
	}

	private class LocalVibration
	{
		public Vector2 intensity;

		public float t;

		public float duration;

		public VibrationFalloff falloff;

		public AudioClip clip;

		public bool loopClip;

		public string name;

		public bool Alive => false;

		public void Init()
		{
		}

		public Vector2 UpdateIntensity(float deltaTime)
		{
			return default(Vector2);
		}
	}

	private class WorldVibration
	{
		public float intensity;

		public Vector2 location;

		public float radius;

		public float t;

		public float duration;

		public VibrationFalloff falloff;

		public AudioClip clip;

		public bool loopClip;

		public string name;

		public bool Alive => false;

		public void Init()
		{
		}

		public Vector2 UpdateIntensity(Vector2 cameraPos, float deltaTime)
		{
			return default(Vector2);
		}
	}

	public const float SMALL_INTENSITY = 0.3f;

	public const float MEDIUM_INTENSITY = 0.7f;

	public const float FRAME_DURATION = 0.02f;

	private List<LocalVibration> currentLocalVibration;

	private List<WorldVibration> currentWorldVibration;

	private Vector2 singleFrameVibration;

	private bool hasFrameVibration;

	private bool zeroNextFrame;

	public int numVibrationsActive;

	public Vector2 currentVibration;

	private Camera cam;

	private WorldVibration tempSingleFrameWorldVibration;

	private WorldVibration tempAmbientSoundVibration;

	private bool shouldVibrate;

	private static float[] samples;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
	{
	}

	public static void ClearAllVibration()
	{
	}

	private void Update()
	{
	}

	public static void CancelVibration(AudioClip clipToCancel)
	{
	}

	public static void CancelVibration(string name)
	{
	}

	public static void Vibrate(float left, float right)
	{
	}

	public static void Vibrate(float left, float right, float duration, VibrationFalloff falloffType = VibrationFalloff.None, AudioClip sourceClip = null, bool loopClip = false, string name = "")
	{
	}

	public static void Vibrate(float intensity, Vector2 worldPosition, float radius)
	{
	}

	public static void Vibrate(float intensity, Vector2 worldPosition, float radius, float duration, VibrationFalloff falloffType = VibrationFalloff.None, AudioClip sourceClip = null, bool loopClip = false)
	{
	}
}
