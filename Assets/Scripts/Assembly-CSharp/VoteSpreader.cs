using System.Collections.Generic;
using UnityEngine;

public class VoteSpreader : MonoBehaviour
{
	public List<SpriteRenderer> Votes;

	public FloatRange VoteRange;

	public int maxVotesBeforeSmoosh;

	public float CounterY;

	public float adjustRate;

	private void Update()
	{
	}

	public void AddVote(SpriteRenderer newVote)
	{
	}
}
