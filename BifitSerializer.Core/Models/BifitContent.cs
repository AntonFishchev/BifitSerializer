using Newtonsoft.Json;

namespace BifitSerializer.Core.Models
{
	[JsonObject]
	public class BifitContent
	{
		[JsonProperty("CLIENT_COMMENT")]
		public string ClientComment { get; set; }

		[JsonProperty("CURRENCY")]
		public string Currency { get; set; }

		[JsonProperty("AGREEMENT_TEXT")]
		public string AgreementText { get; set; }

		[JsonProperty("NUM_DOC")]
		public int NumDoc { get; set; }

		[JsonProperty("ISO_CURRENCY")]
		public string IsoCurrency { get; set; }

		[JsonProperty("IDCARD_SERIAL")]
		public string IdCardSerial { get; set; }

		[JsonProperty("CLN_INN")]
		public string ClnInn { get; set; }

		[JsonProperty("IDCARD_ISSUE_DATE")]
		public string IdCardIssueDate { get; set; }

		[JsonProperty("AGREEMENT")]
		public int Agreement { get; set; }

		[JsonProperty("CLN_BIRTHDATE")]
		public string ClnBirthdate { get; set; }

		[JsonProperty("CURRENCY_CODE")]
		public int CurrencyCode { get; set; }

		[JsonProperty("IDCARD_ISSUER")]
		public string IdCardIssuer { get; set; }

		[JsonProperty("MAKE_TRANSFER")]
		public int MakeTransfer { get; set; }

		[JsonProperty("BANK_BIC")]
		public string BankBic { get; set; }

		[JsonProperty("DATE_DOC")]
		public string DateDoc { get; set; }

		[JsonProperty("CLN_FACTADDR")]
		public string ClnFactAddr { get; set; }

		[JsonProperty("CLN_PHONECELL")]
		public string ClnPhoneCell { get; set; }

		[JsonProperty("IDCARD_TYPE")]
		public string IdCardType { get; set; }

		[JsonProperty("ACCOUNT_TYPE_NAME")]
		public string AccountTypeName { get; set; }

		[JsonProperty("IDCARD_NUMBER")]
		public string IdCardNumber { get; set; }

		[JsonProperty("CLN_FIO")]
		public string ClnFio { get; set; }

		[JsonProperty("CLN_REGADDR")]
		public string ClnRegAddr { get; set; }

		[JsonProperty("BANK_NAME")]
		public string BankName { get; set; }
	}
}
