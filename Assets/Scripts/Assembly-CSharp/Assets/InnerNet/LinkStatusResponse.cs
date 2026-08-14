namespace Assets.InnerNet
{
	public class LinkStatusResponse
	{
		public enum LinkStatus
		{
			Pending = 0,
			Success = 1,
			Error = 2
		}

		public LinkStatus Status;

		public PinRequestError[] Errors;
	}
}
