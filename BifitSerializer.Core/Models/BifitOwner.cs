using Newtonsoft.Json;

namespace BifitSerializer.Core.Models
{
	[JsonObject]
	public class BifitOwner
	{
		[JsonProperty("CLIENT_ID")]
		public int ClientId { get; set; }

		[JsonProperty("EXT_CLIENT_ID")]
		public int ExtClientId { get; set; }
	}
}