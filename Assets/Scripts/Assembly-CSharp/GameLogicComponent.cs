using Hazel;

public abstract class GameLogicComponent
{
	protected GameManager Manager;

	public bool IsDirty { get; private set; }

	public GameLogicComponent(GameManager manager)
	{
	}

	public abstract void OnGameStart();

	public abstract void OnGameEnd();

	public abstract void FixedUpdate();

	public abstract void OnDestroy();

	public virtual void OnPlayerDisconnect(PlayerControl pc)
	{
	}

	public virtual void HandleRPC(RpcCalls callId, MessageReader reader)
	{
	}

	public abstract bool Serialize(MessageWriter writer);

	public abstract void Deserialize(MessageReader reader);

	public void SetDirty()
	{
	}

	public void ClearDirtyFlag()
	{
	}
}
