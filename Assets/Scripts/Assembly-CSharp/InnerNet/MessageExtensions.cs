using Hazel;

namespace InnerNet
{
	public static class MessageExtensions
	{
		public static void WriteNetObject(this MessageWriter self, InnerNetObject obj)
		{
		}

		public static T ReadNetObject<T>(this MessageReader self) where T : InnerNetObject
		{
			return null;
		}
	}
}
