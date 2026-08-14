using System;

namespace Epic.OnlineServices.Inventory
{
	public sealed class InventoryItem : Handle
	{
		public const int InventoryitemCreatesubitemApiLatest = 1;

		public const int InventoryitemDeletesubitemApiLatest = 1;

		public const int InventoryitemGetdoublesetvaluebyindexApiLatest = 1;

		public const int InventoryitemGetint64SetvaluebyindexApiLatest = 1;

		public const int InventoryitemGetkeyApiLatest = 1;

		public const int InventoryitemGetstringsetvaluebyindexApiLatest = 1;

		public const int InventoryitemGetsubitemApiLatest = 1;

		public const int InventoryitemGetsubitembyindexApiLatest = 1;

		public const int InventoryitemGetsubitemscountApiLatest = 1;

		public const int InventoryitemGetvalueasboolApiLatest = 1;

		public const int InventoryitemGetvalueasdoubleApiLatest = 1;

		public const int InventoryitemGetvalueasint64ApiLatest = 1;

		public const int InventoryitemGetvalueasstringApiLatest = 1;

		public const int InventoryitemGetvalueastimestampApiLatest = 1;

		public const int InventoryitemGetvaluecountApiLatest = 1;

		public const int InventoryitemGetvaluetypeApiLatest = 1;

		public const int InventoryitemKeyMaxLength = 256;

		public const int InventoryitemSetkeyApiLatest = 1;

		public const int InventoryitemSetvalueasboolApiLatest = 1;

		public const int InventoryitemSetvalueasdoubleApiLatest = 1;

		public const int InventoryitemSetvalueasdoublesetApiLatest = 1;

		public const int InventoryitemSetvalueasint64ApiLatest = 1;

		public const int InventoryitemSetvalueasint64SetApiLatest = 1;

		public const int InventoryitemSetvalueasstringApiLatest = 1;

		public const int InventoryitemSetvalueasstringsetApiLatest = 1;

		public const int InventoryitemSetvalueastimestampApiLatest = 1;

		public const int InventoryitemStringValueMaxLength = 393216;

		public InventoryItem()
		{
		}

		public InventoryItem(IntPtr innerHandle)
		{
		}

		public Result CreateSubItem(ref InventoryItemCreateSubItemOptions options, out InventoryItem outInventoryItemHandle)
		{
			outInventoryItemHandle = null;
			return default(Result);
		}

		public Result DeleteSubItem(ref InventoryItemDeleteSubItemOptions options)
		{
			return default(Result);
		}

		public Result GetDoubleSetValueByIndex(ref InventoryItemGetDoubleSetValueByIndexOptions options, out double outValue)
		{
			outValue = default(double);
			return default(Result);
		}

		public Result GetInt64SetValueByIndex(ref InventoryItemGetInt64SetValueByIndexOptions options, out long outValue)
		{
			outValue = default(long);
			return default(Result);
		}

		public Result GetKey(ref InventoryItemGetKeyOptions options, out Utf8String outKey)
		{
			outKey = null;
			return default(Result);
		}

		public Result GetStringSetValueByIndex(ref InventoryItemGetStringSetValueByIndexOptions options, out Utf8String outValue)
		{
			outValue = null;
			return default(Result);
		}

		public Result GetSubItem(ref InventoryItemGetSubItemOptions options, out InventoryItem outInventoryItemHandle)
		{
			outInventoryItemHandle = null;
			return default(Result);
		}

		public Result GetSubItemByIndex(ref InventoryItemGetSubItemByIndexOptions options, out InventoryItem outInventoryItemHandle)
		{
			outInventoryItemHandle = null;
			return default(Result);
		}

		public uint GetSubItemsCount(ref InventoryItemGetSubItemsCountOptions options)
		{
			return 0u;
		}

		public Result GetValueAsBool(ref InventoryItemGetValueAsBoolOptions options, out bool outValue)
		{
			outValue = default(bool);
			return default(Result);
		}

		public Result GetValueAsDouble(ref InventoryItemGetValueAsDoubleOptions options, out double outValue)
		{
			outValue = default(double);
			return default(Result);
		}

		public Result GetValueAsInt64(ref InventoryItemGetValueAsInt64Options options, out long outValue)
		{
			outValue = default(long);
			return default(Result);
		}

		public Result GetValueAsString(ref InventoryItemGetValueAsStringOptions options, out Utf8String outValue)
		{
			outValue = null;
			return default(Result);
		}

		public Result GetValueAsTimestamp(ref InventoryItemGetValueAsTimestampOptions options, out long outValue)
		{
			outValue = default(long);
			return default(Result);
		}

		public uint GetValueCount(ref InventoryItemGetValueCountOptions options)
		{
			return 0u;
		}

		public Result GetValueType(ref InventoryItemGetValueTypeOptions options, out ValueType outValueType)
		{
			outValueType = default(ValueType);
			return default(Result);
		}

		public Result SetKey(ref InventoryItemSetKeyOptions options)
		{
			return default(Result);
		}

		public Result SetValueAsBool(ref InventoryItemSetValueAsBoolOptions options)
		{
			return default(Result);
		}

		public Result SetValueAsDouble(ref InventoryItemSetValueAsDoubleOptions options)
		{
			return default(Result);
		}

		public Result SetValueAsDoubleSet(ref InventoryItemSetValueAsDoubleSetOptions options)
		{
			return default(Result);
		}

		public Result SetValueAsInt64(ref InventoryItemSetValueAsInt64Options options)
		{
			return default(Result);
		}

		public Result SetValueAsInt64Set(ref InventoryItemSetValueAsInt64SetOptions options)
		{
			return default(Result);
		}

		public Result SetValueAsString(ref InventoryItemSetValueAsStringOptions options)
		{
			return default(Result);
		}

		public Result SetValueAsStringSet(ref InventoryItemSetValueAsStringSetOptions options)
		{
			return default(Result);
		}

		public Result SetValueAsTimestamp(ref InventoryItemSetValueAsTimestampOptions options)
		{
			return default(Result);
		}
	}
}
