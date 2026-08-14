using Hazel;
using UnityEngine;

public static class NetHelpers
{
	private static readonly FloatRange XRange;

	private static readonly FloatRange YRange;

	public static bool SidGreaterThan(ushort newSid, ushort prevSid)
	{
		return false;
	}

	public static bool SidGreaterThan(byte newSid, byte prevSid)
	{
		return false;
	}

	public static void WriteVector2(Vector2 vec, MessageWriter writer)
	{
	}

	public static Vector2 ReadVector2(MessageReader reader)
	{
		return default(Vector2);
	}
}
