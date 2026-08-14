using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskAdderGame : Minigame
{
	private enum FolderType
	{
		Tasks = 0,
		Roles = 1
	}

	public TextMeshPro PathText;

	public TaskFolder RootFolderPrefab;

	public TaskAddButton TaskPrefab;

	public Transform TaskParent;

	public List<TaskFolder> Hierarchy;

	public List<Transform> ActiveItems;

	public TaskAddButton RoleButton;

	public float folderWidth;

	public float fileWidth;

	public float lineWidth;

	private TaskFolder Root;

	[Header("Console Controller Navigation")]
	public UiElement BackButton;

	public UiElement FolderBackButton;

	public List<UiElement> ControllerSelectable;

	private string previouslySelectedFolderName;

	public Vector2 SafePositionWorld { get; set; }

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void Begin(PlayerTask t)
	{
	}

	private void PopulateRoot(FolderType folderType, TaskFolder rootFolder, Dictionary<string, TaskFolder> folders, NormalPlayerTask[] taskList = null)
	{
	}

	public void GoToRoot()
	{
	}

	public void GoUpOne()
	{
	}

	public void SetPreviousControllerSelection(string folderName)
	{
	}

	public void ShowFolder(TaskFolder taskFolder)
	{
	}

	private void AddFileAsChild(TaskFolder taskFolder, TaskAddButton item, ref float xCursor, ref float yCursor, ref float maxHeight)
	{
	}
}
