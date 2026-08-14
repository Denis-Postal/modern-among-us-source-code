using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FontExtensionData : ScriptableObject
{
	public string FontName;

	public List<KerningPair> kernings;

	public List<OffsetAdjustment> Offsets;

	public void AdjustKernings(FontData target)
	{
	}

	public void AdjustOffsets(FontData target)
	{
	}
}
