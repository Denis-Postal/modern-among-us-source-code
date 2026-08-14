using System.Collections;
using TMPro;
using UnityEngine;

public class ButtonRolloverHandler : MonoBehaviour
{
	public SpriteRenderer Target;

	public SpriteRenderer Target2;

	public TextMeshPro TargetText;

	public MeshRenderer TargetMesh;

	public Color OverColor = Color.green;

	public Color OutColor = Color.white;

	public Color UnselectedColor = Color.white;

	public bool UseObjectsOutColor;

	public bool UseObjectSelected;

	public AudioClip HoverSound;

	public void Awake()
	{
		if (UseObjectsOutColor)
		{
			if (Target != null)
			{
				OutColor = Target.color;
			}
			else if (TargetText != null)
			{
				OutColor = TargetText.color;
			}
			else if (TargetMesh != null && TargetMesh.material != null)
			{
				OutColor = TargetMesh.material.color;
			}
		}
		PassiveButton component = GetComponent<PassiveButton>();
		if (component != null)
		{
			if (component.OnMouseOver == null)
			{
				component.OnMouseOver = new UnityEngine.Events.UnityEvent();
			}
			if (component.OnMouseOut == null)
			{
				component.OnMouseOut = new UnityEngine.Events.UnityEvent();
			}
			if (component.OnClick == null)
			{
				component.OnClick = new UnityEngine.UI.Button.ButtonClickedEvent();
			}
			component.OnMouseOver.AddListener(DoMouseOver);
			component.OnMouseOut.AddListener(DoMouseOut);
			component.OnClick.AddListener(DoMouseClick);
		}
	}

	public void DoMouseClick()
	{
		if (UseObjectSelected)
		{
			ApplyColor(UnselectedColor);
		}
	}

	public void DoMouseOver()
	{
		ApplyColor(OverColor);
		if (HoverSound)
		{
			SoundManager soundManager = SoundManager.Instance;
			if (soundManager != null)
			{
				soundManager.PlaySound(HoverSound, loop: false);
			}
		}
	}

	public void DoMouseOut()
	{
		ApplyColor(OutColor);
	}

	public void SetDisabledColors()
	{
		ApplyColor(UnselectedColor);
	}

	public void SetEnabledColors()
	{
		ApplyColor(OutColor);
	}

	public void ChangeOutColor(Color color)
	{
		OutColor = color;
		DoMouseOut();
	}

	public void WaitClickUnselect()
	{
		StartCoroutine(WaitChangeUnselect());
	}

	private IEnumerator WaitChangeUnselect()
	{
		yield return null;
		DoMouseOut();
	}

	private void ApplyColor(Color color)
	{
		if (Target != null)
		{
			Target.color = color;
		}
		if (Target2 != null)
		{
			Target2.color = color;
		}
		if (TargetText != null)
		{
			TargetText.color = color;
		}
		if (TargetMesh != null && TargetMesh.material != null)
		{
			TargetMesh.material.color = color;
		}
	}
}
