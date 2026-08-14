using System.Collections.Generic;
using System.IO;
using Hazel;

namespace AmongUs.GameOptions
{
	public class LegacyRoleOptionsCollection : IRoleOptionsCollection
	{
		public bool ShapeshifterLeaveSkin;

		public float ShapeshifterCooldown;

		public float ShapeshifterDuration;

		public float ScientistCooldown;

		public float ScientistBatteryCharge;

		public float GuardianAngelCooldown;

		public float ProtectionDurationSeconds;

		public bool ImpostorsCanSeeProtect;

		public float EngineerCooldown;

		public float EngineerInVentMaxTime;

		private Dictionary<RoleTypes, RoleRate> roleRates;

		public static LegacyRoleOptionsCollection Deserialize(BinaryReader reader)
		{
			return null;
		}

		public static LegacyRoleOptionsCollection Deserialize(MessageReader reader)
		{
			return null;
		}

		public void Serialize(MessageWriter writer)
		{
		}

		public static void Serialize(BinaryWriter writer, LegacyRoleOptionsCollection roleOptions)
		{
		}

		public int GetNumPerGame(RoleTypes role)
		{
			return 0;
		}

		public int GetChancePerGame(RoleTypes role)
		{
			return 0;
		}

		public void SetRoleRate(RoleTypes role, int maxCount, int chance)
		{
		}

		public void SetRoleRecommended(RoleTypes roleTYpe)
		{
		}
	}
}
