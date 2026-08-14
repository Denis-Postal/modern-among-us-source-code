using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeleteAccountPopupBox : MonoBehaviour
{
	private List<SelectableHyperLink> selectableHyperLinks;

	public SpriteRenderer background;

	public TextMeshPro titleTexxt;

	public TextMeshPro bodyText;

	public TextMeshPro button1Text;

	public TextMeshPro button2Text;

	public PassiveButton button1;

	public PassiveButton button2;

	public Checkbox checkbox;

	public TextMeshPro checkboxText;

	public TextBoxTMP deleteConfirm;

	public void Close()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
