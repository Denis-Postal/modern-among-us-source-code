using Assets.InnerNet;
using TMPro;
using UnityEngine;

public class PurchasePopUp : MonoBehaviour
{
	public enum PurchasePopUpMode
	{
		PurchaseItem = 0,
		CheckingPurchases = 1
	}

	public GameObject waitingText;

	public TextMeshPro titleText;

	public TextMeshPro infoText;

	public GameObject closeButton;

	public GameObject controllerFocusHolder;

	public void Show(PurchasePopUpMode mode = PurchasePopUpMode.PurchaseItem)
	{
	}

	public void SetResponse(ResponseState responseSate, ResponseError[] errors)
	{
	}

	public void SetResponse(ResponseState responseSate, string error)
	{
	}

	private string GetErrorString(ResponseError error)
	{
		return null;
	}
}
