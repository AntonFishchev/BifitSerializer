namespace BifitSerializer.Core.Interfaces
{
	public interface IBifitJsonParser
	{
		public static abstract string ParseBifitToJson(string bifitDocument);

		public static abstract string ParseJsonToBifit(string json);
	}
}
