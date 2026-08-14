using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using UnityEngine;

public class SkinLayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoCheckJumpAnim_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkinLayer _003C_003E4__this;

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
		public _003CCoCheckJumpAnim_003Ed__20(int _003C_003E1__state)
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

	private readonly int JUMP_ZIPLINE_FRAME_STOP;

	public SpriteRenderer layer;

	public SpriteAnim animator;

	public SkinViewData skin;

	public SkinData data;

	private PlayerMaterial.Properties matProperties;

	public bool IsLoaded => data != null || skin != null;

	public bool Flipped
	{
		set
		{
			if (layer != null)
			{
				layer.flipX = value;
			}
		}
	}

	public bool Visible
	{
		set
		{
			if (layer != null)
			{
				layer.enabled = value;
			}
		}
	}

	public void SetMaskType(PlayerMaterial.MaskType maskType)
	{
	}

	public void SetMaskLayer(int layer)
	{
		if (this.layer != null)
		{
			PlayerMaterial.SetMaskLayer(this.layer.material, layer);
		}
	}

	public void SetLocalPlayer(bool localPlayer)
	{
	}

	public void SetRun(bool isLeft)
	{
	}

	public void SetSpawn(bool isLeft, float time = 0f)
	{
	}

	public void SetClimb(bool down)
	{
	}

	public void SetExitVent(bool isLeft)
	{
	}

	public void SetJump(bool isLeft)
	{
	}

	[IteratorStateMachine(typeof(_003CCoCheckJumpAnim_003Ed__20))]
	private IEnumerator CoCheckJumpAnim()
	{
		return null;
	}

	public void SetEnterVent(bool isLeft)
	{
	}

	public void SetIdle(bool isLeft)
	{
	}

	public void SetGhost()
	{
	}

	public void SetSkin(string skinId, int color, bool isLeft, CosmeticsLayer cosmeticsLayer, Action onLoaded = null)
	{
		SetSkin(DestroyableSingleton<HatManager>.Instance.GetSkinById(skinId), color, isLeft, cosmeticsLayer, onLoaded);
	}

	public void SetSkin(SkinData skinData, int color, bool isLeft, CosmeticsLayer cosmeticsLayer, Action onLoaded = null)
	{
		data = skinData;
		skin = skinData != null ? CosmeticAssetLoader.LoadReference<SkinViewData>(skinData.ViewDataRef, skinData.name) : null;
		Flipped = isLeft;
		if (layer != null)
		{
			layer.sprite = skin != null ? skin.IdleFrame : null;
		}
		SetColor(color);
		Visible = skinData != null && !skinData.IsEmpty;
		onLoaded?.Invoke();
	}

	public void SetSkin(SkinViewData skin, int color, bool isLeft)
	{
		this.skin = skin;
		Flipped = isLeft;
		if (layer != null)
		{
			layer.sprite = skin != null ? skin.IdleFrame : null;
		}
		SetColor(color);
	}

	public void SetColor(int color)
	{
		if (layer != null)
		{
			PlayerMaterial.SetColors(color, layer);
		}
	}

	public bool IsPlayingRunAnim()
	{
		return false;
	}

	private void UpdateMaterial()
	{
	}
}
