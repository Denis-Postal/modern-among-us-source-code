using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class TextController : MonoBehaviour
{
	public float Scale;

	[Multiline]
	public string Text;

	private string displaying;

	[HideInInspector]
	private Texture2D texture;

	[HideInInspector]
	private Texture2D colorTexture;

	private MeshRenderer rend;

	private float _scale;

	public Color Color;

	private Color lastColor;

	public Vector3 Offset;

	public bool topAligned;

	public void Update()
	{
	}
}
