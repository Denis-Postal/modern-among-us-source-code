using System.Collections;
using UnityEngine;

public class FollowerCamera : MonoBehaviour
{
	public MonoBehaviour Target;

	public Vector2 Offset;

	public bool Locked;

	public float shakeAmount;

	public float shakePeriod = 1f;

	[System.NonSerialized]
	public bool OverrideScreenShakeEnabled;

	private Vector2 centerPosition;

	public void Update()
	{
		if (Target == null || Locked)
		{
			return;
		}
		Vector3 position = transform.position;
		Vector3 targetPosition = new Vector3(Target.transform.position.x + Offset.x, Target.transform.position.y + Offset.y, position.z);
		transform.position = Vector3.Lerp(position, targetPosition, 5f * Time.deltaTime);
		centerPosition = transform.position;
		if (shakeAmount > 0f && !OverrideScreenShakeEnabled)
		{
			float amount = shakeAmount * 0.25f;
			float x = Mathf.PerlinNoise(0.5f, Time.time * shakePeriod) * 2f - 1f;
			float y = Mathf.PerlinNoise(Time.time * shakePeriod, 0.5f) * 2f - 1f;
			transform.Translate(x * amount, y * amount, 0f);
		}
	}

	public void ShakeScreen(float duration, float severity)
	{
		StartCoroutine(CoShakeScreen(duration, severity));
	}

	private IEnumerator CoShakeScreen(float duration, float severity)
	{
		if (duration <= 0f)
		{
			yield break;
		}
		OverrideScreenShakeEnabled = true;
		WaitForFixedUpdate wait = new WaitForFixedUpdate();
		Vector2 oldOffset = Offset;
		for (float t = duration; t > 0f; t -= Time.fixedDeltaTime)
		{
			float num = t / duration;
			Offset = oldOffset + Random.insideUnitCircle * num * severity;
			yield return wait;
		}
		Offset = oldOffset;
		OverrideScreenShakeEnabled = false;
	}

	internal void SetTarget(MonoBehaviour target)
	{
		Target = target;
		SnapToTarget();
	}

	public void SnapToTarget()
	{
		if (Target == null)
		{
			return;
		}
		Vector3 position = transform.position;
		transform.position = new Vector3(Target.transform.position.x + Offset.x, Target.transform.position.y + Offset.y, position.z);
		centerPosition = transform.position;
	}
}
