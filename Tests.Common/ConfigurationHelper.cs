using System.IO;
using Microsoft.Extensions.Configuration;

namespace Tests.Common
{
	public static class ConfigurationHelper
	{
		public static IConfigurationRoot GetConfiguration(string configFile = "appsettings.json")
		{
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile(configFile)
				.Build();

			return configuration;
		}
	}
}
