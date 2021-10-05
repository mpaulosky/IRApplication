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
	public class IssuesControllerTestsIntegration : IntegrationTest
	{
		[Fact(DisplayName = "GetIssuesAsync Should Return All")]
		public async Task GetIssuesAsync_Should_Return_One_result_TestAsync()
		{
			// Arrange

			// Act

			var response = await TestClient.GetAsync(ApiRoutes.Issues.GetIssuesAsync);

			//Assert

			response.StatusCode.Should().Be(HttpStatusCode.OK);

			var result = await response.Content.ReadFromJsonAsync<List<IssueDto>>();

			result.Should().HaveCount(3);

			result[0].Id.Should().Be(1);

			result[0].IssueDescription.Should().Be("Issue 1");

			result[0].InitiatorName.Should().Be("test.tester1@tester.com");
		}

		[Fact(DisplayName = "GetIssuesAsync with invalid config")]
		public async Task GetIssuesAsync_With_invalid_config_Should_Fesult_in_a_bad_request_TestAsync()
		{
			// Arrange

			var client = appFactory.WithWebHostBuilder(builder =>
			{
				builder.ConfigureServices(services =>
				{
					services.AddTransient<IIssueService, InvalidIssueConfigStub>();
				});
			}).CreateClient(new WebApplicationFactoryClientOptions());

			// Act

			var response = await client.GetAsync(ApiRoutes.Issues.GetIssuesAsync);

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
		}

		[Fact(DisplayName = "GetIssueByIdAsync with invalid Id")]
		public async Task GetIssueByIdAsync_With_Invalid_Ids_Should_Return_NotFound_TestAsync()
		{
			// Arrange

			const long id = -1;

			// Act

			var response = await TestClient.GetAsync(ApiRoutes.Issues.GetIssueByIdAsync.Replace("{id}", id.ToString()));

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.NotFound);
		}

		[Fact(DisplayName = "GetIssueByIdAsync with valid Id")]
		public async Task GetIssueByIdAsync_With_Valid_Id_Should_Return_One_Result_TestAsync()
		{
			// Arrange

			const long id = 1;

			// Act

			var response = await TestClient.GetAsync(ApiRoutes.Issues.GetIssueByIdAsync.Replace("{id}", id.ToString()));

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.OK);

			var result = await response.Content.ReadFromJsonAsync<IssueDto>();

			result.Id.Should().Be(id);

			result.IssueDescription.Should().Contain("Issue 1");

			result.InitiatorName.Should().Be("test.tester1@tester.com");
		}

		[Fact(DisplayName = "CreateIssueAsync")]
		public async Task CreateIssueAsync_With_Valid_Entry_Should_Return_HttpStatusCode_Created_TestAsync()
		{
			// Arrange

			var thisDate = DateTimeOffset.UtcNow;

			var newIssue = new NewIssueDto { IssueDescription = "Issue 4", InitiatorId = "C8940D76-6496-4727-AA38-5C20FDC907C7", InitiatorName = "test.tester4@tester.com", DateAddedUtc = thisDate, DateModifiedUtc = thisDate };

			// Act

			var response = await TestClient.PostAsJsonAsync(ApiRoutes.Issues.CreateIssueAsync, newIssue);

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.Created);

			response.Headers.Location.Should().Be("https://localhost:44368/issues/7");
		}

		[Fact(DisplayName = "UpdateIssueAsync")]
		public async Task UpdateIssueAsync_With_Valid_Values_Should_Return_HttpStatusCode_NoContent_TestAsync()
		{
			// Arrange

			var thisDate = DateTimeOffset.UtcNow;

			var updateIssue = new IssueForUpdateDto() { Id = 3, IssueDescription = "Issue 3 Updated", InitiatorId = new Guid().ToString(), InitiatorName = "test.tester3@tester.com", DateModifiedUtc = thisDate };

			// Act

			var response = await TestClient.PutAsJsonAsync(ApiRoutes.Issues.UpdateIssueAsync.Replace("{id}", updateIssue.Id.ToString()), updateIssue);

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.NoContent);
		}

		[Fact(DisplayName = "DeleteIssueAsync")]
		public async Task DeleteIssueAsync_With_With_Valid_Issue_Should_Return_HttpStatusCode__TestAsync()
		{
			// Arrange

			var IssueToDelete = new IssueForDeleteDto(3, true);

			// Act

			var response = await TestClient.PutAsJsonAsync(ApiRoutes.Issues.DeleteIssueAsync, IssueToDelete);

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.NoContent);
		}
	}

	internal class InvalidIssueConfigStub : IIssueService
	{
		public Task<IssueDto> CreateIssueAsync(NewIssueDto issue)
		{
			throw new NotImplementedException();
		}

		public Task<bool> DeleteIssueAsync(IssueForDeleteDto issue)
		{
			throw new NotImplementedException();
		}

		public Task<Issue> EnforceIssueExistenceAsync(long id)
		{
			throw new NotImplementedException();
		}

		public Task<IssueDto> GetIssueByIdAsync(long id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<IssueDto>> GetIssuesAsync()
		{
			throw new NotImplementedException();
		}

		public Task<bool> IssueExistsAsync(long id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateIssueAsync(long id, IssueForUpdateDto issue)
		{
			throw new NotImplementedException();
		}
	}
}
