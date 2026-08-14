using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ImaginationOverflow.UniversalDeepLinking;
using UnityEngine;

namespace Twitch
{
	public class TwitchManager : DestroyableSingleton<TwitchManager>
	{
		private enum UpdateState
		{
			NotStarted = 0,
			Started = 1,
			Success = 2,
			Failure = 3
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFetchEntitlements_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<HttpStatusCode> _003C_003Et__builder;

			public TwitchManager _003C_003E4__this;

			public string token;

			private HttpClient _003Chttp_003E5__2;

			private HttpRequestMessage _003Cmsg_003E5__3;

			private HttpResponseMessage _003Cres_003E5__4;

			private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

			private TaskAwaiter<string> _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFetchNewToken_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public TwitchManager _003C_003E4__this;

			private string _003CtokenCache_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLaunchImplicitAuthAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public TwitchManager _003C_003E4__this;

			private TaskAwaiter<HttpStatusCode> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[CompilerGenerated]
		private sealed class _003CShakeGlitch_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TwitchManager _003C_003E4__this;

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
			public _003CShakeGlitch_003Ed__16(int _003C_003E1__state)
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

		private const string RedirectUri = "AmongUs://callback";

		private const string ClientId = "yioca4gf70qx0v05qodt6tnwlkerr3";

		private static readonly string[] Scopes;

		private string verify;

		public GenericPopup TwitchPopup;

		private UpdateState running;

		private List<string> newItems;

		public string Token { get; set; }

		private void Start()
		{
		}

		private void Instance_LinkActivated(LinkActivation s)
		{
		}

		public override void OnDestroy()
		{
		}

		public void LaunchImplicitAuth(Transform target)
		{
		}

		[IteratorStateMachine(typeof(_003CShakeGlitch_003Ed__16))]
		private IEnumerator ShakeGlitch(Transform target)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLaunchImplicitAuthAsync_003Ed__17))]
		private void LaunchImplicitAuthAsync()
		{
		}

		[AsyncStateMachine(typeof(_003CFetchNewToken_003Ed__18))]
		private Task FetchNewToken()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFetchEntitlements_003Ed__19))]
		public Task<HttpStatusCode> FetchEntitlements(string token)
		{
			return null;
		}
	}
}
