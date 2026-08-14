using System;
using AmongUs;

public static class AmongUsDateTime
{
	private static IAmongUsDateTimeRetriever defaultRetriever;

	private static IAmongUsDateTimeRetriever overrideRetriever;

	private static IAmongUsDateTimeRetriever Retriever => null;

	public static DateTime Now => default(DateTime);

	public static DateTime UtcNow => default(DateTime);
}
