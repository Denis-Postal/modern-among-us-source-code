using System;
using Newtonsoft.Json;

namespace AmongUs.GameOptions
{
	public class GameOptionsJsonConverter : JsonConverter<IGameOptions>
	{
		private readonly GameOptionsFactory optionsFactory;

		public override bool CanWrite => false;

		public override bool CanRead => false;

		public GameOptionsJsonConverter(GameOptionsFactory factory)
		{
		}

		public override void WriteJson(JsonWriter writer, IGameOptions value, JsonSerializer serializer)
		{
		}

		public override IGameOptions ReadJson(JsonReader reader, Type objectType, IGameOptions existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return null;
		}
	}
}
