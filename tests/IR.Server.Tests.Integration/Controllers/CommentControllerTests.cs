using FluentAssertions;

using IR.Shared.Dtos;
using IR.Shared.Interfaces;
using IR.Shared.Models;

using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace IR.Server.Tests.Integration.Controllers
{
	public class CommentControllerTests : IntegrationTest
	{
		public CommentControllerTests(CustomWebApplicationFactory<Startup> fixture) : base(fixture) { }

		[Trait("Integration", "GetCommentsAsync"), Fact()]
		public async Task GetCommentsAsync_With_With_Two_Comments_Should_Return_One_result_TestAsync()
		{
			// Arrange, Act

			var response = await _client.GetAsync("/comments");

			var result = await _client.GetAndDeserialize<List<CommentDto>>("/comments");

			//Assert

			response.StatusCode.Should().Be(HttpStatusCode.OK);

			result.Should().HaveCount(1);

			result[0].Id.Should().Be(1);

			result[0].CommentDescription.Should().Be("Comment 1");

			result[0].CommenterName.Should().Be("test.tester@tester.com");
		}

		[Trait("Integration", "GetCommentsAsync"), Fact]
		public async Task GetCommentsAsync_With_invalid_config_Should_Fesult_in_a_bad_request_TestAsync()
		{
			// Arrange

			var client = _factory.WithWebHostBuilder(builder =>
			{
				builder.ConfigureServices(services =>
				{
					services.AddTransient<ICommentService, InvalidCommentConfigStub>();
				});
			}).CreateClient(new WebApplicationFactoryClientOptions());

			// Act

			var response = await client.GetAsync("/comments");

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
		}

		[Trait("Integration", "GetCommentByIdAsync"), Theory(), InlineData(2), InlineData(3)]
		public async Task GetCommentByIdAsync_With_Invalid_Ids_Should_Return_NotFound_TestAsync(long id)
		{
			// Arrange, Act

			var response = await _client.GetAsync($"/comments/{id}");

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.NotFound);
		}

		[Trait("Integration", "GetCommentByIdAsync"), Fact]
		public async Task GetCommentByIdAsync_With_Valid_Id_Should_Return_One_Result_TestAsync()
		{
			// Arrange
			
			const long id = 1;
			
			// Act
			
			var response = await _client.GetAsync($"/comment/{id}");
			var result = await _client.GetAndDeserialize<CommentDto>($"/comment/{id}");

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.OK);

			result.Id.Should().Be(id);

			result.CommentDescription.Should().Be("Comment 1");

			result.CommenterName.Should().Be("test.tester@tester.com");
		}
	}

	internal class InvalidCommentConfigStub : ICommentService
	{
		public Task<bool> CommentExistsAsync(long id)
		{
			throw new System.NotImplementedException();
		}

		public Task<CommentDto> CreateCommentAsync(NewCommentDto comment)
		{
			throw new System.NotImplementedException();
		}

		public Task<bool> DeleteCommentAsync(CommentForDeleteDto comment)
		{
			throw new System.NotImplementedException();
		}

		public Task<Comment> EnforceCommentExistenceAsync(long id)
		{
			throw new System.NotImplementedException();
		}

		public Task<CommentDto> GetCommentByIdAsync(long id)
		{
			throw new System.NotImplementedException();
		}

		public Task<IEnumerable<CommentDto>> GetCommentsAsync()
		{
			throw new System.NotImplementedException();
		}

		public Task<bool> UpdateCommentAsync(long id, CommentForUpdateDto comment)
		{
			throw new System.NotImplementedException();
		}
	}
}