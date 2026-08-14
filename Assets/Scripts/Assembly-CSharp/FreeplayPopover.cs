using UnityEngine;

public class FreeplayPopover : MonoBehaviour
{
	[SerializeField]
	public GameObject content;

	[SerializeField]
	public GameObject background;

	[SerializeField]
	private FreeplayPopoverButton[] buttons;

	[Space(10f)]
	[SerializeField]
	private HostLocalGameButton hostGameButton;

	[SerializeField]
	[Header("Console Controller Navigation")]
	private UiElement backButton;

	private TransitionOpen transitionOpen;

	private bool closing;

	private bool startingGame;

	private void Awake()
	{
		if (hostGameButton == null)
		{
			hostGameButton = GetComponent<HostLocalGameButton>();
		}
		if (content != null)
		{
			transitionOpen = content.GetComponent<TransitionOpen>();
		}
		PassiveButton backgroundButton = background != null ? background.GetComponent<PassiveButton>() : null;
		if (backgroundButton != null)
		{
			backgroundButton.OnClick.RemoveListener(Close);
			backgroundButton.OnClick.AddListener(Close);
		}
		PassiveButton passiveBackButton = backButton as PassiveButton;
		if (passiveBackButton != null)
		{
			passiveBackButton.OnClick.RemoveListener(Close);
			passiveBackButton.OnClick.AddListener(Close);
		}
		if (buttons != null)
		{
			for (int i = 0; i < buttons.Length; i++)
			{
				FreeplayPopoverButton button = buttons[i];
				if (button != null)
				{
					button.OnPressEvent -= OnMapButtonPressed;
					button.OnPressEvent += OnMapButtonPressed;
				}
			}
		}
		RefreshButtons();
		HideImmediate();
	}

	private void Update()
	{
		if (content == null || !content.activeInHierarchy || closing || !Input.GetMouseButtonUp(0))
		{
			return;
		}
		Camera camera = Camera.main;
		if (camera == null)
		{
			return;
		}
		Vector2 point = camera.ScreenToWorldPoint(Input.mousePosition);
		FreeplayPopoverButton clickedButton = GetButtonAtPoint(point);
		if (clickedButton != null)
		{
			OnMapButtonPressed(clickedButton);
		}
	}

	public void Show()
	{
		if (content == null)
		{
			Debug.LogError("FreeplayPopover is missing content.");
			return;
		}
		closing = false;
		startingGame = false;
		if (background != null)
		{
			background.SetActive(true);
		}
		RefreshButtons();
		content.transform.localScale = Vector3.zero;
		content.SetActive(true);
	}

	public void Close()
	{
		if (closing)
		{
			HideImmediate();
			return;
		}
		if (transitionOpen != null && content != null && content.activeInHierarchy)
		{
			closing = true;
			transitionOpen.Close();
			return;
		}
		HideImmediate();
	}

	private void HideImmediate()
	{
		closing = false;
		if (content != null)
		{
			content.SetActive(false);
		}
		if (background != null)
		{
			background.SetActive(false);
		}
	}

	private void OnMapButtonPressed(FreeplayPopoverButton button)
	{
		if (button != null)
		{
			PlayMap(button.Map);
		}
	}

	private void RefreshButtons()
	{
		if (content == null)
		{
			return;
		}
		buttons = content.GetComponentsInChildren<FreeplayPopoverButton>(true);
		for (int i = 0; i < buttons.Length; i++)
		{
			FreeplayPopoverButton button = buttons[i];
			if (button != null)
			{
				button.OnPressEvent -= OnMapButtonPressed;
				button.OnPressEvent += OnMapButtonPressed;
			}
		}
	}

	private FreeplayPopoverButton GetButtonAtPoint(Vector2 point)
	{
		if (buttons == null || buttons.Length == 0)
		{
			RefreshButtons();
		}
		for (int i = 0; i < buttons.Length; i++)
		{
			FreeplayPopoverButton button = buttons[i];
			if (button != null && button.gameObject.activeInHierarchy && button.ContainsPoint(point))
			{
				return button;
			}
		}
		return null;
	}

	public void PlayMap(MapNames map)
	{
		if (startingGame)
		{
			return;
		}
		if (hostGameButton == null)
		{
			hostGameButton = GetComponent<HostLocalGameButton>();
		}
		if (AmongUsClient.Instance != null)
		{
			AmongUsClient.Instance.TutorialMapId = (int)map;
		}
		if (hostGameButton == null)
		{
			Debug.LogError("FreeplayPopover is missing hostGameButton.");
			return;
		}
		startingGame = true;
		hostGameButton.NetworkMode = NetworkModes.FreePlay;
		hostGameButton.targetScene = "Tutorial";
		hostGameButton.OnClick();
	}
}
