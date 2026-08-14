using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestSceneButton : MonoBehaviour
	{
		[SerializeField]
		private Button button;

		[SerializeField]
		private GameObject toggleIcon;

		[SerializeField]
		private TextMeshProUGUI text;

		private bool toggled;

		public bool Toggled => false;

		public TextMeshProUGUI Text => null;

		public event Action<AnimationTestSceneButton> OnPressEvent
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

		private void Awake()
		{
		}

		private void OnClick()
		{
		}

		public void SetToggle(bool toggled)
		{
		}
	}
}
