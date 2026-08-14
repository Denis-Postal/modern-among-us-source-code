using System.Collections.Generic;
using Hazel;

namespace AmongUs.GameOptions
{
	public class RoleOptionsCollectionV07 : IRoleOptionsCollection
	{
		private readonly Dictionary<RoleTypes, RoleDataV07> roles;

		public static RoleOptionsCollectionV07 Deserialize(MessageReader reader)
		{
			return null;
		}

		public static void Serialize(MessageWriter writer, RoleOptionsCollectionV07 options)
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

		public void SetRoleRecommended(RoleTypes role)
		{
		}

		public bool TryGetRoleOptions<T>(RoleTypes type, out T roleData) where T : class
		{
			roleData = null;
			return false;
		}

		public bool TryGetRoleRates(RoleTypes type, out RoleRate roleRates)
		{
			roleRates = default(RoleRate);
			return false;
		}

		public void AddOrUpdateRole(RoleDataV07 role)
		{
		}

		public void RemoveRole(RoleTypes roleType)
		{
		}
	}
}
