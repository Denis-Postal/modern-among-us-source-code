using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PowerTools
{
	[RequireComponent(typeof(Animator))]
	[DisallowMultipleComponent]
	public class SpriteAnim : SpriteAnimEventHandler
	{
		private static readonly string STATE_NAME = "a";

		private static readonly string CONTROLLER_PATH = "SpriteAnimController";

		[SerializeField]
		private AnimationClip m_defaultAnim;

		private static RuntimeAnimatorController m_sharedAnimatorController;

		private Animator m_animator;

		private AnimatorOverrideController m_controller;

		private SpriteAnimNodes m_nodes;

		private List<KeyValuePair<AnimationClip, AnimationClip>> m_clipPairList = new List<KeyValuePair<AnimationClip, AnimationClip>>(1);

		private AnimationClip m_currAnim;

		private float m_speed = 1f;

		private bool m_initialized;

		public bool Playing => IsPlaying();

		public bool Paused
		{
			get
			{
				return IsPaused();
			}
			set
			{
				if (value)
				{
					Pause();
				}
				else
				{
					Resume();
				}
			}
		}

		public float Speed
		{
			get
			{
				return m_speed;
			}
			set
			{
				SetSpeed(value);
			}
		}

		public int FrameTime
		{
			get
			{
				return Mathf.RoundToInt(GetTime() * 60f);
			}
			set
			{
				SetTime(value / 60f);
			}
		}

		public float Time
		{
			get
			{
				return GetTime();
			}
			set
			{
				SetTime(value);
			}
		}

		public float NormalizedTime
		{
			get
			{
				return GetNormalisedTime();
			}
			set
			{
				SetNormalizedTime(value);
			}
		}

		public AnimationClip Clip => m_currAnim;

		public string ClipName => m_currAnim != null ? m_currAnim.name : string.Empty;

		public void Play(AnimationClip anim = null, float speed = 1f)
		{
			Initialize();
			if (anim == null)
			{
				anim = (m_currAnim ? m_currAnim : m_defaultAnim);
				if (anim == null)
				{
					return;
				}
			}
			if (m_animator == null || m_controller == null || m_clipPairList == null || m_clipPairList.Count == 0)
			{
				return;
			}
			if (!m_animator.enabled)
			{
				m_animator.enabled = true;
			}
			if (m_nodes != null)
			{
				m_nodes.Reset();
			}
			m_clipPairList[0] = new KeyValuePair<AnimationClip, AnimationClip>(m_clipPairList[0].Key, anim);
			m_controller.ApplyOverrides(m_clipPairList);
			m_animator.Update(0f);
			m_animator.Play(STATE_NAME, 0, 0f);
			m_speed = Mathf.Max(0f, speed);
			m_animator.speed = m_speed;
			m_currAnim = anim;
			m_animator.Update(0f);
		}

		public void Stop()
		{
			Initialize();
			if (m_animator != null)
			{
				m_animator.enabled = false;
			}
		}

		public void Pause()
		{
			Initialize();
			if (m_animator != null)
			{
				m_animator.speed = 0f;
			}
		}

		public void Resume()
		{
			Initialize();
			if (m_animator != null)
			{
				m_animator.speed = m_speed;
			}
		}

		public AnimationClip GetCurrentAnimation()
		{
			return m_currAnim;
		}

		public bool IsPlaying(AnimationClip clip = null)
		{
			Initialize();
			if (m_animator == null || m_currAnim == null)
			{
				return false;
			}
			if (clip == null || m_currAnim == clip)
			{
				return m_currAnim.isLooping || m_animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1f;
			}
			return false;
		}

		public bool IsPlaying(string animName)
		{
			if (m_currAnim == null || m_currAnim.name != animName)
			{
				return false;
			}
			return IsPlaying(m_currAnim);
		}

		public bool IsPaused()
		{
			Initialize();
			return m_currAnim != null && m_animator != null && m_animator.speed == 0f;
		}

		public void SetSpeed(float speed)
		{
			Initialize();
			m_speed = Mathf.Max(0f, speed);
			if (m_animator != null)
			{
				m_animator.speed = m_speed;
			}
		}

		public float GetSpeed()
		{
			return m_speed;
		}

		public float GetTime()
		{
			Initialize();
			if (m_currAnim != null && m_animator != null)
			{
				return m_animator.GetCurrentAnimatorStateInfo(0).normalizedTime * m_currAnim.length;
			}
			return 0f;
		}

		public void SetTime(float time)
		{
			if (m_currAnim != null && m_currAnim.length > 0f)
			{
				SetNormalizedTime(time / m_currAnim.length);
			}
		}

		public float GetNormalisedTime()
		{
			Initialize();
			if (m_currAnim != null && m_animator != null)
			{
				return m_animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
			}
			return 0f;
		}

		public void SetNormalizedTime(float ratio)
		{
			Initialize();
			if (m_currAnim != null && m_animator != null)
			{
				m_animator.Play(STATE_NAME, 0, m_currAnim.isLooping ? Mathf.Repeat(ratio, 1f) : Mathf.Clamp01(ratio));
			}
		}

		public void Initialize()
		{
			if (m_initialized)
			{
				return;
			}
			m_initialized = true;
			m_animator = GetComponent<Animator>();
			if (m_animator == null)
			{
				return;
			}
			m_controller = new AnimatorOverrideController();
			if (m_sharedAnimatorController == null)
			{
				m_sharedAnimatorController = Resources.Load<RuntimeAnimatorController>(CONTROLLER_PATH);
			}
			if (m_sharedAnimatorController == null)
			{
				return;
			}
			m_controller.runtimeAnimatorController = m_sharedAnimatorController;
			m_animator.runtimeAnimatorController = m_controller;
			m_controller.GetOverrides(m_clipPairList);
			m_nodes = GetComponent<SpriteAnimNodes>();
			Play(m_defaultAnim);
		}

		private void Awake()
		{
			Initialize();
		}

		private void Reset()
		{
			if (GetComponent<RectTransform>() == null)
			{
				if (GetComponent<SpriteRenderer>() == null)
				{
					gameObject.AddComponent<SpriteRenderer>();
				}
			}
			else if (GetComponent<Image>() == null)
			{
				gameObject.AddComponent<Image>();
			}
		}
	}
}
