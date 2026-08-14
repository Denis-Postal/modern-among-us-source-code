using System;
using UnityEngine;

public abstract class LightSourceRenderer : IDisposable
{
	protected readonly LightSource lightSource;

	public abstract LightSourceRendererType Type { get; }

	public LightSourceRenderer(LightSource lightSource)
	{
	}

	public abstract void Initialize();

	public abstract void Render(Vector2 origin);

	public abstract void Dispose();

	public static LightSourceRenderer Create(LightSourceRendererType type, LightSource lightSource)
	{
		return null;
	}

	public static LightSourceRendererType GetPlatformType()
	{
		return default(LightSourceRendererType);
	}
}
