namespace AmongUs.AnimationTestScene
{
	public class AnimationTestSceneCosmeticData
	{
		private const string DEFAULT_NAME = "amogus";

		private string name;

		private CrewmateColor color;

		private HatData hat;

		private VisorData visor;

		private SkinData skin;

		private PetData pet;

		private NamePlateData nameplate;

		public string Name => null;

		public CrewmateColor Color => default(CrewmateColor);

		public HatData Hat => null;

		public VisorData Visor => null;

		public SkinData Skin => null;

		public PetData Pet => null;

		public NamePlateData NamePlate => null;

		public byte ColorID => 0;

		public string HatID => null;

		public string VisorID => null;

		public string SkinID => null;

		public string PetID => null;

		public string NamePlateID => null;

		public void SetColor(byte id)
		{
		}

		public void SetColor(CrewmateColor newColor)
		{
		}

		public void SetHat(string id)
		{
		}

		public void SetHat(HatData data)
		{
		}

		public void SetVisor(string id)
		{
		}

		public void SetVisor(VisorData data)
		{
		}

		public void SetSkin(string id)
		{
		}

		public void SetSkin(SkinData data)
		{
		}

		public void SetPet(string id)
		{
		}

		public void SetPet(PetData data)
		{
		}

		public NetworkedPlayerInfo.PlayerOutfit ToOutfit()
		{
			return null;
		}
	}
}
