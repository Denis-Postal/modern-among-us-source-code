using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace AmongUs.HTTP
{
	public class RetryableWebRequest
	{
		[CompilerGenerated]
		private sealed class _003CCoSend_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RetryableWebRequest _003C_003E4__this;

			public Logger logger;

			private UnityWebRequest _003Crequest_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoSend_003Ed__43(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private readonly Dictionary<string, string> requestHeaders;

		private readonly byte[] body;

		private Action<string> successCallback;

		private Action<RetryableWebRequest> errorCallback;

		public string Url { get; private set; }

		public string Method { get; private set; }

		public long ResponseCode { get; private set; }

		public string ResponseText { get; private set; }

		public string Error { get; private set; }

		public bool IsSuccess => false;

		public bool IsFailure => false;

		public bool IsAuthError => false;

		public bool IsTransientError => false;

		private RetryableWebRequest(string url, string method, byte[] body = null)
		{
		}

		public static RetryableWebRequest Head(string url)
		{
			return null;
		}

		public static RetryableWebRequest Get(string url)
		{
			return null;
		}

		public static RetryableWebRequest Post(string url, string body)
		{
			return null;
		}

		public static RetryableWebRequest Post(string url, byte[] body)
		{
			return null;
		}

		public static RetryableWebRequest Put(string url, string body)
		{
			return null;
		}

		public static RetryableWebRequest Put(string url, byte[] body)
		{
			return null;
		}

		public static RetryableWebRequest Delete(string url)
		{
			return null;
		}

		public void SetOrReplaceRequestHeader(string name, string value)
		{
		}

		public void SetOrReplaceSuccessCallback(Action<string> callback)
		{
		}

		public void SetOrReplaceErrorCallback(Action<RetryableWebRequest> callback)
		{
		}

		[IteratorStateMachine(typeof(_003CCoSend_003Ed__43))]
		public IEnumerator CoSend(Logger logger)
		{
			return null;
		}

		private UnityWebRequest BuildRequest()
		{
			return null;
		}
	}
}
