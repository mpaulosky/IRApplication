using IR.Shared.Data;
using IR.Shared.Dtos;
using IR.Shared.Extensions;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

using Xunit;

namespace IR.Server.Tests.Integration
{
	public class IntegrationTest : IAsyncLifetime
	{
		protected HttpClient TestClient;
		protected WebApplicationFactory<Startup> appFactory;
		public DataContext Db { get; private set; }

		public async Task InitializeAsync()
		{
			appFactory = new WebApplicationFactory<Startup>()
					.WithWebHostBuilder(builder =>
					{
						builder.ConfigureServices(services =>
						{
							var descriptor = services.SingleOrDefault(
									d => d.ServiceType ==
											typeof(DbContextOptions<DataContext>));

							services.Remove(descriptor);

							services.AddDbContext<DataContext>(options =>
							{
								options.UseInMemoryDatabase("InMemoryDbForTesting");
							});

							var sp = services.BuildServiceProvider();

							using var scope = sp.CreateScope();
							var scopedServices = scope.ServiceProvider;
							Db = scopedServices.GetRequiredService<DataContext>();
							var logger = scopedServices
									.GetRequiredService<ILogger<CustomWebApplicationFactory<Startup>>>();

							Db.Database.EnsureDeleted();
							Db.Database.EnsureCreated();

							try
							{
								Utilities.InitializeDbForTests(Db);
							}
							catch (Exception ex)
							{
								logger.LogError(ex, "An error occurred seeding the " +
										"database with test messages. Error: {Message}", ex.Message);
							}
						});
					});


			TestClient = appFactory.CreateClient();

		}

		public async Task DisposeAsync()
		{
			appFactory.Dispose();
			TestClient.Dispose();
		}

		//protected async Task AuthenticateAsync()
		//{
		//	TestClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", await GetJwtAsync());
		//}

		protected async Task<HttpResponseMessage> CreateCommentAsync(NewCommentDto request)
		{
			return await TestClient.PostAsJsonAsync(ApiRoutes.Comments.CreateCommentAsync, request);
		}

		protected async Task<HttpResponseMessage> CreateIssueAsync(NewIssueDto request)
		{
			return await TestClient.PostAsJsonAsync(ApiRoutes.Issues.CreateIssueAsync, request);
		}

		protected async Task<HttpResponseMessage> CreateResponseAsync(NewResponseDto request)
		{
			return await TestClient.PostAsJsonAsync(ApiRoutes.Responses.CreateResponseAsync, request);
		}

		//private async Task<string> GetJwtAsync()
		//{
		//	var response = await TestClient.PostAsJsonAsync(ApiRoutes.Identity.Register, new UserRegistrationRequest
		//	{
		//		Email = "test@integration.com",
		//		Password = "SomePass1234!"
		//	});

		//	var registrationResponse = await response.Content.ReadAsAsync<AuthSuccessResponse>();
		//	return registrationResponse.Token;
		//}
	}
}
