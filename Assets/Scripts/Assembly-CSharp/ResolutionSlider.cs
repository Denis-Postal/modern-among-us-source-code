using TMPro;
using UnityEngine;

public class ResolutionSlider : MonoBehaviour
{
	private int targetIdx;

	private Resolution targetResolution;

	private bool targetFullscreen;

	private Resolution[] allResolutions;

	public SlideBar slider;

	public ToggleButtonBehaviour Fullscreen;

	public ToggleButtonBehaviour VSync;

	public TextMeshPro Display;

	public ToggleButtonBehaviour Screenshake;

	public void OnEnable()
	{
	}

	public void ToggleScreenshake()
	{
	}

	public void ToggleVSync()
	{
	}

	public void ToggleFullscreen()
	{
	}

	public void OnResChange()
	{
	}

	public void SaveChange()
	{
	}
}
