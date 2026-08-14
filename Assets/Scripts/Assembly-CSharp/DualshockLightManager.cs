using System.Collections.Generic;
using UnityEngine;

public class DualshockLightManager : DestroyableSingleton<DualshockLightManager>
{
	public class LightOverlayHandle
	{
		public Color color;

		public float intensity;

		public void Dispose()
		{
		}
	}

	public class LightOverlayFlash
	{
		public LightOverlayHandle handle;

		public AudioClip clip;

		public float t;

		public float duration;

		private static float[] samples;

		public bool Alive => false;

		public void Init()
		{
		}

		public void Dispose()
		{
		}

		public void Update(float deltaTime)
		{
		}
	}

	private const float lightIntensity = 0.5f;

	private Color baseColor;

	private Color oldColor;

	private List<LightOverlayHandle> overlays;

	private List<LightOverlayFlash> lightOverlayFlashes;

	public Color BaseColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public LightOverlayHandle AllocateLight()
	{
		return null;
	}

	private float GetExternalBrightnessFromElectrical()
	{
		return 0f;
	}

	private void Update()
	{
	}

	public static void Flash(Color c, float intensity, AudioClip clip)
	{
	}
}
