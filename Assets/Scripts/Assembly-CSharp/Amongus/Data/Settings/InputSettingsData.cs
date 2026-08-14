using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data.Settings
{
	[JsonObject(MemberSerialization.OptIn)]
	public class InputSettingsData : AbstractSaveDataGroup
	{
		public const ControlTypes DEFAULT_INPUT_MODE = ControlTypes.Keyboard;

		public const bool DEFAULT_MOUSE_MOVEMENT_ENABLED = false;

		public const float DEFAULT_TOUCH_JOYSTICK_SIZE = 1f;

		private const string INIT_KEY = "initialization";

		private const string INIT_VALUE_DEFAULT = "uninitialized";

		private const string INIT_VALUE_INITIALIZED = "initialized";

		[JsonProperty("inputMode")]
		private ControlTypes inputMode;

		[JsonProperty("mouseMovementEnabled")]
		private bool mouseMovementEnabled;

		[JsonProperty("touchJoystickSize")]
		private float touchJoystickSize;

		[JsonProperty("inputData")]
		private Dictionary<string, string> inputData;

		public ControlTypes InputMode
		{
			get
			{
				return default(ControlTypes);
			}
			set
			{
			}
		}

		public bool MouseMovementEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float TouchJoystickSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public event Action OnInputModeChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnMouseMovementEnabledChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnTouchJoystickSizeChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnInputDataChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void OnLoadComplete()
		{
		}

		protected override void OnSaveStart()
		{
		}

		protected override void OnSaveComplete()
		{
		}

		private static ControlTypes ValidateInputMode(ControlTypes mode)
		{
			return default(ControlTypes);
		}

		public bool HasInputDataValue(string key)
		{
			return false;
		}

		public string GetInputDataValue(string key)
		{
			return null;
		}

		public void SetInputDataValue(string key, string value)
		{
		}
	}
}
