using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class CosmicubeMenu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoAnimatePurchase_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CosmicubeMenu _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCoAnimatePurchase_003Ed__50(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public GameObject zoomInGlyph;

	public GameObject zoomOutGlyph;

	public TextMeshPro cubeTitle;

	public TextMeshPro percentCompletedText;

	public TextMeshPro selectedItemName;

	public TextMeshPro selectedItemCategory;

	public TextMeshPro[] selectedItemPrice;

	public TextMeshPro confirmPurchaseText;

	public GameObject confirmWindow;

	public GameObject equipButton;

	public GameObject equippedText;

	public GameObject loadingIndicator;

	public SpriteRenderer podConfirmIcon;

	public CubeCellPurchaseButton purchaseButton;

	public GameObject lockedButton;

	public PoolablePlayer dressMeUp;

	public PlayerVoteArea nameplatePreview;

	public StoreMannequin storeMannequin;

	public SpriteRenderer nameplateConfirmPreview;

	public SpriteRenderer podIcon;

	public TextMeshPro podAmount;

	public Scroller scroller;

	public GameObject cubeHolder;

	public SpriteRenderer zoomOutButton;

	public SpriteRenderer zoomInButton;

	public AudioClip cubeCellUnlockSound;

	public UpdateProductTimerDisplay limitedTimeText;

	public PurchasePopUp plsWaitModal;

	public static int CellMaskLayer;

	private float zoomLevel;

	private float minZoom;

	private float maxZoom;

	private bool previewMode;

	private bool animatingPurchase;

	private Cosmicube currentCube;

	private CosmicubeData currentCubeData;

	private CosmicubeCell currentCell;

	private readonly Logger logger;

	private void OnDisable()
	{
	}

	public void ZoomIn()
	{
	}

	public void ZoomOut()
	{
	}

	public void Show(string cubeID, bool previewMode = false)
	{
	}

	private void UpdatePercentComplete()
	{
	}

	public LimitedTimeStartEnd GetCurrentProductLimitedTime()
	{
		return default(LimitedTimeStartEnd);
	}

	public void Close()
	{
	}

	public void EquipSelectedItem()
	{
	}

	public void SelectItem(CosmicubeCell cell)
	{
	}

	private void LoadCube()
	{
	}

	public void ClickPurchase()
	{
	}

	[IteratorStateMachine(typeof(_003CCoAnimatePurchase_003Ed__50))]
	private IEnumerator CoAnimatePurchase()
	{
		return null;
	}

	public void ShowConfirmPurchase()
	{
	}

	private void Update()
	{
	}

	private void AdjustZoom(float amount)
	{
	}

	private void OnDestroy()
	{
	}
}
