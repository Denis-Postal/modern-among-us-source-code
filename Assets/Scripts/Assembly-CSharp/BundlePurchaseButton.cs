using Assets.InnerNet;

public class BundlePurchaseButton : PurchaseButton
{
	public BundleData ourBundle;

	public void UpdateBundle()
	{
	}

	protected override void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void RefreshPriceText()
	{
	}

	public override void SetItem(IBuyable product, string productId, string name, string price, bool purchased, CurrencyTypes currency)
	{
	}
}
