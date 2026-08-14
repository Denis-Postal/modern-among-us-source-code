using System;
using System.Collections.Generic;
using UnityEngine;

namespace AmongUs.AnimationTestScene
{
	public class AnimationTestSceneEjectPage : AbstractAnimationTestScenePage
	{
		[Serializable]
		public class ExileCutsceneData
		{
			[SerializeField]
			private string name;

			[SerializeField]
			private ExileController cutscene;

			public string Name => null;

			public ExileController Play(NetworkedPlayerInfo.PlayerOutfit outfit, bool voteTie, bool voteSkipped, bool isImpostor, bool confirmImpostor)
			{
				return null;
			}
		}

		[SerializeField]
		[Header("Eject Page")]
		private AnimationTestSceneButton buttonTemplate;

		[SerializeField]
		private ExileCutsceneData[] cutscenes;

		[SerializeField]
		[Header("Inspector")]
		private AnimationTestSceneButton isImpostorButton;

		[SerializeField]
		private AnimationTestSceneButton confirmImpostorButton;

		[SerializeField]
		private AnimationTestSceneButton voteSuccessButton;

		[SerializeField]
		private AnimationTestSceneButton voteTiedButton;

		[SerializeField]
		private AnimationTestSceneButton voteSkippedButton;

		private bool isImpostor;

		private bool confirmImpostor;

		private bool voteTie;

		private bool voteSkipped;

		private bool showingCutscene;

		private ExileController currentCutscene;

		private List<AnimationTestSceneButton> buttons;

		protected override void Awake()
		{
		}

		protected override void Update()
		{
		}

		protected override void OnShow()
		{
		}

		protected override void OnHide()
		{
		}

		private void ClearButtons()
		{
		}

		private void InitializeButtons()
		{
		}

		private void OnCutsceneButtonClicked(ExileCutsceneData cutscene)
		{
		}

		private void StartCutscene(ExileCutsceneData cutscene)
		{
		}

		private void EndCutscene()
		{
		}

		private void OnIsImpostorToggled()
		{
		}

		private void OnConfirmImpostorToggled()
		{
		}

		private void OnVoteSuccessToggled()
		{
		}

		private void OnVoteTiedToggled()
		{
		}

		private void OnVoteSkippedToggled()
		{
		}

		private void UpdateInspectorButtons()
		{
		}
	}
}
