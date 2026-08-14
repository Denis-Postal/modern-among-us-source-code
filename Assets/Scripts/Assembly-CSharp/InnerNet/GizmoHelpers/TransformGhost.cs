using System.Collections.Generic;
using UnityEngine;

namespace InnerNet.GizmoHelpers
{
	public class TransformGhost : ITransformGhost
	{
		private const int MaxCount = 30;

		private const float HalfSize = 0.05f;

		private List<Vector2> positions;

		public void AddPt(Vector2 pt)
		{
		}

		public void Render(Color c, bool crosses)
		{
		}
	}
}
