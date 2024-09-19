using Newtonsoft.Json;

namespace BifitSerializer.Core.Models
{
	[JsonObject]
	public class BifitSign
	{
		[JsonProperty("TIMESTAMP")]
		public string Timestamp { get; set; }

		[JsonProperty("ID_KEY")]
		public string IdKey { get; set; }

		[JsonProperty("GROUP")]
		public int Group { get; set; }

		[JsonProperty("OWNER")]
		public string Owner { get; set; }

		[JsonProperty("OWNER_POSITION")]
		public string OwnerPosition { get; set; }

		[JsonProperty("HW_TOKEN")]
		public string HwToken { get; set; }

		[JsonProperty("SIGN_TYPE")]
		public string SignType { get; set; }
	}
}