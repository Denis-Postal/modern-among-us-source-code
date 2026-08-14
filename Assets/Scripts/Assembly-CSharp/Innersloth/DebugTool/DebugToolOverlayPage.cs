using System.Collections.Generic;
using UnityEngine;

namespace Innersloth.DebugTool
{
	public abstract class DebugToolOverlayPage : MonoBehaviour
	{
		protected readonly List<IDebugToolInputProvider> InputProviders;

		protected IDebugToolKeyboardInputProvider KeyboardInputProvider;

		public abstract string Name { get; }

		public abstract bool ConsumingNavActions { get; }

		public abstract void Show();

		public abstract void OnBackButtonPressed();

		public void AddInputProvider(IDebugToolInputProvider provider)
		{
		}

		public void SetKeyboardInputProvider(IDebugToolKeyboardInputProvider provider)
		{
		}
	}
}
