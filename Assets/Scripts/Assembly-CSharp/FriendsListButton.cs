using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FriendsListButton : MonoBehaviour
{
	public GameObject Button;

	public TextMeshPro NotifCount;

	public GameObject NotifCircle;

	[SerializeField]
	private ActionMapGlyphDisplay gamepadButton;

	private bool showInScene;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private void Update()
	{
	}

	public void CheckNotifCount()
	{
	}

	public void SetGlyphColor(bool isGrayedOut)
	{
	}
}
