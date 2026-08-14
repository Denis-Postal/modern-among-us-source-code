using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxTMP : MonoBehaviour, IFocusHolder
{
	public static readonly HashSet<char> SymbolChars;

	public static readonly HashSet<char> EmailChars;

	public const char HiddenChar = '*';

	public bool allowAllCharacters;

	public string text;

	private string compoText;

	public int characterLimit;

	[SerializeField]
	public TextMeshPro outputText;

	public SpriteRenderer Background;

	public MeshRenderer Pipe;

	[SerializeField]
	private TextMeshPro placeholderText;

	private float pipeBlinkTimer;

	public bool ClearOnFocus;

	public bool ForceUppercase;

	public Button.ButtonClickedEvent OnEnter;

	public Button.ButtonClickedEvent OnChange;

	public Button.ButtonClickedEvent OnFocusLost;

	private TouchScreenKeyboard keyboard;

	public bool AllowSymbols;

	public bool AllowEmail;

	public bool IpMode;

	public bool AllowPaste;

	public bool Hidden;

	private Collider2D[] colliders;

	private bool hasFocus;

	private int caretPos;

	private float caretRepeatTimer;

	public float caretYOffset;

	public Color colorBackground;

	private StringBuilder tempTxt;

	public SpriteRenderer sendButtonGlyph;

	public bool SendOnFullChars;

	public float TextHeight => 0f;

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	public void ResetField()
	{
	}

	public void Clear()
	{
	}

	public void Update()
	{
	}

	public void GiveFocus()
	{
	}

	public void ForceKeyboardClose()
	{
	}

	public void LoseFocus()
	{
	}

	public bool CheckCollision(Vector2 pt)
	{
		return false;
	}

	public void SetText(string input, string inputCompo = "")
	{
	}

	public bool IsCharAllowed(char i)
	{
		return false;
	}

	private void MoveCaret()
	{
	}

	private void AdjustCaretPosition(int adjustment)
	{
	}

	private void SetCaretPosition(int index)
	{
	}

	private void SetPipePosition()
	{
	}
}
