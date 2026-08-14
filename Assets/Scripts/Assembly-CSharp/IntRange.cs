using System;

[Serializable]
public class IntRange
{
	public int min;

	public int max;

	public IntRange()
	{
	}

	public IntRange(int min, int max)
	{
	}

	public int Next()
	{
		return 0;
	}

	public bool Contains(int value)
	{
		return false;
	}

	public static int Next(int max)
	{
		return 0;
	}

	internal static int Next(int min, int max)
	{
		return 0;
	}

	internal static byte NextByte(byte min, byte max)
	{
		return 0;
	}

	public static void FillRandom(sbyte min, sbyte max, sbyte[] array)
	{
	}

	public static int RandomSign()
	{
		return 0;
	}

	public static void FillRandomRange(sbyte[] array)
	{
	}
}
