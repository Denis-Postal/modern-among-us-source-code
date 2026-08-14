using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ImageTranslator : MonoBehaviour, ITranslatedText
{
	public ImageNames TargetImage;

	public void ResetText()
	{
	}

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}
}
