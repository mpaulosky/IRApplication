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
	public class CommentsControllerTestsIntegration : IntegrationTest
	{
		[Fact(DisplayName = "GetCommentsAsync Should Return All")]
		public async Task GetCommentsAsync_Should_Return_One_result_TestAsync()
		{
			// Arrange

			// Act

			var response = await TestClient.GetAsync(ApiRoutes.Comments.GetCommentsAsync);

			//Assert

			response.StatusCode.Should().Be(HttpStatusCode.OK);

			var result = await response.Content.ReadFromJsonAsync<List<CommentDto>>();

			result.Should().HaveCount(1);

			result[0].Id.Should().Be(1);

			result[0].CommentDescription.Should().Be("Comment 1");

			result[0].CommenterName.Should().Be("test.tester@tester.com");
		}

		[Fact(DisplayName = "GetCommentsAsync with invalid config")]
		public async Task GetCommentsAsync_With_invalid_config_Should_Fesult_in_a_bad_request_TestAsync()
		{
			// Arrange

			var client = appFactory.WithWebHostBuilder(builder =>
			{
				builder.ConfigureServices(services =>
				{
					services.AddTransient<ICommentService, InvalidCommentConfigStub>();
				});
			}).CreateClient(new WebApplicationFactoryClientOptions());

			// Act

			var response = await client.GetAsync(ApiRoutes.Comments.GetCommentsAsync);

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
		}

		[Fact(DisplayName = "GetCommentByIdAsync with invalid Id")]
		public async Task GetCommentByIdAsync_With_Invalid_Ids_Should_Return_NotFound_TestAsync()
		{
			// Arrange

			const long id = -1;

			// Act

			var response = await TestClient.GetAsync(ApiRoutes.Comments.GetCommentByIdAsync.Replace("{id}", id.ToString()));

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.NotFound);
		}

		[Fact(DisplayName = "GetCommentByIdAsync with valid Id")]
		public async Task GetCommentByIdAsync_With_Valid_Id_Should_Return_One_Result_TestAsync()
		{
			// Arrange

			const long id = 1;

			// Act

			var response = await TestClient.GetAsync(ApiRoutes.Comments.GetCommentByIdAsync.Replace("{id}", id.ToString()));

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.OK);

			var result = await response.Content.ReadFromJsonAsync<CommentDto>();

			result.Id.Should().Be(id);

			result.CommentDescription.Should().Contain("Comment 1");

			result.CommenterName.Should().Be("test.tester@tester.com");
		}

		[Fact(DisplayName = "CreateCommentAsync")]
		public async Task CreateCommentAsync_With_Valid_Entry_Should_Return_HttpStatusCode_Created_TestAsync()
		{
			// Arrange

			var thisDate = DateTimeOffset.UtcNow;

			var newComment = new NewCommentDto { CommentDescription = "Comment 2", CommenterId = "C8940D76-6496-4727-AA38-5C20FDC907C7", CommenterName = "test.tester@tester.com", IsDeleted = false, ResponseId = 1, DateAddedUtc = thisDate, DateModifiedUtc = thisDate };

			// Act

			var response = await TestClient.PostAsJsonAsync(ApiRoutes.Comments.CreateCommentAsync, newComment);

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.Created);

			response.Headers.Location.Should().Be("https://localhost:44368/comments/2");
		}

		[Fact(DisplayName = "UpdateCommentAsync")]
		public async Task UpdateCommentAsync_With_Valid_Values_Should_Return_HttpStatusCode_NoContent_TestAsync()
		{
			// Arrange

			var thisDate = DateTimeOffset.UtcNow;

			var updateComment = new CommentForUpdateDto() { Id = 1, CommentDescription = "Comment 1 Updated", CommenterId = new Guid().ToString(), IsDeleted = false, CommenterName = "test.tester@tester.com", DateModifiedUtc = thisDate };

			// Act

			var response = await TestClient.PutAsJsonAsync(ApiRoutes.Comments.UpdateCommentAsync.Replace("{id}", updateComment.Id.ToString()), updateComment);

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.NoContent);
		}

		[Fact(DisplayName = "DeleteCommentAsync")]
		public async Task DeleteCommentAsync_With_With_Valid_Comment_Should_Return_HttpStatusCode__TestAsync()
		{
			// Arrange

			var commentToDelete = new CommentForDeleteDto(1, true);

			// Act

			var response = await TestClient.PutAsJsonAsync(ApiRoutes.Comments.DeleteCommentAsync, commentToDelete);

			// Assert

			response.StatusCode.Should().Be(HttpStatusCode.NoContent);
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