using UnityEngine;

public class KidAccount : MonoBehaviour
{
	[SerializeField]
	private GameObject signInButton;

	[SerializeField]
	private GameObject createAccountButton;

	[SerializeField]
	private GameObject randomizeNameButton;

	[SerializeField]
	private GameObject editNameButton;

	[SerializeField]
	private GameObject requestPermission;

	[SerializeField]
	private GameObject logOutButton;

	public void CanSetCustomName(bool canSetName)
	{
	}

	public void CanSignIntoAccount(bool canSignIn)
	{
	}

	public void HasSignedIntoAccount(bool hasSignedIn)
	{
	}
}
