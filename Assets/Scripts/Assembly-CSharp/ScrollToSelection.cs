using UnityEngine;

[RequireComponent(typeof(Scroller))]
public class ScrollToSelection : MonoBehaviour
{
	[SerializeField]
	private float scrollOffset;

	private Scroller scrollRect;

	private bool manuallyScrolling;

	private UIScrollbarHelper[] childElements;

	public Vector2 wantedValue;

	private GameObject lastSelectedObject;

	public bool cursorEnabled;

	public bool killScroll;

	public bool onePage;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public void Toggle(bool on)
	{
	}

	public void ClearSelections()
	{
	}

	private void LateUpdate()
	{
	}

	private void ScrollToRect(Transform targetRectTransform)
	{
	}
}
