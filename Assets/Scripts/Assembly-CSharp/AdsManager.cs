using System;
using Unity.Services.LevelPlay;

public class AdsManager : DestroyableSingleton<AdsManager>
{
	private string apiKey;

	private string rewardedAdUnitId;

	private LevelPlayRewardedAd rewardedAd;

	private bool initialized;

	private readonly Logger logger;

	private Action<bool> adMenuCallbak;

	private Action<bool> rewardedAdCallback;

	public bool IsInitialized()
	{
		return false;
	}

	public override void Awake()
	{
	}

	public void InitLevelPlay(bool isChild)
	{
	}

	public void RequestATTPermission()
	{
	}

	private void SdkInitializationCompletedEvent(LevelPlayConfiguration config)
	{
	}

	private void SdkInitializationFailedEvent(LevelPlayInitError initError)
	{
	}

	public void CreateRewardedAd(Action<bool> adCallback)
	{
	}

	public void ShowRewardedAd(Action<bool> rewardCallback)
	{
	}

	private void RewardedOnAdLoadedEvent(LevelPlayAdInfo adInfo)
	{
	}

	private void RewardedOnAdLoadFailedEvent(LevelPlayAdError adError)
	{
	}

	private void RewardedOnAdDisplayedEvent(LevelPlayAdInfo adInfo)
	{
	}

	private void RewardedOnAdDisplayFailedEvent(LevelPlayAdInfo adInfo, LevelPlayAdError error)
	{
	}

	private void RewardedOnAdRewardedEvent(LevelPlayAdInfo adInfo, LevelPlayReward adReward)
	{
	}

	private void RewardedOnAdClosedEvent(LevelPlayAdInfo adInfo)
	{
	}

	private void RewardedOnAdClickedEvent(LevelPlayAdInfo adInfo)
	{
	}

	private void RewardedOnAdInfoChangedEvent(LevelPlayAdInfo adInfo)
	{
	}
}
