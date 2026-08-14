using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sentry;
using UnityEngine;

public class BugReportService
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public Texture2D texture;

		public string categoryString;

		internal void _003CSubmitUserFeedbackWithScreenshot_003Eb__0(Scope scope)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CSubmitUserFeedbackWithScreenshot_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BugReportService _003C_003E4__this;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		public StringNames bugReportCategory;

		public string email;

		public string comments;

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
		public _003CSubmitUserFeedbackWithScreenshot_003Ed__20(int _003C_003E1__state)
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

	public const string ENV_EDITOR = "editor";

	public const string ENV_DEVELOPMENT = "development";

	public const string ENV_STAGING = "staging";

	public const string ENV_PRODUCTION = "production";

	public const string TAG_ENVIRONMENT = "environment";

	public const string TAG_PLATFORM = "platform";

	public const string TAG_DISTRIBUTION = "distribution";

	public static BugReportService Instance;

	private const float MinSecondsBetweenUserFeedbackSubmissions = 20f;

	private const string IssueTypeSentryTag = "among_us_issue_type";

	public static readonly StringNames[] BugReportCategories;

	private float timeOfLastSentUserFeedback;

	public static bool IsRuntimeProductionBuild()
	{
		return false;
	}

	public static bool IsBuildTimeProductionBuild()
	{
		return false;
	}

	public static string GetRuntimeEnvironmentString()
	{
		return null;
	}

	public static string GetBuildEnvironmentString()
	{
		return null;
	}

	public static string GetPlatformString()
	{
		return null;
	}

	private static string GetDistributionString()
	{
		return null;
	}

	private BugReportService()
	{
	}

	public bool CanSubmitFeedback()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CSubmitUserFeedbackWithScreenshot_003Ed__20))]
	public IEnumerator SubmitUserFeedbackWithScreenshot(StringNames bugReportCategory, string email, string comments)
	{
		return null;
	}

	public void SubmitUserFeedback(StringNames bugReportCategory, string email, string comments)
	{
	}

	public void Info(string message, string category)
	{
	}

	public void Debug(string message, string category)
	{
	}

	public void Warning(string message, string category)
	{
	}

	public void Error(string message, string category)
	{
	}

	public void Exception(Exception exception)
	{
	}

	private void SendFeedback(string email, string comments, SentryId eventId)
	{
	}

	private void ConfigureScope(Scope scope)
	{
	}
}
