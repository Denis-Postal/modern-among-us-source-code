using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class RadialMenu : MonoBehaviour
{
	public struct CachedButtonObject
	{
		public TextMeshPro tr;

		public Transform textHandle;

		public RectTransform trRT;

		public GameObject gameObject;

		public PassiveButton button;

		public ButtonRolloverHandler rolloverHandler;

		public bool isNew;

		public PolygonCollider2D buttonCollider;

		public List<Vector2> colliderPoints;

		public int buttonIndex;

		public SpriteRenderer iconSR;

		private Vector3 baseTextPos;

		public Vector3 buttonDir;

		public CachedButtonObject(GameObject go, int bIndex)
		{
			tr = null;
			textHandle = null;
			trRT = null;
			gameObject = null;
			button = null;
			rolloverHandler = null;
			isNew = false;
			buttonCollider = null;
			colliderPoints = null;
			buttonIndex = 0;
			iconSR = null;
			baseTextPos = default(Vector3);
			buttonDir = default(Vector3);
		}

		public void AddIcon(Sprite iconSprite)
		{
		}

		public void ResetIcon()
		{
		}
	}

	public Mesh mesh;

	public GameObject perButtonTemplateObject;

	private MeshFilter mf;

	private MeshRenderer mr;

	private int radialDivisions;

	public float sliceDegreesPerVert;

	public float textPositionDistance;

	public bool angleText;

	public int testRadialDivs;

	private MaterialPropertyBlock mbp;

	private Controller cont;

	public Transform arrowRotateHandle;

	public Transform arrowScaleHandle;

	public Transform inputGlyph;

	public List<CachedButtonObject> cachedButtons;

	[NonSerialized]
	public Vector3[] buttonCenters;

	[NonSerialized]
	public Vector3[] buttonLeftEdges;

	[NonSerialized]
	public Vector3[] buttonRightEdges;

	private const float startOffset = -(float)Math.PI / 2f;

	public static int instances;

	[HideInInspector]
	public int prevSelectedButton;

	[HideInInspector]
	public int mouseSelectedButton;

	private const int cutoffLength = 12;

	public float horizontalSqueezedWidth;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void ButtonMouseOver(int which)
	{
	}

	public void ButtonMouseExit()
	{
	}

	private void Update()
	{
	}

	public CachedButtonObject[] CreateButtonsForStrings(string[] strings)
	{
		return null;
	}

	private void CacheButtons(int numButtons)
	{
	}

	public float GetButtonMaxStringWidth(int whichButton, float scale)
	{
		return 0f;
	}

	private void AlignTexts(string[] strings)
	{
	}

	private void BuildMesh(int newRadialDivisions)
	{
	}
}
