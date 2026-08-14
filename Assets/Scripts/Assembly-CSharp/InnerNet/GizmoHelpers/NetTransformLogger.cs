using System.Collections.Generic;
using UnityEngine;

namespace InnerNet.GizmoHelpers
{
	public class NetTransformLogger : INetTransformLogger
	{
		private List<int> queue;

		private List<bool> slowbandLog;

		private Vector3 pos;

		public void SetQueueLength(int i)
		{
		}

		public void SetSlowbandingLog(bool isSlowbanding)
		{
		}

		public void Render(Vector3 pos2, float rubberBandMod)
		{
		}
	}
}
