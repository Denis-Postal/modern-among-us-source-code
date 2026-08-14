using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace AmongUs.Data.Player
{
	[JsonObject(MemberSerialization.OptIn)]
	public class PlayerCustomizationData : AbstractSaveDataGroup
	{
		public const string DEFAULT_NAME = "";

		public const byte DEFAULT_COLOR_ID = 0;

		public const string DEFAULT_PET = "";

		public const string DEFAULT_HAT = "";

		public const string DEFAULT_SKIN = "";

		public const string DEFAULT_VISOR = "";

		public const string DEFAULT_NAME_PLATE = "";

		[JsonProperty("name")]
		private string name;

		[JsonProperty("colorID")]
		private byte colorID;

		[JsonProperty("pet")]
		private string pet;

		[JsonProperty("hat")]
		private string hat;

		[JsonProperty("skin")]
		private string skin;

		[JsonProperty("visor")]
		private string visor;

		[JsonProperty("namePlate")]
		private string namePlate;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public byte Color
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string Pet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Hat
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Skin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Visor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NamePlate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action OnNameChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnColorChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnPetChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnHatChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnSkinChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnVisorChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnNamePlateChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}
	}
}
