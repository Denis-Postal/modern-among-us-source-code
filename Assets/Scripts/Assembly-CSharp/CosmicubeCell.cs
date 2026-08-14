using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PowerTools;
using TMPro;
using UnityEngine;

public class CosmicubeCell : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoEditorSetData_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CosmicubeCell _003C_003E4__this;

		public UnlockableCosmetic cosmetic;

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
		public _003CCoEditorSetData_003Ed__42(int _003C_003E1__state)
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
	private sealed class _003CCoPurchase_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CosmicubeCell _003C_003E4__this;

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
		public _003CCoPurchase_003Ed__55(int _003C_003E1__state)
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
	private sealed class _003CCoPurchaseAnimation_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CosmicubeCell _003C_003E4__this;

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
		public _003CCoPurchaseAnimation_003Ed__57(int _003C_003E1__state)
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
	private sealed class _003CCoSetSprites_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CosmicubeCell _003C_003E4__this;

		public UnlockableCosmetic cosmetic;

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
		public _003CCoSetSprites_003Ed__46(int _003C_003E1__state)
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

	private const float cellSpacing = 0.74f;

	private const float cellUnlockGlowDuration = 0.9f;

	public CosmicubeCell parent;

	public CosmicubeCell northChild;

	public CosmicubeCell southChild;

	public CosmicubeCell eastChild;

	public CosmicubeCell westChild;

	public SpriteRenderer icon;

	public TextMeshPro costText;

	public SpriteRenderer cellSprite;

	public SpriteRenderer qualitySprite;

	public SpriteRenderer glowSprite;

	public SpriteRenderer MaskArea;

	public SpriteRenderer SelectionHighlight;

	public GameObject data;

	public bool unlocked;

	public SpriteAnim Animator;

	public AnimationClip PurchaseAnimation;

	public UnlockableCosmetic cosmetic;

	[SerializeField]
	private Material iconMaterial;

	[SerializeField]
	private Material iconColoredMaterial;

	[SerializeField]
	private Material maskMaterial;

	private CosmicubeMenu menu;

	public bool HasEastCell => false;

	public bool HasWestCell => false;

	public bool HasNorthCell => false;

	public bool HasSouthCell => false;

	public UnlockableCosmetic CosmeticData => null;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetMenu(CosmicubeMenu menu)
	{
	}

	public void SetParent(CosmicubeCell parent)
	{
	}

	public void SetEastChild(CosmicubeCell c, UnlockableCosmetic data)
	{
	}

	public void SetWestChild(CosmicubeCell c, UnlockableCosmetic data)
	{
	}

	public void SetNorthChild(CosmicubeCell c, UnlockableCosmetic data)
	{
	}

	public void SetSouthChild(CosmicubeCell c, UnlockableCosmetic data)
	{
	}

	public void SetData(UnlockableCosmetic cosmetic)
	{
	}

	[IteratorStateMachine(typeof(_003CCoEditorSetData_003Ed__42))]
	public IEnumerator CoEditorSetData(UnlockableCosmetic cosmetic)
	{
		return null;
	}

	public void SetPositionAndScale(UnlockableCosmetic cosmetic)
	{
	}

	public void SetMetadata(UnlockableCosmetic cosmetic)
	{
	}

	public void SetMask()
	{
	}

	[IteratorStateMachine(typeof(_003CCoSetSprites_003Ed__46))]
	public IEnumerator CoSetSprites(UnlockableCosmetic cosmetic)
	{
		return null;
	}

	private void EditMaterialInEditorMode(SpriteRenderer sprite, Material material, int cellMaskLayer)
	{
	}

	private Material GetIconMaterial()
	{
		return null;
	}

	public void ChooseCell()
	{
	}

	public void SetSelected()
	{
	}

	public void SetDeselected()
	{
	}

	public void SetCellPurchased()
	{
	}

	public void SetUnavailable()
	{
	}

	public void SetAvailable()
	{
	}

	[IteratorStateMachine(typeof(_003CCoPurchase_003Ed__55))]
	public IEnumerator CoPurchase()
	{
		return null;
	}

	public bool CanBePurchased()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CCoPurchaseAnimation_003Ed__57))]
	private IEnumerator CoPurchaseAnimation()
	{
		return null;
	}
}
