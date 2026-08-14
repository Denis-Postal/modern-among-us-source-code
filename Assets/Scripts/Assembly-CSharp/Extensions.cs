using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public static class Extensions
{
	[CompilerGenerated]
	private sealed class _003CWaitForCompletion_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Task self;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWaitForCompletion_003Ed__0(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static string[] ByteHex;

	[IteratorStateMachine(typeof(_003CWaitForCompletion_003Ed__0))]
	public static IEnumerator WaitForCompletion(this Task self)
	{
		return null;
	}

	public static string RemoveAll(this string self, params char[] chars)
	{
		return null;
	}

	public static void TrimEnd(this StringBuilder self)
	{
	}

	public static void DestroyAll<T>(this IList<T> self) where T : MonoBehaviour
	{
	}

	public static void AddUnique<T>(this IList<T> self, T item)
	{
	}

	public static string ToTextColor(this Color c)
	{
		return null;
	}

	public static Color SetAlpha(this Color c, float alpha)
	{
		return default(Color);
	}

	public static int ToInteger(this Color c, bool alpha)
	{
		return 0;
	}

	public static bool HasAnyBit(this int self, int bit)
	{
		return false;
	}

	public static bool HasAnyBit(this byte self, byte bit)
	{
		return false;
	}

	public static bool HasAnyBit(this ushort self, byte bit)
	{
		return false;
	}

	public static bool HasBit(this byte self, byte bit)
	{
		return false;
	}

	public static int BitCount(this byte self)
	{
		return 0;
	}

	public static int IndexOf<T>(this T[] self, T item) where T : class
	{
		return 0;
	}

	public static int IndexOfMin<T>(this T[] self, Func<T, float> comparer)
	{
		return 0;
	}

	public static KeyValuePair<byte, int> MaxPair(this Dictionary<byte, int> self, out bool tie)
	{
		tie = default(bool);
		return default(KeyValuePair<byte, int>);
	}

	public static TV GetValueOrSetDefault<TK, TV>(this Dictionary<TK, TV> self, TK key, Func<TV> defaultValueFunc)
	{
		return default(TV);
	}

	public static void SetAll<T>(this IList<T> self, T value)
	{
	}

	public static void AddAll<T>(this List<T> self, IList<T> other)
	{
	}

	public static void RemoveDupes<T>(this IList<T> self) where T : class
	{
	}

	public static void Shuffle<T>(this IList<T> self, int startAt = 0)
	{
		for (int i = startAt; i < self.Count - 1; i++)
		{
			T value = self[i];
			int index = UnityEngine.Random.Range(i, self.Count);
			self[i] = self[index];
			self[index] = value;
		}
	}

	public static void Shuffle<T>(this System.Random r, IList<T> self)
	{
		for (int i = 0; i < self.Count; i++)
		{
			T value = self[i];
			int index = r.Next(self.Count);
			self[i] = self[index];
			self[index] = value;
		}
	}

	public static T[] RandomSet<T>(this IList<T> self, int length)
	{
		T[] array = new T[length];
		self.RandomFill(array);
		return array;
	}

	public static void RandomFill<T>(this IList<T> self, T[] target)
	{
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = 0; i < target.Length; i++)
		{
			int num;
			do
			{
				num = self.RandomIdx();
			}
			while (hashSet.Contains(num));
			target[i] = self[num];
			hashSet.Add(num);
			if (hashSet.Count == self.Count)
			{
				break;
			}
		}
	}

	public static int RandomIdx<T>(this IList<T> self)
	{
		return UnityEngine.Random.Range(0, self.Count);
	}

	public static int RandomIdx<T>(this IEnumerable<T> self)
	{
		return UnityEngine.Random.Range(0, self.Count());
	}

	public static T Random<T>(this IEnumerable<T> self)
	{
		return self.ToArray().Random();
	}

	public static T Random<T>(this IList<T> self)
	{
		if (self.Count > 0)
		{
			return self[UnityEngine.Random.Range(0, self.Count)];
		}
		return default(T);
	}

	public static Vector2 Div(this Vector2 a, Vector2 b)
	{
		return default(Vector2);
	}

	public static Vector2 Mul(this Vector2 a, Vector2 b)
	{
		return default(Vector2);
	}

	public static Vector3 Mul(this Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	public static Vector3 Inv(this Vector3 a)
	{
		return default(Vector3);
	}

	public static Rect Lerp(this Rect source, Rect target, float t)
	{
		return default(Rect);
	}

	public static void ForEach<T>(this IList<T> self, Action<T> todo)
	{
	}

	public static T Max<T>(this IList<T> self, Func<T, float> comparer)
	{
		return default(T);
	}

	public static T Max<T>(this IList<T> self, Func<T, decimal> comparer)
	{
		return default(T);
	}

	public static int Wrap(this int self, int max)
	{
		return 0;
	}

	public static int LastIndexOf<T>(this T[] self, Predicate<T> pred)
	{
		return 0;
	}

	public static int IndexOf<T>(this T[] self, Predicate<T> pred)
	{
		return 0;
	}

	public static Vector2 MapToRectangle(this Vector2 del, Vector2 widthAndHeight)
	{
		del = del.normalized;
		if (Mathf.Abs(del.x) > Mathf.Abs(del.y))
		{
			return new Vector2(Mathf.Sign(del.x) * widthAndHeight.x, del.y * widthAndHeight.y / 0.70710677f);
		}
		return new Vector2(del.x * widthAndHeight.x / 0.70710677f, Mathf.Sign(del.y) * widthAndHeight.y);
	}

	public static float AngleSignedRad(this Vector2 vector1, Vector2 vector2)
	{
		return Mathf.Atan2(vector2.y, vector2.x) - Mathf.Atan2(vector1.y, vector1.x);
	}

	public static float AngleSigned(this Vector2 vector1, Vector2 vector2)
	{
		return vector1.AngleSignedRad(vector2) * 57.29578f;
	}

	public static float AngleSigned(this Vector2 vector1)
	{
		return Vector2.up.AngleSigned(vector1);
	}

	public static float WheelAngle(this Vector2 vector1, Vector2 vector2)
	{
		float num = vector1.AngleSigned(vector2);
		if (num < 0f)
		{
			num += 360f;
		}
		return num;
	}

	public static Vector2 Rotate(this Vector2 self, float degrees)
	{
		float f = (float)Math.PI / 180f * degrees;
		float num = Mathf.Cos(f);
		float num2 = Mathf.Sin(f);
		return new Vector2(self.x * num - num2 * self.y, self.x * num2 + num * self.y);
	}

	public static Vector3 RotateZ(this Vector3 self, float degrees)
	{
		float f = (float)Math.PI / 180f * degrees;
		float num = Mathf.Cos(f);
		float num2 = Mathf.Sin(f);
		return new Vector3(self.x * num - num2 * self.y, self.x * num2 + num * self.y, self.z);
	}

	public static Vector3 RotateY(this Vector3 self, float degrees)
	{
		float f = (float)Math.PI / 180f * degrees;
		float num = Mathf.Cos(f);
		float num2 = Mathf.Sin(f);
		return new Vector3(self.x * num - num2 * self.z, self.y, self.x * num2 + num * self.z);
	}

	public static bool TryToEnum<TEnum>(this string strEnumValue, out TEnum enumValue)
	{
		enumValue = default(TEnum);
		return false;
	}

	public static TEnum ToEnum<TEnum>(this string strEnumValue)
	{
		return default(TEnum);
	}

	public static TEnum ToEnum<TEnum>(this string strEnumValue, TEnum defaultValue)
	{
		return default(TEnum);
	}

	public static bool IsNullOrWhiteSpace(this string s)
	{
		return false;
	}

	public static string GetHierarchy(this Transform trans)
	{
		return null;
	}
}
