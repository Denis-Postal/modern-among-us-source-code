using UnityEngine;

namespace PowerTools
{
	public class SpriteAnimNodes : MonoBehaviour
	{
		public static readonly int NUM_NODES;

		[HideInInspector]
		[SerializeField]
		private Vector2 m_node0;

		[HideInInspector]
		[SerializeField]
		private Vector2 m_node1;

		[SerializeField]
		[HideInInspector]
		private Vector2 m_node2;

		[SerializeField]
		[HideInInspector]
		private Vector2 m_node3;

		[HideInInspector]
		[SerializeField]
		private Vector2 m_node4;

		[HideInInspector]
		[SerializeField]
		private Vector2 m_node5;

		[HideInInspector]
		[SerializeField]
		private Vector2 m_node6;

		[SerializeField]
		[HideInInspector]
		private Vector2 m_node7;

		[SerializeField]
		[HideInInspector]
		private Vector2 m_node8;

		[HideInInspector]
		[SerializeField]
		private Vector2 m_node9;

		[SerializeField]
		[HideInInspector]
		private float m_ang0;

		[SerializeField]
		[HideInInspector]
		private float m_ang1;

		[HideInInspector]
		[SerializeField]
		private float m_ang2;

		[SerializeField]
		[HideInInspector]
		private float m_ang3;

		[HideInInspector]
		[SerializeField]
		private float m_ang4;

		[HideInInspector]
		[SerializeField]
		private float m_ang5;

		[HideInInspector]
		[SerializeField]
		private float m_ang6;

		[HideInInspector]
		[SerializeField]
		private float m_ang7;

		[HideInInspector]
		[SerializeField]
		private float m_ang8;

		[HideInInspector]
		[SerializeField]
		private float m_ang9;

		private SpriteRenderer m_spriteRenderer;

		public Vector3 GetPosition(int nodeId, bool ignoredPivot = false)
		{
			return default(Vector3);
		}

		public Vector3 GetLocalPosition(int nodeId, bool ignoredPivot = false)
		{
			return default(Vector3);
		}

		public float GetAngle(int nodeId)
		{
			return 0f;
		}

		public Vector2 GetPositionRaw(int nodeId)
		{
			return default(Vector2);
		}

		public float GetAngleRaw(int nodeId)
		{
			return 0f;
		}

		public void Reset()
		{
		}
	}
}
