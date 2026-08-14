using TMPro;
using UnityEngine;

public class CategoryHeaderMasked : MonoBehaviour
{
	[SerializeField]
	protected TextMeshPro Title;

	[SerializeField]
	protected SpriteRenderer Background;

	[SerializeField]
	protected SpriteRenderer Divider;

	public virtual void SetHeader(StringNames name, int maskLayer)
	{
		if ((bool)Title)
		{
			Title.text = DestroyableSingleton<TranslationController>.InstanceExists ? DestroyableSingleton<TranslationController>.Instance.GetString(name) : name.ToString();
			Title.gameObject.layer = maskLayer;
		}
		if ((bool)Background)
		{
			Background.gameObject.layer = maskLayer;
		}
		if ((bool)Divider)
		{
			Divider.gameObject.layer = maskLayer;
		}
	}
}
