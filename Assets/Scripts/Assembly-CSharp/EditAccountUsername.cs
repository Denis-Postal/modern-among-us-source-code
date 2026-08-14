using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EditAccountUsername : MonoBehaviour
{
	public TextMeshPro UsernameText;

	public TextMeshPro SuccessText;

	public GameObject SuccessMessage;

	public GameObject PopUp;

	[Header("Console Controller Navigation")]
	public UiElement DefaultButtonSelected;

	public List<UiElement> ControllerSelectable;

	public void OnEnable()
	{
	}

	public virtual void OnDisable()
	{
	}

	public void SaveUsername()
	{
	}

	public void RandomizeName()
	{
	}

	public void Close()
	{
	}
}
