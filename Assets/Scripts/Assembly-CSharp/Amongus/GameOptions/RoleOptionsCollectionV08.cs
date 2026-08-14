using System.Collections.Generic;
using Hazel;

namespace AmongUs.GameOptions
{
	public class RoleOptionsCollectionV08 : IRoleOptionsCollection
	{
		private readonly Dictionary<RoleTypes, RoleDataV08> roles;

		public static RoleOptionsCollectionV08 Deserialize(MessageReader reader)
		{
			return null;
		}

		public static void Serialize(MessageWriter writer, RoleOptionsCollectionV08 options)
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

		public void AddOrUpdateRole(RoleDataV08 role)
		{
		}

		public void UpdateFrom(RoleOptionsCollectionV08 roleOptionsCollectionV08)
		{
		}

		public void RemoveRole(RoleTypes roleType)
		{
		}
	}
}
