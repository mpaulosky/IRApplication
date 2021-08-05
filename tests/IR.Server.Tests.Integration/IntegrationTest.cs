using Microsoft.Extensions.Configuration;

using Respawn;

using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using Xunit;

namespace IR.Server.Tests.Integration
{
	public abstract class IntegrationTest : IClassFixture<CustomWebApplicationFactory<Startup>>
	{
		protected readonly CustomWebApplicationFactory<Startup> _factory;
		protected readonly HttpClient _client;

		public IntegrationTest(CustomWebApplicationFactory<Startup> fixture)
		{
			_factory = fixture;
			_client = _factory.CreateClient();
		}
	}

	public static class ExtensionMethods
	{
		public static Task<T> GetAndDeserialize<T>(this HttpClient client, string requestUri)
		{
			return client.GetFromJsonAsync<T>(requestUri);
		}
	}
}
