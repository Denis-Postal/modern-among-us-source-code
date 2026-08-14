using System;
using Assets.InnerNet;
using TMPro;
using UnityEngine;

public class PurchaseButton : MonoBehaviour
{
	private const float normalSize = 1.75f;

	[Header("Icons")]
	public SpriteRenderer PurchasedIcon;

	public SpriteRenderer LimitedTimeIcon;

	public UpdateProductTimerDisplay LimitedTimeText;

	public SpriteRenderer CrewHeadImage;

	public HatParent HatImage;

	public VisorLayer VisorLayer;

	public Sprite MannequinFrame;

	public LoadingSpinner LoadingIndicator;

	[Header("Background")]
	public SpriteRenderer Background;

	public SpriteRenderer SelectionHighlight;

	public SpriteRenderer GlassSprite;

	public SpriteRenderer GlassMask;

	public SpriteRenderer ImageMask;

	public SpriteRenderer PurchasedOverlay;

	[Header("Button")]
	public BoxCollider2D clickCollider;

	public PassiveButton PassiveButton;

	[Header("Product Info")]
	public TextMeshPro NameText;

	public TextMeshPro PriceText;

	public bool Purchased;

	public string Name;

	public string Price;

	public string ProductId;

	public GameObject PriceLabel;

	[Header("Label")]
	public SpriteRenderer LabelMask;

	public SpriteRenderer LabelBackground;

	public SpriteRenderer LabelGlass;

	public IBuyable Product;

	private Action onDestroy;

	public StoreMenu Parent { get; set; }

	protected virtual void Start()
	{
	}

	public virtual void SetItem(IBuyable product, string productId, string name, string price, bool purchased, CurrencyTypes currency)
	{
	}

	private void SetDoubleBig()
	{
	}

	private void SetSquare()
	{
	}

	public void DoPurchase()
	{
	}

	private void OnDestroy()
	{
	}
}
