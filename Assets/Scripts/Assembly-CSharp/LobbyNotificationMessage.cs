using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LobbyNotificationMessage : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer Icon;

	[SerializeField]
	private TextMeshPro Text;

	private float alphaTimer;

	private float showDuration;

	private float fadeDuration;

	private Action onDestroy;

	private Color textColor;

	private List<SupportedLangs> languagesToBold;

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetUp(string item, Sprite icon, Color textColor, Action onDestroy)
	{
	}

	public void UpdateMessage(string item)
	{
	}
}
