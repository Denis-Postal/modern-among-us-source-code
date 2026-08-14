using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AccountTab : MonoBehaviour
{
	public TextMeshPro userName;

	public TextMeshPro friendCode;

	public TextMeshPro friendCodeTitle;

	public PoolablePlayer playerImage;

	public GameObject friendCodeObject;

	public SpriteRenderer FriendCodeHiddenIcon;

	public GameObject offlineMode;

	public GameObject guestMode;

	public FullAccount loggedInMode;

	public GameObject waitingForGuardian;

	public TextMeshPro guardianEmailText;

	public EditName editNameScreen;

	public GameObject idCard;

	public GameObject resendEmailButton;

	public TextMeshPro levelText;

	public ProgressBar xpProgressBar;

	public TextMeshPro veryBadErrorText;

	public Collider2D clickToCloseCollider;

	public TextMeshPro accountIDDisplayText;

	public GameObject showAccountIDButton;

	public SpriteRenderer SpaceBean;

	public SpriteRenderer SpaceHorse;

	public InfoTextBox InfoTextBoxDisplay;

	[SerializeField]
	private SignInStatusComponent signInStatusComponent;

	[SerializeField]
	private GameObject accountCopyButton;

	private bool showAccountID;

	private string friendCodeHiddenText;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public List<UiElement> PotentialDefaultSelections;

	public List<UiElement> selectableObjects;

	private UiElement DefaultSelection => null;

	private void Awake()
	{
	}

	public void TurnAllSectionsOff()
	{
	}

	public void UpdateKidAccountCanChangeName()
	{
	}

	public void SignIn()
	{
	}

	public void RandomizeName()
	{
	}

	public void ManageAccount()
	{
	}

	public void UpdateNameDisplay()
	{
	}

	public void UpdatePlayerCosmetics()
	{
	}

	public void ChangeName()
	{
	}

	public void ResendEmail()
	{
	}

	public void EditGuardianEmail()
	{
	}

	public void UpdateGuardianEmailText()
	{
	}

	public void SetDLLErrorMode()
	{
	}

	public void UpdateVisuals()
	{
	}

	private void UpdateAccountIDDisplay()
	{
	}

	public void HideAccountIDDisplay()
	{
	}

	public void ShowAccountIDDisplay()
	{
	}

	public void ToggleFriendCodeDisplay()
	{
	}

	public void UpdateFriendCodeUI()
	{
	}

	public void Toggle()
	{
	}

	public void Close()
	{
	}

	public void Open()
	{
	}

	private void UpdateLevelDisplay()
	{
	}
}
