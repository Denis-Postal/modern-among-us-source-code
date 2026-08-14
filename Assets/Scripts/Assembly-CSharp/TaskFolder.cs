using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskFolder : MonoBehaviour
{
	public enum FolderColor
	{
		Tan = 0,
		Red = 1,
		Blue = 2
	}

	public string FolderName;

	public TextMeshPro Text;

	public TaskAdderGame Parent;

	public List<TaskFolder> SubFolders;

	public List<NormalPlayerTask> TaskChildren;

	public List<RoleBehaviour> RoleChildren;

	[HideInInspector]
	public PassiveButton Button;

	[SerializeField]
	private ButtonRolloverHandler buttonRolloverHandler;

	[SerializeField]
	private SpriteRenderer folderSpriteRenderer;

	[SerializeField]
	private Color currentFolderColor;

	private void Awake()
	{
	}

	public void Start()
	{
	}

	public void OnClick()
	{
	}

	public void SetFolderColor(FolderColor folderColor)
	{
	}

	internal List<TaskFolder> OrderBy()
	{
		return null;
	}
}
