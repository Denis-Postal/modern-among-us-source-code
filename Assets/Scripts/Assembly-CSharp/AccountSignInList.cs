using UnityEngine;

public class AccountSignInList : MonoBehaviour
{
	public AccountButton ButtonPrefab;

	public Scroller ButtonParent;

	public float ButtonStart;

	public float ButtonHeight;

	private AccountButton[] AllButtons;

	public AccountsMenu parent;

	public ControllerNavMenu controllerNavParent;

	public bool createAccount;

	public void Start()
	{
	}

	public void LogInWith(AccountButton selected)
	{
	}
}
