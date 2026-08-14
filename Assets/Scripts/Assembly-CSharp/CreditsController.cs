using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class CreditsController : MonoBehaviour
{
	public enum CreditType
	{
		TEXT = 0,
		IMAGE = 1
	}

	[Serializable]
	public struct FormatStruct
	{
		public string format;

		public CreditType creditType;

		public List<GameObject> formatPrefabs;
	}

	[Serializable]
	public struct CreditStruct
	{
		public string format;

		public string[] columns;
	}

	public int NumberOfContentColumns;

	public GameObject creditPanelPrefab;

	public GameObject creditMainPanel;

	public float creditScrollSpeed;

	public float initialDelay;

	public float startPos;

	private float remainingDelay;

	private RectTransform creditsRect;

	private float defaultCreditsScrollSpeed;

	private float navCreditsScrollSpeed;

	private Player player;

	private bool paused;

	public List<FormatStruct> formats;

	public List<CreditStruct> credits;

	public event Action OnFinish
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void PauseUnpauseCreditsScroll()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void GenerateCreditEntry(CreditStruct credit)
	{
	}

	public void ClearCredits()
	{
	}

	public void AddCredit(CreditStruct credit)
	{
	}

	public void AddFormat(string formatName)
	{
	}

	public FormatStruct GetFormat(string formatName)
	{
		return default(FormatStruct);
	}

	private void LoadCredits()
	{
	}
}
