using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TransitionOpen : MonoBehaviour
{
	public float duration = 0.2f;

	public Button.ButtonClickedEvent OnClose = new Button.ButtonClickedEvent();

	public Action OnFinishAnimOpen;

	[SerializeField]
	private float targetSize = 1f;

	private Coroutine animation;

	public void OnEnable()
	{
		StartAnimation(AnimateOpen());
	}

	public void Toggle()
	{
		if (base.gameObject.activeSelf)
		{
			Close();
		}
		else
		{
			base.gameObject.SetActive(true);
		}
	}

	public void Close()
	{
		if (base.gameObject.activeInHierarchy)
		{
			StartAnimation(AnimateClose());
		}
		else
		{
			OnClose.Invoke();
		}
	}

	private IEnumerator AnimateClose()
	{
		Vector3 scale = default(Vector3);
		float start = base.transform.localScale.x;
		float end = 0f;
		float animDuration = Mathf.Max(0.0001f, duration);
		for (float t = 0f; t < animDuration; t += Time.deltaTime)
		{
			float percent = t / animDuration;
			float size = Mathf.SmoothStep(start, end, percent);
			scale.Set(size, size, size);
			base.transform.localScale = scale;
			yield return null;
		}
		scale.Set(end, end, end);
		base.transform.localScale = scale;
		animation = null;
		OnClose.Invoke();
	}

	private IEnumerator AnimateOpen()
	{
		Vector3 scale = default(Vector3);
		float end = targetSize <= 0f ? 1f : targetSize;
		float animDuration = Mathf.Max(0.0001f, duration);
		for (float t = 0f; t < animDuration; t += Time.deltaTime)
		{
			float percent = t / animDuration;
			float size = Mathf.SmoothStep(0f, end, percent);
			scale.Set(size, size, size);
			base.transform.localScale = scale;
			yield return null;
		}
		scale.Set(end, end, end);
		base.transform.localScale = scale;
		animation = null;
		OnFinishAnimOpen?.Invoke();
	}

	private void StartAnimation(IEnumerator routine)
	{
		if (animation != null)
		{
			StopCoroutine(animation);
		}
		animation = StartCoroutine(routine);
	}
}
