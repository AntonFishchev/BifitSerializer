using BifitSerializer.Application.Parser;
using BifitSerializer.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

class Program
{
	const string str = """
	$DOCUMENT
	DOC_TYPE=open_account_contract
	DOC_ID=123123
	$OWNER
	CLIENT_ID=1212
	EXT_CLIENT_ID=1231233
	$OWNER_END
	$CONTENT
	CLIENT_COMMENT=
	CURRENCY=RUR
	AGREEMENT_TEXT=Согласен
	NUM_DOC=1
	ISO_CURRENCY=RUR
	IDCARD_SERIAL=1212
	CLN_INN=321346456456
	IDCARD_ISSUE_DATE=01.02.2002
	AGREEMENT=1
	CLN_BIRTHDATE=15.08.1986
	CURRENCY_CODE=810
	IDCARD_ISSUER=20 ОТДЕЛОМ МИЛИЦИИ
	MAKE_TRANSFER=0
	BANK_BIC=123123123
	DATE_DOC=28.08.2024
	CLN_FACTADDR=Российская Федерация, 140105, Московская обл, г. Пас, Ленина ул, д. 16, кв. 54
	CLN_PHONECELL=+79263451183
	IDCARD_TYPE=Паспорт гражданина РФ
	ACCOUNT_TYPE_NAME=Текущий -- Накопительный
	IDCARD_NUMBER=129297
	CLN_FIO=Иванов Иван Иванович
	CLN_REGADDR=Российская Федерация, 140105, Московская обл, г. Пас, Ленина ул, д. 16, кв. 54
	BANK_NAME=ООО г. Москва
	$CONTENT_END
	$SIGN
	TIMESTAMP=28.08.2024 11:11:11.000
	ID_KEY=656565656465656
	GROUP=0
	OWNER=Иванов Иван Иванович
	OWNER_POSITION=
	HW_TOKEN=
	SIGN_TYPE=SMS
	$SIGN_END
	$AUXILIARY_SECTION
	REMOTE_IP_ADDRESS=192.168.123.12
	$AUXILIARY_SECTION_END
	$DOCUMENT_END
	""";

	const string test_str = """
	$DOCUMENT
	DOC_TYPE=open_account_contract
	$OWNER
	OWNER_TYPE=oasdfract
	$OWNER_END
	$DOCUMENT_END
	""";

	static void Main()
	{
		var doc = str;
		Console.WriteLine("Исходный документ Bifir:\n");
		Console.WriteLine(doc);
		Console.WriteLine("\n----------\n");

		var doc_json = BifitJsonParser.ParseBifitToJson(doc);
		Console.WriteLine("Спаршенный JSON из исходногого документа:\n");
		Console.WriteLine(doc_json);
		Console.WriteLine("\n----------\n");

		Console.WriteLine("Десериализованный и сериализованный спаршенный JSON:\n");
		var doc_obj = JsonConvert.DeserializeObject<MainDoc>(doc_json);
		var doc_obj_json = JsonConvert.SerializeObject(doc_obj, Formatting.Indented);
		Console.WriteLine(doc_obj_json);
		Console.WriteLine("\n----------\n");

		Console.WriteLine("Спаршенный Bifir из предыдущего JSON:\n");
		var doc_bifit = BifitJsonParser.ParseJsonToBifit(doc_obj_json);
		Console.WriteLine(doc_bifit);

		//string json = @"
		//      {
		//        ""$DOCUMENT"": {
		//          ""DOC_TYPE"": ""open_account_contract"",
		//          ""$OWNER"": {
		//            ""OWNER_TYPE"": ""oasdfract""
		//          }
		//        }
		//      }";

		//JObject parsedJson = JObject.Parse(doc_json);
		//var sb = new StringBuilder();
		//ParseJson(parsedJson, sb);

		//Console.WriteLine("res:");
		//Console.WriteLine(sb.ToString());
	}

	static void ParseJson(JObject obj, StringBuilder sb)
	{
		foreach (var property in obj.Properties())
		{
			if (property.Name.StartsWith("$"))
			{
				sb.AppendLine($"{property.Name}");
				ParseJson((JObject)property.Value, sb);
				sb.AppendLine($"{property.Name}_END");
			}
			else
			{
				sb.AppendLine($"{property.Name}={property.Value}");
			}
		}
	}
}