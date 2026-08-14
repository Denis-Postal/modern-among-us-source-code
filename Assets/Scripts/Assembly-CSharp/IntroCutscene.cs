using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class IntroCutscene : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoBegin_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IntroCutscene _003C_003E4__this;

		private PlayerControl _003Cimpostor_003E5__2;

		private PoolablePlayer _003CplayerSlot_003E5__3;

		private float _003CcrewmateLeadTime_003E5__4;

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
		public _003CCoBegin_003Ed__35(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CShowRole_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IntroCutscene _003C_003E4__this;

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
		public _003CShowRole_003Ed__41(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CShowTeam_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IntroCutscene _003C_003E4__this;

		public List<PlayerControl> teamToShow;

		public float duration;

		private Color _003Cc_003E5__2;

		private Color _003Cfade_003E5__3;

		private Color _003CimpColor_003E5__4;

		private Vector3 _003CtitlePos_003E5__5;

		private float _003Ctimer_003E5__6;

		private float _003CDuration_003E5__7;

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
		public _003CShowTeam_003Ed__38(int _003C_003E1__state)
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

	private const float BaseY = -1f;

	private const float ScaleAll = 1f;

	private const float OffsetWidth = 0.9f;

	private const float OffsetHeight = 0.15f;

	public static IntroCutscene Instance;

	public TextMeshPro TeamTitle;

	public TextMeshPro ImpostorText;

	public TextMeshPro YouAreText;

	public TextMeshPro RoleText;

	public TextMeshPro RoleBlurbText;

	public TextMeshPro HideAndSeekTimerText;

	public PoolablePlayer PlayerPrefab;

	public PoolablePlayer OurCrewmate;

	public GameObject HideAndSeekPanels;

	public GameObject CrewmateRules;

	public GameObject ImpostorRules;

	public MeshRenderer BackgroundBar;

	public MeshRenderer Foreground;

	public FloatRange ForegroundRadius;

	public SpriteRenderer FrontMost;

	public AudioClip IntroStinger;

	[Header("HnS Temp")]
	public TextMeshPro ImpostorName;

	public TextMeshPro ImpostorTitle;

	private Vector3 impostorPos;

	private float impostorScale;

	[SerializeField]
	private AnimationClip HnSSeekerSpawnAnim;

	[SerializeField]
	private AnimationClip HnSSeekerSpawnHorseAnim;

	[SerializeField]
	private AnimationClip HnSSeekerSpawnHorseInGameAnim;

	[SerializeField]
	private AnimationClip HnSSeekerSpawnLongAnim;

	[SerializeField]
	private AnimationClip HnSSeekerSpawnLongInGameAnim;

	public PoolablePlayer HideAndSeekPlayerVisual;

	public PoolablePlayer HorseWrangleVisualSuit;

	public PoolablePlayer HorseWrangleVisualPlayer;

	private PoolablePlayer ourCrewmate;

	private DualshockLightManager.LightOverlayHandle overlayHandle;

	[IteratorStateMachine(typeof(_003CCoBegin_003Ed__35))]
	public IEnumerator CoBegin()
	{
		return null;
	}

	public void CheckSeekerHand_AnimEvent()
	{
	}

	private static List<PlayerControl> SelectTeamToShow(Func<NetworkedPlayerInfo, bool> roleFilter)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowTeam_003Ed__38))]
	private IEnumerator ShowTeam(List<PlayerControl> teamToShow, float duration)
	{
		return null;
	}

	private void BeginCrewmate(List<PlayerControl> teamToDisplay)
	{
	}

	private void BeginImpostor(List<PlayerControl> yourTeam)
	{
	}

	[IteratorStateMachine(typeof(_003CShowRole_003Ed__41))]
	private IEnumerator ShowRole()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private PoolablePlayer CreatePlayer(int i, int maxDepth, NetworkedPlayerInfo pData, bool impostorPositioning)
	{
		return null;
	}

	private void LogPlayerRoleData()
	{
	}
}
