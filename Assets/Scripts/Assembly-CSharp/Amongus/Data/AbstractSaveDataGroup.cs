using System;
using System.Runtime.CompilerServices;

namespace AmongUs.Data
{
	public abstract class AbstractSaveDataGroup : ISaveDataGroupControl
	{
		public event Action OnChangedEvent
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

		protected virtual void SetValue<T>(ref T field, T value, Action onChangedCallback)
		{
		}

		protected virtual void HandleChange()
		{
		}

		protected virtual void OnSaveStart()
		{
		}

		protected virtual void OnSaveComplete()
		{
		}

		protected virtual void OnLoadStart()
		{
		}

		protected virtual void OnLoadComplete()
		{
		}

		void ISaveDataGroupControl.SaveStart()
		{
		}

		void ISaveDataGroupControl.SaveComplete()
		{
		}

		void ISaveDataGroupControl.LoadStart()
		{
		}

		void ISaveDataGroupControl.LoadComplete()
		{
		}
	}
}
