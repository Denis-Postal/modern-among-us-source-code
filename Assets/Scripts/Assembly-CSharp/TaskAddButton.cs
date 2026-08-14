using TMPro;
using UnityEngine;

public class TaskAddButton : MonoBehaviour
{
	public TextMeshPro Text;

	public SpriteRenderer Overlay;

	public SpriteRenderer FileImage;

	public ButtonRolloverHandler RolloverHandler;

	public Sprite CheckImage;

	public Sprite ExImage;

	public PlayerTask MyTask;

	[HideInInspector]
	public PassiveButton Button;

	private RoleBehaviour role;

	public Vector2 SafePositionWorld { get; set; }

	public RoleBehaviour Role
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void Start()
	{
	}

	public void Update()
	{
	}

	public void AddTask()
	{
	}

	public static void AddTaskToPlayer(PlayerTask taskPrefab)
	{
	}

	private PlayerTask FindTaskByType()
	{
		return null;
	}
}
