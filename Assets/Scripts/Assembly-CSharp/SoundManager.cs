using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
	private static SoundManager instance;

	[SerializeField]
	private AudioMixer mixer;

	[SerializeField]
	private AudioMixerGroup musicMixer;

	[SerializeField]
	private AudioMixerGroup ambienceMixer;

	[SerializeField]
	private AudioMixerGroup ambienceHighPassMixer;

	[SerializeField]
	private AudioMixerGroup sfxMixer;

	private Dictionary<AudioClip, AudioSource> allSources;

	private List<ISoundPlayer> soundPlayers;

	private static float musicVolume;

	private static float sfxVolume;

	private static float ambienceVolume;

	public static SoundManager Instance => null;

	public static float MusicVolume => 0f;

	public static float AmbienceVolume => 0f;

	public static float SfxVolume => 0f;

	public AudioMixerGroup MusicChannel => null;

	public AudioMixerGroup AmbienceChannel => null;

	public AudioMixerGroup SfxChannel => null;

	public AudioMixerGroup AmbienceHighPassChannel => null;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnAudioSettingsChanged()
	{
	}

	private void UpdateChannelVolumes()
	{
	}

	private void ChangeMusicVolume(float volume)
	{
	}

	private void ChangeAmbienceVolume(float volume)
	{
	}

	private void ChangeSfxVolume(float volume)
	{
	}

	private void SetChannelVolume(float volume, ref float value, string channelName)
	{
	}

	private static float GetCalculatedVolume(float volume)
	{
		return 0f;
	}

	public bool HasNamedSound(string name)
	{
		return false;
	}

	public void StopNamedSound(string name)
	{
	}

	public void StopSound(AudioClip clip)
	{
	}

	public void StopAllSound()
	{
	}

	public AudioSource PlayNamedSound(string name, AudioClip sound, bool loop, AudioMixerGroup channel)
	{
		return null;
	}

	public AudioSource GetNamedSfxSource(string name)
	{
		return null;
	}

	public AudioSource GetNamedAudioSource(string name, AudioMixerGroup channel)
	{
		return null;
	}

	public AudioSource PlayDynamicSound(string name, AudioClip clip, bool loop, DynamicSound.GetDynamicsFunction volumeFunc, AudioMixerGroup channel)
	{
		return null;
	}

	public void CrossFadeSound(string name, AudioClip clip, float maxVolume, float duration = 1.5f)
	{
	}

	public AudioSource PlaySoundImmediate(AudioClip clip, bool loop, float volume = 1f, float pitch = 1f, AudioMixerGroup audioMixer = null)
	{
		return null;
	}

	public bool SoundIsPlaying(AudioClip clip)
	{
		return false;
	}

	public AudioSource PlaySound(AudioClip clip, bool loop, float volume = 1f, AudioMixerGroup audioMixer = null)
	{
		return null;
	}

	public static float GetSoundVolume(Vector2 soundPosition, Vector2 listenerPosition, float falloffStartDistance = 2f, float falloffEndDistance = 6f, float minVolume = 0f)
	{
		return 0f;
	}
}
