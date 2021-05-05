using System.Text.Json;
using System.Threading.Tasks;

namespace WebApplication1.Server.Helpers
{
	public static class FormatterHelper
	{
		public static string Serialize(object value)
		{
			var options = new JsonSerializerOptions
			{
				WriteIndented = true
			};

			return JsonSerializer.Serialize(value, options);
		}
	}
}
