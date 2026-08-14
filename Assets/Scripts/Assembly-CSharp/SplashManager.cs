using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SplashManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CInitializeRefdata_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SplashManager _003C_003E4__this;

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
		public _003CInitializeRefdata_003Ed__10(int _003C_003E1__state)
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

	[SerializeField]
	private SplashErrorPopup errorPopup;

	[SerializeField]
	private SceneChanger sceneChanger;

	[SerializeField]
	private float minimumSecondsBeforeSceneChange;

	[SerializeField]
	private LogoAnimFinish logoAnimFinish;

	[SerializeField]
	private GameObject loadingObject;

	private bool doneLoadingRefdata;

	private bool startedSceneLoad;

	private float startTime;

	private bool logoAnimationFinished;

	private void Start()
	{
		startTime = Time.time;
		doneLoadingRefdata = true;
		logoAnimationFinished = logoAnimFinish == null;
		if (logoAnimFinish != null)
		{
			logoAnimFinish.FinishLogoAnim += OnLogoAnimFinished;
		}
		if (loadingObject != null)
		{
			loadingObject.SetActive(true);
		}
		if (sceneChanger != null)
		{
			sceneChanger.BeginLoadingScene();
		}
	}

	private void Update()
	{
		if (!logoAnimationFinished && Time.time - startTime >= minimumSecondsBeforeSceneChange + 2f)
		{
			logoAnimationFinished = true;
		}
		CheckLoadingRefData();
	}

	[IteratorStateMachine(typeof(_003CInitializeRefdata_003Ed__10))]
	private IEnumerator InitializeRefdata()
	{
		doneLoadingRefdata = true;
		yield break;
	}

	private void CheckLoadingRefData()
	{
		if (startedSceneLoad || !doneLoadingRefdata || !logoAnimationFinished)
		{
			return;
		}
		if (Time.time - startTime < minimumSecondsBeforeSceneChange)
		{
			return;
		}
		startedSceneLoad = true;
		if (loadingObject != null)
		{
			loadingObject.SetActive(false);
		}
		if (sceneChanger != null)
		{
			sceneChanger.AllowFinishLoadingScene();
		}
		else
		{
			SceneChanger.ChangeScene("MainMenu");
		}
	}

	private void OnLogoAnimFinished()
	{
		logoAnimationFinished = true;
	}

	private void OnDestroy()
	{
		if (logoAnimFinish != null)
		{
			logoAnimFinish.FinishLogoAnim -= OnLogoAnimFinished;
		}
	}
}
