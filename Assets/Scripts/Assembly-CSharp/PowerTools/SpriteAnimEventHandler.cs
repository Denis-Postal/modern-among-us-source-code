using UnityEngine;

namespace PowerTools
{
	[DisallowMultipleComponent]
	public class SpriteAnimEventHandler : MonoBehaviour
	{
		public static class EventParser
		{
			public static readonly char MESSAGE_DELIMITER;

			public static readonly string MESSAGE_NOPARAM;

			public static readonly string MESSAGE_INT;

			public static readonly string MESSAGE_FLOAT;

			public static readonly string MESSAGE_STRING;

			public static readonly string MESSAGE_OBJECT_FUNCNAME;

			public static readonly string MESSAGE_OBJECT_DATA;

			public static int ParseInt(ref string messageString)
			{
				return 0;
			}

			public static float ParseFloat(ref string messageString)
			{
				return 0f;
			}

			public static string ParseString(ref string messageString)
			{
				return null;
			}
		}

		private string m_eventWithObjectMessage;

		private object m_eventWithObjectData;

		private void _Anim(string function)
		{
		}

		private void _AnimInt(string messageString)
		{
		}

		private void _AnimFloat(string messageString)
		{
		}

		private void _AnimString(string messageString)
		{
		}

		private void _AnimObjectFunc(string funcName)
		{
		}

		private void _AnimObjectData(Object data)
		{
		}
	}
}
