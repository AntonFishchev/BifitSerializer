using Newtonsoft.Json;

namespace BifitSerializer.Core.Models
{
	[JsonObject]
	public class BifitDocument
	{
		[JsonProperty("DOC_TYPE")]
		public string DocType { get; set; }

		[JsonProperty("DOC_ID")]
		public int DocId { get; set; }

		[JsonProperty("$OWNER")]
		public BifitOwner Owner { get; set; }

		[JsonProperty("$CONTENT")]
		public BifitContent Content { get; set; }

		[JsonProperty("$SIGN")]
		public BifitSign Sign { get; set; }

		[JsonProperty("$AUXILIARY_SECTION")]
		public BifitAuxiliarySection AuxiliarySection { get; set; }
	}
}
