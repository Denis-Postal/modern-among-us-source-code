using System;
using UnityEngine;

public class FungleSecurityCamera : MonoBehaviour
{
	public Action<Collision2D> OnCollision;

	public Action<Collision2D> OnExitCollision;

	[SerializeField]
	private Camera cam;

	[SerializeField]
	private Rigidbody2D rigidbody;

	public RenderTexture RenderTexture
	{
		set
		{
		}
	}

	public float OrthographicSize
	{
		set
		{
		}
	}

	public bool CollisionsEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Move(Vector3 delta)
	{
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	private void OnCollisionStay2D(Collision2D col)
	{
	}

	private void OnCollisionExit2D(Collision2D col)
	{
	}
}
