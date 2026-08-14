using TMPro;
using UnityEngine;

public abstract class ActionButton : MonoBehaviour
{
	[SerializeField]
	protected SpriteRenderer graphic;

	[SerializeField]
	protected SpriteRenderer usesRemainingSprite;

	[SerializeField]
	protected TextMeshPro usesRemainingText;

	[SerializeField]
	protected TextMeshPro buttonLabelText;

	[SerializeField]
	protected TextMeshPro cooldownTimerText;

	[SerializeField]
	private ActionMapGlyphDisplay glyph;

	protected bool isCoolingDown;

	protected readonly Logger logger;

	protected bool canInteract;

	private Vector3 position;

	public bool IsOnCooldown => false;

	private void Start()
	{
	}

	public abstract void DoClick();

	public bool CanInteract()
	{
		return false;
	}

	public void SetCoolDown(float timer, float maxTimer)
	{
	}

	public void SetUsesRemaining(int num)
	{
	}

	public void SetInfiniteUses()
	{
	}

	public void SetFillUp(float timer, float maxTimer)
	{
	}

	public void SetEnabled()
	{
	}

	public void SetDisabled()
	{
	}

	public void ToggleVisible(bool visible)
	{
	}

	public virtual void Hide()
	{
	}

	public virtual void Show()
	{
	}

	public void SetCooldownFill(float percentCool)
	{
	}

	public void OverrideText(string text)
	{
	}

	public void OverrideColor(Color color)
	{
	}

	protected void ResetCoolDown()
	{
	}
}
