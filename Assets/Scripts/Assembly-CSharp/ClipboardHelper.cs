using System;
using System.Runtime.InteropServices;

public static class ClipboardHelper
{
	private const uint CF_TEXT = 1u;

	[PreserveSig]
	private static extern bool IsClipboardFormatAvailable(uint format);

	[PreserveSig]
	private static extern bool OpenClipboard(IntPtr hWndNewOwner);

	[PreserveSig]
	private static extern bool CloseClipboard();

	[PreserveSig]
	private static extern IntPtr GetClipboardData(uint format);

	[PreserveSig]
	private static extern IntPtr GlobalLock(IntPtr hMem);

	[PreserveSig]
	private static extern bool GlobalUnlock(IntPtr hMem);

	[PreserveSig]
	private static extern int GlobalSize(IntPtr hMem);

	public static string GetClipboardString()
	{
		return null;
	}

	public static void PutClipboardString(string str)
	{
	}
}
