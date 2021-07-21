using System;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using IR.Server.Tests.Integration.Helpers;
using IR.Shared.Dtos;
using Xunit;

namespace IR.Server.Tests.Integration.Controllers
{
	public class CommentControllerTests : BaseHttpTest
	{
		[Trait("Integration", "GetCommentsAsync")]
		public class GetCommentsAsync : CommentControllerTests
		{
			[Fact()]
			public async Task GetCommentsAsync_With_With_Two_Comments_Should_Return_Two_results_TestAsync()
			{
				// Arrange

				//var createdPost = new NewCommentDto { CommentDescription = "test", CommenterId = new Guid().ToString(), CommenterName = "Test", ResponseId = 1 };

				//var result = await Client.PostAsync("/comments", createdPost);

				//PostResponse createdPost1 = await CreatePostAsync(new CreatePostRequest
				//{
				//	Name = "Test post2",
				//	Tags = new[] { "testtag2" }
				//});

				//Act

				//var response = await Server.CreateRequest("comment").SendAsync("GET");

				//Assert

				//response.StatusCode.Should().Be(HttpStatusCode.OK);

				//bool returnedPosts = response.Content.ReadAsAsync<List<Data>();

				//returnedPosts.Data.Id.Should().Be(createdPost.Id);

				//returnedPosts.Data.Name.Should().Be("Test post1");

				//returnedPosts.Data.Tags.Single().Name.Should().Be("testtag1");
			}
		}

		[Trait("Integration", "GetCommentByIdAsync")]
		public class GetCommentByIdAsync : CommentControllerTests
		{
			[Theory()]
			[InlineData(1)]
			[InlineData(2)]
			public async Task GetCommentByIdAsync_With_StateUnderTest_Should_Return_NotFound_TestAsync(long id)
			{
				// Arrange


				// Act

				var response = await Server.CreateRequest("comment/comments/" + id).SendAsync("GET");

				// Assert

				response.StatusCode.Should().Be(HttpStatusCode.NotFound);
			}
		}
	}
}