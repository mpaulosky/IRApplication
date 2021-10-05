using FluentAssertions;

using IR.Shared.Dtos;
using IR.Shared.Extensions;
using IR.Shared.Interfaces;
using IR.Shared.Models;

using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;

using Xunit;

namespace IR.Server.Tests.Integration.Controllers
{
	public class ResponsesControllerTestsIntegration : IntegrationTest
	{
		[Fact(DisplayName = "GetResponsesAsync Should Return All")]
		public async Task GetResponsesAsync_Should_Return_One_result_TestAsync()
		{
			// Arrange

			Utilities.InitializeDbForTests(Db);

			// Act

			var response = await TestClient.GetAsync(ApiRoutes.Responses.GetResponsesAsync);

			//Assert

			response.StatusCode.Should().Be(HttpStatusCode.OK);

			var result = await response.Content.ReadFromJsonAsync<List<ResponseDto>>();

			result.Should().HaveCount(3);

			result[0].Id.Should().Be(1);

			result[0].ResponseDescription.Should().Be("Response 1");

			result[0].ResponderName.Should().Be("test.tester@tester.com");
		}

		[Fact(DisplayName = "GetResponsesAsync with invalid config")]
		public async Task GetResponsesAsync_With_invalid_config_Should_Fesult_in_a_bad_request_TestAsync()
		{
			// Arrange

			var client = appFactory.WithWebHostBuilder(builder =>
			{
				builder.ConfigureServices(services =>
				{
					services.AddTransient<IResponseService, InvalidReferenceConfigStub>();
				});
			}).CreateClient(new WebApplicationFactoryClientOptions());

			// Act

			var response = await client.GetAsync(ApiRoutes.Responses.GetResponsesAsync);

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
		}

		[Fact(DisplayName = "GetResponseByIdAsync with invalid Id")]
		public async Task GetResponseByIdAsync_With_Invalid_Ids_Should_Return_NotFound_TestAsync()
		{
			// Arrange

			const long id = -1;

			// Act

			var response = await TestClient.GetAsync(ApiRoutes.Responses.GetResponseByIdAsync.Replace("{id}", id.ToString()));

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.NotFound);
		}

		[Fact(DisplayName = "GetResponseByIdAsync with valid Id")]
		public async Task GetResponseByIdAsync_With_Valid_Id_Should_Return_One_Result_TestAsync()
		{
			// Arrange

			const long id = 1;

			// Act

			var response = await TestClient.GetAsync(ApiRoutes.Responses.GetResponseByIdAsync.Replace("{id}", id.ToString()));

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.OK);

			var result = await response.Content.ReadFromJsonAsync<ResponseDto>();

			result.Id.Should().Be(id);

			result.ResponseDescription.Should().Contain("Response 1");

			result.ResponderName.Should().Be("test.tester@tester.com");
		}

		[Fact(DisplayName = "CreateResponseAsync")]
		public async Task CreateResponseAsync_With_Valid_Entry_Should_Return_HttpStatusCode_Created_TestAsync()
		{
			// Arrange

			var thisDate = DateTimeOffset.UtcNow;

			var newResponse = new NewResponseDto 
			{
				ResponseDescription = "Response 3",
				ResponderId = "C8940D76-6496-4727-AA38-5C20FDC907C7",
				ResponderName = "test.tester3@tester.com",
				IsDeleted = false,
				DateAddedUtc = thisDate,
				DateModifiedUtc = thisDate
			};

			// Act

			var response = await TestClient.PostAsJsonAsync(ApiRoutes.Responses.CreateResponseAsync, newResponse);

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.Created);

			response.Headers.Location.Should().Be("https://localhost:44368/responses/5");
		}

		[Fact(DisplayName = "UpdateResponseAsync")]
		public async Task UpdateResponseAsync_With_Valid_Values_Should_Return_HttpStatusCode_NoContent_TestAsync()
		{
			// Arrange

			var thisDate = DateTimeOffset.UtcNow;

			var updateResponse = new ResponseForUpdateDto() 
			{
				Id = 1,
				ResponseDescription = "Response 1 Updated",
				ResponderId = new Guid().ToString(),
				IsDeleted = false,
				ResponderName = "test.tester@tester.com",
				DateModifiedUtc = thisDate
			};

			// Act

			var response = await TestClient.PutAsJsonAsync(ApiRoutes.Responses.UpdateResponseAsync.Replace("{id}", updateResponse.Id.ToString()), updateResponse);

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.NoContent);
		}

		[Fact(DisplayName = "DeleteResponseAsync")]
		public async Task DeleteResponseAsync_With_With_Valid_Response_Should_Return_HttpStatusCode__TestAsync()
		{
			// Arrange

			var ResponseToDelete = new ResponseForDeleteDto(2, true);

			// Act

			var response = await TestClient.PutAsJsonAsync(ApiRoutes.Responses.DeleteResponseAsync, ResponseToDelete);

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.NoContent);
		}
	}
	internal class InvalidReferenceConfigStub : IResponseService
	{
		public Task<ResponseDto> CreateResponseAsync(NewResponseDto response)
		{
			throw new NotImplementedException();
		}

		public Task<bool> DeleteResponseAsync(ResponseForDeleteDto response)
		{
			throw new NotImplementedException();
		}

		public Task<Response> EnforceResponseExistenceAsync(long id)
		{
			throw new NotImplementedException();
		}

		public Task<ResponseDto> GetResponseByIdAsync(long id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<ResponseDto>> GetResponsesAsync()
		{
			throw new NotImplementedException();
		}

		public Task<bool> ResponseExistsAsync(long id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateResponseAsync(long id, ResponseForUpdateDto response)
		{
			throw new NotImplementedException();
		}
	}
}
