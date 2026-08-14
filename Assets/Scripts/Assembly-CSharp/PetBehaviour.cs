using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using UnityEngine;

public class PetBehaviour : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMoveBehindSource_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PetBehaviour _003C_003E4__this;

		public float speed;

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
		public _003CMoveBehindSource_003Ed__64(int _003C_003E1__state)
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
	private sealed class _003CWalkPetTo_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PetBehaviour _003C_003E4__this;

		public Vector2 worldPos;

		public float speed;

		public float tolerance;

		private Rigidbody2D _003Cbody_003E5__2;

		private Vector2 _003Cdel_003E5__3;

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
		public _003CWalkPetTo_003Ed__65(int _003C_003E1__state)
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

	private const float MIN_DISTANCE = 0.2f;

	private const float DAMPING = 0.7f;

	private const float EASING = 0.2f;

	private const float SPEED = 5f;

	private const float SNAP_DISTANCE = 2f;

	[SerializeField]
	private PetData data;

	[SerializeField]
	[Space(10f)]
	private SpriteAnim animator;

	[SerializeField]
	private Rigidbody2D rigidbody;

	[SerializeField]
	private Collider2D collider;

	[SerializeField]
	[Header("Offsets")]
	private float yOffset;

	[SerializeField]
	private Transform pettingHandPosition;

	[SerializeField]
	[Header("Animations")]
	private AnimationClip idleClip;

	[SerializeField]
	private AnimationClip sadClip;

	[SerializeField]
	private AnimationClip scaredClip;

	[SerializeField]
	private AnimationClip walkClip;

	[SerializeField]
	private AnimationClip petClip;

	[SerializeField]
	[Header("Sprite Renderers")]
	private SpriteRenderer[] renderers;

	[SerializeField]
	private SpriteRenderer[] shadows;

	private PlayerControl targetPlayer;

	private bool visible;

	private bool flipX;

	private bool beingPet;

	private bool manualMoving;

	private bool viewOnly;

	public PetData Data => null;

	public PlayerControl TargetPlayer => null;

	public Vector3 PettingHandPosition => default(Vector3);

	public Vector3 PettingPlayerPosition => default(Vector3);

	public int RendererCount => 0;

	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool FlipX
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetupNewPet(PetData data, Rigidbody2D body, CircleCollider2D collider, SpriteAnim animator, AnimationClip idleClip, AnimationClip scaredClip, AnimationClip walkClip, AnimationClip sadClip, AnimationClip petClip, SpriteRenderer[] renderers, SpriteRenderer[] shadows)
	{
	}

	public void SetTargetPlayer(PlayerControl targetPlayer)
	{
	}

	public void SetDefaultMaterial()
	{
	}

	public void SetCrewmateColor(int colorId)
	{
	}

	public void SetRawColor(Color color)
	{
	}

	public void SetAsLocalPlayer()
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public bool HasCrewmateColorShader()
	{
		return false;
	}

	public void SetIdleOrMourning()
	{
	}

	public void SetMourning()
	{
	}

	public void SetIdle()
	{
	}

	public void SetScared()
	{
	}

	public void PrepareForUI()
	{
	}

	public void PrepareForPreview(bool previewUsesCrewmateColor)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetGettingPet(bool petting, Vector2 petPos)
	{
	}

	public void StartPetAnim()
	{
	}

	public void StartWalkAnim()
	{
	}

	public void ToggleViewOnly(bool value)
	{
	}

	private Vector2 GetTruePosition()
	{
		return default(Vector2);
	}

	private void ForEachRenderer(bool includeShadows, Action<SpriteRenderer> action)
	{
	}

	private void ForEachShadow(Action<SpriteRenderer> action)
	{
	}

	[IteratorStateMachine(typeof(_003CMoveBehindSource_003Ed__64))]
	public IEnumerator MoveBehindSource(float speed)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWalkPetTo_003Ed__65))]
	private IEnumerator WalkPetTo(Vector2 worldPos, float speed, float tolerance = 0.01f)
	{
		return null;
	}
}
