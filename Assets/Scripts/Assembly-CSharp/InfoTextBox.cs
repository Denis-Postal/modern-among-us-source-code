using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfoTextBox : MonoBehaviour
{
	public SpriteRenderer background;

	public bool isConfirmWindow;

	public bool AutoSetOneButton;

	public TextMeshPro titleTexxt;

	public TextMeshPro bodyText;

	public TextMeshPro button1Text;

	public TextMeshPro button2Text;

	public PassiveButton button1;

	public PassiveButton button2;

	public Transform button1Trans;

	public Transform button2Trans;

	private List<SelectableHyperLink> selectableHyperLinks;

	public void Awake()
	{
	}

	public void Close()
	{
	}

	public void SetConfirmWindow()
	{
	}

	public void SetTwoButtons()
	{
	}

	public void SetOneButton()
	{
	}

	public void Update()
	{
	}

	public void SetText(string text)
	{
	}

	public void OnTextUpdated()
	{
	}
}
