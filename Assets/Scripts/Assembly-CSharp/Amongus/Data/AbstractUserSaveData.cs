namespace AmongUs.Data
{
	public abstract class AbstractUserSaveData : AbstractSaveData
	{
		protected abstract string FileName { get; }

		protected override void HandleSave()
		{
		}

		protected override void HandleLoad()
		{
		}

		protected override void HandleDelete()
		{
		}

		protected override bool HandleDoesFileExist()
		{
			return false;
		}

		private string GetFileName()
		{
			return null;
		}

		private bool ShouldIncludeUserIdInPath()
		{
			return false;
		}
	}
}
