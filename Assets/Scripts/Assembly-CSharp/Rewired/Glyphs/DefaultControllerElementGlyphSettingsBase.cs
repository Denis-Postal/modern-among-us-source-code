using UnityEngine;

namespace Rewired.Glyphs
{
	public abstract class DefaultControllerElementGlyphSettingsBase : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The Controller element glyph options.")]
		private ControllerElementGlyphSelectorOptions _options;

		[SerializeField]
		[Tooltip("The prefab used for each glyph or text object.")]
		private GameObject _glyphOrTextPrefab;

		public ControllerElementGlyphSelectorOptions options
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject glyphOrTextPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void SetDefaults()
		{
		}

		protected virtual void SetDefaultOptions()
		{
		}

		protected abstract void SetDefaultGlyphOrTextPrefab();
	}
}
