using System;
using UnityEngine;

[CreateAssetMenu]
public class CosmeticReleaseGroup : AbstractCosmeticGroup
{
	[SerializeField]
	private string date;

	public string DisplayName => null;

	public string DateString => null;

	public DateTime Date => default(DateTime);
}
