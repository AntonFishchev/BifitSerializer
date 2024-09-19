using Newtonsoft.Json;

namespace BifitSerializer.Core.Models
{
	[JsonObject]
	public class MainDoc
	{
		[JsonProperty("$DOCUMENT")]
		public BifitDocument Document { get; set; }
	}
}
