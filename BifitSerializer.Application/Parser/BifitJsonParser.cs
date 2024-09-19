using BifitSerializer.Core.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace BifitSerializer.Application.Parser
{
	public class BifitJsonParser : IBifitJsonParser
	{
		public static string ParseBifitToJson(string bifitDocument)
		{
			var queue = new List<DataItem>();
			DataItem currentObject = null;
			var result = new Dictionary<string, object>();

			var lines = bifitDocument.Split('\n').Select(l => l.Trim());

			foreach (var line in lines)
			{
				if (line.StartsWith("$"))
				{
					if (currentObject == null)
					{
						currentObject = new DataItem(line);
						continue;
					}

					if (line.EndsWith("_END"))
					{
						if (queue.Count == 0)
						{
							result.Add(currentObject.Name, currentObject.Data);
							continue;
						}

						var last = queue.LastOrDefault();
						last.Data.Add(currentObject.Name, currentObject.Data);
						queue.RemoveAt(queue.Count - 1);
						currentObject = last;

						continue;
					}

					queue.Add(currentObject);
					currentObject = new DataItem(line);
				}
				else
				{
					var parts = line.Split('=');
					currentObject.Data.Add(parts[0], parts[1]);
				}
			}

			return JsonConvert.SerializeObject(result, Formatting.Indented);
		}

		public static string ParseJsonToBifit(string json)
		{
			var sb = new StringBuilder();

			JObject parsedJson = JObject.Parse(json);
			ParseJson(parsedJson, sb);

			return sb.ToString();
		}

		private static void ParseJson(JObject obj, StringBuilder sb)
		{
			foreach (var property in obj.Properties())
			{
				if (property.Value == null)
				{
					return;
				}

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
}
