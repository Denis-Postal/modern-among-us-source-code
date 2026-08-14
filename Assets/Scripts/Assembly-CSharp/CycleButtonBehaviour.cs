using TMPro;
using UnityEngine;

public class CycleButtonBehaviour : MonoBehaviour, ITranslatedText
{
	public StringNames[] options;

	public StringNames BaseText;

	public TextMeshPro Text;

	public SpriteRenderer Background;

	public ButtonRolloverHandler Rollover;

	public GameObject helpButton;

	private int curSelection;

	public TextMeshPro quickChatInstructions;

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	public void ResetText()
	{
	}

	public void UpdateText(int selection)
	{
	}
}
