using Newtonsoft.Json;

namespace BifitSerializer.Core.Models
{
	[JsonObject]
	public class BifitAuxiliarySection
	{
		[JsonProperty("REMOTE_IP_ADDRESS")]
		public string RemoteIpAddress { get; set; }
	}
}