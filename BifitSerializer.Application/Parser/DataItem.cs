namespace BifitSerializer.Application.Parser
{
	public class DataItem
	{
		public string Name { get; set; }
		public Dictionary<string, object> Data { get; set; }

		public DataItem(string name)
		{
			Data = new Dictionary<string, object>();
			Name = name;
		}
	}
}
