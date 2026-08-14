using System;
using UnityEngine;

[Serializable]
public class StoreTabButton : TabButton
{
	public float ItemListStartY;

	public FloatRange XRange;

	public int NumPerRow;

	public StoreTab storeTab;

	public GameObject NewItemIcon;
}
