using UnityEngine;

[RequireComponent(typeof(Scroller))]
public class ManualScrollHelper : MonoBehaviour
{
	public bool doVertical;

	public RewiredConstsEnum.Action verticalAxis;

	public bool doHorizontal;

	public RewiredConstsEnum.Action horizontalAxis;

	public float scrollSpeed;

	private ScrollToSelection scrollToSelection;

	private Scroller scroller;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}
}
