using InnerNet;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PlatformIdentifier : MonoBehaviour
{
	public SpriteRenderer iconRenderer;

	public TextMeshPro platformIDText;

	public bool isOnHUD;

	public Sprite genericConsole;

	public Sprite mobile;

	public Sprite pc;

	public Sprite nSwitch;

	public Sprite ps4;

	public Sprite xbox;

	public bool Masked;

	private bool Visible
	{
		set
		{
		}
	}

	private bool UsernameVisible
	{
		set
		{
		}
	}

	public static bool SupportsPlatformUsername(Platforms platformTypeID)
	{
		return false;
	}

	public void Awake()
	{
	}

	public void SetInfo(ClientData clientData)
	{
	}

	public void SetInfo(GameListing gameListingData)
	{
	}

	public void SetInfo(Platforms platform, string platformName)
	{
	}

	private void SetIcon(Platforms platform)
	{
	}

	[ContextMenu("Update pos")]
	public void UpdatePosition()
	{
	}

	private Sprite GetPrevalidationIcon(Platforms platform)
	{
		return null;
	}

	private Sprite ValidateIcon(Sprite icon)
	{
		return null;
	}
}
