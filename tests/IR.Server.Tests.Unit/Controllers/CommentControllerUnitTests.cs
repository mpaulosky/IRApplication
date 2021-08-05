using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using IR.Server.Controllers;
using IR.Shared.Dtos;
using IR.Shared.Infrastructure;
using IR.Shared.Interfaces;
using IR.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

using TestHelpers;

using Xunit;

namespace IR.Server.Tests.Unit.Controllers
{
	public class CommentControllerUnitTests
	{
		private CommentController ControllerUnderTest { get; }

		private Mock<ICommentService> CommentServiceMock { get; }

		private Mock<ILogger<CommentController>> LoggerMock { get; }

		public CommentControllerUnitTests()
		{
			LoggerMock = new Mock<ILogger<CommentController>>();

			CommentServiceMock = new Mock<ICommentService>();

			ControllerUnderTest = new(CommentServiceMock.Object, LoggerMock.Object);
		}

		public class GetCommentsAsync : CommentControllerUnitTests
		{
			[Trait("Unit Tests", "GetCommentsAsync"), Fact(DisplayName = "GetCommentsAsync Returns All Comments")]
			public async Task GetCommentsAsync_Should_Return_All_Comments_TestAsync()
			{
				// Arrange

				var expectedComments = new List<CommentDto>
				{
					new CommentDto{Id = 1, CommentDescription = "Test1", CommenterId = new Guid().ToString(), CommenterName = "Tester", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, IsDeleted = false },
					new CommentDto{Id = 2, CommentDescription = "Test2", CommenterId = new Guid().ToString(), CommenterName = "Tester", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, IsDeleted = false },
					new CommentDto{Id = 3, CommentDescription = "Test3", CommenterId = new Guid().ToString(), CommenterName = "Tester", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, IsDeleted = false }
				};

				var expectedLog = "Returned all comments from database";

				CommentServiceMock
					.Setup(x => x.GetCommentsAsync())
					.ReturnsAsync(expectedComments);

				// Act

				var result = await ControllerUnderTest.GetCommentsAsync();

				// Assert

				result.Should().BeOfType<OkObjectResult>();

				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;

				Assert.Same(expectedComments, content.Value);
			}

			[Trait("Unit Tests", "GetCommentsAsync"), Fact(DisplayName = "GetCommentsAsync With Error")]
			public async Task GetCommentsAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				const string expectedLog = "Something went wrong inside GetCommentsAsync action: Some Error";
				const string expectedValue = "Internal server error";

				CommentServiceMock
					.Setup(x => x.GetCommentsAsync())
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.GetCommentsAsync();

				// Assert

				result.Should().BeOfType<ObjectResult>();

				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;

				content.StatusCode.Should().Be(500);

				content.Value.Should().Be(expectedValue);
			}
		}

		public class GetCommentByIdAsync : CommentControllerUnitTests
		{
			[Trait("Unit Tests", "GetCommentByIdAsync"), Fact()]
			public async Task GetCommentByIdAsync_With_A_Valid_Id_Should_Return_OkObjectResult_with_a_Comment_Test()
			{
				// Arrange

				var expectedComment = new CommentDto { Id = 1, CommentDescription = "Test1", CommenterName = "Tester", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, IsDeleted = false };

				var expectedLog = "Returned comment with Id: 1 from database";

				CommentServiceMock
					.Setup(x => x.GetCommentByIdAsync(expectedComment.Id))
					.ReturnsAsync(expectedComment);

				// Act

				var result = await ControllerUnderTest.GetCommentByIdAsync(expectedComment.Id);

				// Assert

				result.Should().BeOfType<OkObjectResult>();

				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;

				Assert.Same(expectedComment, content.Value);
			}

			[Trait("Unit Tests", "GetCommentByIdAsync"), Fact()]
			public async Task GetCommentByIdAsync_With_An_InValid_Id_Should_Return_NotFoundResult_when_CommentNotFoundException_is_thrown_Test()
			{
				// Arrange

				const int badId = -1;

				CommentServiceMock
					.Setup(x => x.GetCommentByIdAsync(badId))
					.ThrowsAsync(new CommentNotFoundException(new Comment { Id = badId }));

				// Act

				var result = await ControllerUnderTest.GetCommentByIdAsync(badId);

				// Assert

				Assert.IsType<NotFoundResult>(result);
			}

			[Trait("Unit Tests", "GetCommentByIdAsync"), Fact()]
			public async Task GetCommentByIdAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				const long testId = 1;
				const string expectedLog = "Something went wrong inside CommentByIdAsync action: Some Error";
				const string expectedValue = "Internal server error";

				CommentServiceMock
					.Setup(x => x.GetCommentByIdAsync(testId))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.GetCommentByIdAsync(testId);

				// Assert

				result.Should().BeOfType<ObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;
				content.StatusCode.Should().Be(500);
				content.Value.Should().Be(expectedValue);
			}
		}

		public class CreateCommentAsync : CommentControllerUnitTests
		{
			[Trait("Unit Tests", "CreateCommentAsync"), Fact()]
			public async Task CreateCommentAsync_Should_Return_CreatedAtActionResult_With_The_created_Comment_Test()
			{
				// Arrange

				var expectedCreatedAtActionName = nameof(CommentController.GetCommentByIdAsync);
				var commentToCreate = new NewCommentDto { CommentDescription = "Test  1" };
				var expectedResult = new CommentDto { Id = 1, CommentDescription = "Test  1" };

				CommentServiceMock
					.Setup(x => x.CreateCommentAsync(commentToCreate))
					.ReturnsAsync(expectedResult);

				// Act

				var result = await ControllerUnderTest.CreateCommentAsync(commentToCreate);

				// Assert

				var createdResult = Assert.IsType<CreatedAtRouteResult>(result);
				Assert.Same(expectedResult, createdResult.Value);
				Assert.Equal(expectedCreatedAtActionName, createdResult.RouteName);
				Assert.Equal(expectedResult.Id, createdResult.RouteValues.GetValueOrDefault("id")
				);
			}

			[Trait("Unit Tests", "CreateCommentAsync"), Fact()]
			public async Task CreateCommentAsync_With_Null_CommentForCreationDto_Should_Return_BadRequest_Test()
			{
				// Arrange

				const string expectedLog = "Comment object sent from client is null";

				// Act

				var result = await ControllerUnderTest.CreateCommentAsync(null);

				// Assert

				result.Should().BeOfType<BadRequestObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);
			}

			[Trait("Unit Tests", "CreateCommentAsync"), Theory(DisplayName = "CreateCommentAsync With InValid NewCommentDto")]
			[InlineData("", "test", "test", "Invalid comment object sent from client", "Comment Is Required", "CommentDescription")]
			[InlineData(null, "test", "test", "Invalid comment object sent from client", "Comment Is Required", "CommentDescription")]
			[InlineData("test", "", "test", "Invalid comment object sent from client", "Commenter Id Is Required", "CommenterId")]
			[InlineData("test", null, "test", "Invalid comment object sent from client", "Commenter Id Is Required", "CommenterId")]
			[InlineData("test", "test", "", "Invalid comment object sent from client", "Commenter Name Is Required", "CommenterName")]
			[InlineData("test", "test", null, "Invalid comment object sent from client", "Commenter Name Is Required", "CommenterName")]
			public async Task CreateCommentAsync_With_Invalid_Data_Should_Return_Model_Errors_TestAsync(string commentText, string initiatorId, string initiatorName, string expectedLog, string expectedValidationError, string expectedValidationField)
			{
				// Arrange

				var comment = new NewCommentDto() { CommentDescription = commentText, CommenterId = initiatorId, CommenterName = initiatorName };

				MockHelpers.MockModelState(comment, ControllerUnderTest);

				// Act

				var result = await ControllerUnderTest.CreateCommentAsync(comment);

				// Assert

				result.Should().BeOfType<BadRequestObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var badRequestResult = (BadRequestObjectResult)result;
				badRequestResult.StatusCode.Should().Be(badRequestResult.StatusCode);
				var errors = Assert.IsType<SerializableError>(badRequestResult.Value).ToList();
				errors.Count.Should().Be(1);
				errors[0].Key.Should().Contain(expectedValidationField);
				errors[0].Value.As<string[]>()[0].Should().BeEquivalentTo(expectedValidationError);
			}

			[Trait("Unit Tests", "CreateCommentAsync"), Fact()]
			public async Task CreateCommentAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				var commentToCreate = new NewCommentDto { CommentDescription = "Test  1" };
				const string expectedLog = "Something went wrong inside CreateCommentAsync action: Some Error";
				const string expectedValue = "Internal server error";

				CommentServiceMock
					.Setup(x => x.CreateCommentAsync(It.IsAny<NewCommentDto>()))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.CreateCommentAsync(commentToCreate);

				// Assert

				result.Should().BeOfType<ObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;
				content.StatusCode.Should().Be(500);
				content.Value.Should().Be(expectedValue);
			}
		}

		public class UpdateCommentAsync : CommentControllerUnitTests
		{
			[Trait("Unit Tests", "UpdateCommentAsync"), Fact]
			public async Task UpdateCommentAsync_Should_return_NoContentResult_Test()
			{
				// Arrange

				CommentForUpdateDto expectedComment = new() { Id = 1, CommentDescription = "Test 1 update", CommenterId = "test", CommenterName = "Tester", DateModifiedUtc = DateTimeOffset.UtcNow };

				CommentServiceMock
					.Setup(x => x.UpdateCommentAsync(expectedComment.Id, expectedComment))
					.ReturnsAsync(true);

				// Act

				var result = await ControllerUnderTest.UpdateCommentAsync(expectedComment.Id, expectedComment);

				// Assert

				result.Should().BeOfType<NoContentResult>();
			}

			[Trait("Unit Tests", "UpdateCommentAsync"), Fact()]
			public async Task UpdateCommentAsync_With_Null_CommentForCreationDto_Should_Return_BadRequest_Test()
			{
				// Arrange

				const string expectedLog = "Comment object sent from client is null";

				// Act

				var result = await ControllerUnderTest.UpdateCommentAsync(0, null);

				// Assert

				result.Should().BeOfType<BadRequestObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);
			}

			[Trait("Unit Tests", "UpdateCommentAsync"), Fact]
			public async Task UpdateCommentAsync_Should_return_NotFoundResult_when_CommentNotFoundException_is_thrown()
			{
				// Arrange

				CommentForUpdateDto unExpectedComment = new() { Id = 1, CommentDescription = "Test 1 update", CommenterId = "test", CommenterName = "Tester", DateModifiedUtc = DateTimeOffset.UtcNow };

				var expectedResult = new Comment { Id = 1, CommentDescription = "Test 1", DateAddedUtc = DateTimeOffset.Now };

				CommentServiceMock
					.Setup(x => x.UpdateCommentAsync(unExpectedComment.Id, unExpectedComment))
					.ThrowsAsync(new CommentNotFoundException(expectedResult));

				// Act

				var result = await ControllerUnderTest.UpdateCommentAsync(unExpectedComment.Id, unExpectedComment);

				// Assert

				Assert.IsType<NotFoundResult>(result);
			}

			[Trait("Unit Tests", "UpdateCommentAsync"), Theory(DisplayName = "UpdateCommentAsync With InValid NewCommentDto")]
			[InlineData("", "test", "test", "Invalid comment object sent from client", "Comment Is Required", "CommentDescription")]
			[InlineData(null, "test", "test", "Invalid comment object sent from client", "Comment Is Required", "CommentDescription")]
			[InlineData("test", "", "test", "Invalid comment object sent from client", "Commenter Id Is Required", "CommenterId")]
			[InlineData("test", null, "test", "Invalid comment object sent from client", "Commenter Id Is Required", "CommenterId")]
			[InlineData("test", "test", "", "Invalid comment object sent from client", "Commenter Name Is Required", "CommenterName")]
			[InlineData("test", "test", null, "Invalid comment object sent from client", "Commenter Name Is Required", "CommenterName")]
			public async Task UpdateCommentAsync_With_Invalid_Data_Should_Return_Model_Errors_TestAsync(string commentText, string commenterId, string commenterName, string expectedLog, string expectedValidationError, string expectedValidationField)
			{
				// Arrange

				var comment = new CommentForUpdateDto() { Id = 1, CommentDescription = commentText, CommenterId = commenterId, CommenterName = commenterName, DateModifiedUtc = DateTimeOffset.UtcNow };

				MockHelpers.MockModelState(comment, ControllerUnderTest);

				// Act

				var result = await ControllerUnderTest.UpdateCommentAsync(comment.Id, comment);

				// Assert

				result.Should().BeOfType<BadRequestObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var badRequestResult = (BadRequestObjectResult)result;
				badRequestResult.StatusCode.Should().Be(badRequestResult.StatusCode);
				var errors = Assert.IsType<SerializableError>(badRequestResult.Value).ToList();
				errors.Count.Should().Be(1);
				errors[0].Key.Should().Contain(expectedValidationField);
				errors[0].Value.As<string[]>()[0].Should().BeEquivalentTo(expectedValidationError);
			}

			[Trait("Unit Tests", "UpdateCommentAsync"), Fact()]
			public async Task UpdateCommentAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				var expectedComment = new CommentForUpdateDto() { Id = 1, CommentDescription = "Test 1 update", CommenterId = "test", CommenterName = "Tester", DateModifiedUtc = DateTimeOffset.UtcNow };
				const string expectedLog = "Something went wrong inside UpdateCommentAsync action: Some Error";
				const string expectedValue = "Internal server error";

				CommentServiceMock
					.Setup(x => x.UpdateCommentAsync(It.IsAny<long>(), It.IsAny<CommentForUpdateDto>()))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.UpdateCommentAsync(expectedComment.Id, expectedComment);

				// Assert

				result.Should().BeOfType<ObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;
				content.StatusCode.Should().Be(500);
				content.Value.Should().Be(expectedValue);
			}
		}

		public class DeleteCommentAsync : CommentControllerUnitTests
		{
			[Trait("Unit Tests", "DeleteCommentAsync"), Fact]
			public async Task DeleteCommentAsync_With_Valid_Id_Should_return_NoContentResult_on_successful_delete_Test()
			{
				// Arrange

				var expectedComment = new CommentForDeleteDto(1, true);

				CommentServiceMock
					.Setup(x => x.DeleteCommentAsync(expectedComment))
					.ReturnsAsync(true);

				// Act

				var result = await ControllerUnderTest.DeleteCommentAsync(expectedComment);

				// Assert

				result.Should().BeOfType<NoContentResult>();
			}

			[Trait("Unit Tests", "DeleteCommentAsync"), Fact()]
			public async Task DeleteCommentAsync_With_Null_CommentForCreationDto_Should_Return_BadRequest_Test()
			{
				// Arrange

				const string expectedLog = "Comment object sent from client is null";

				// Act

				var result = await ControllerUnderTest.DeleteCommentAsync(null);

				// Assert

				result.Should().BeOfType<BadRequestObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);
			}

			[Trait("Unit Tests", "DeleteCommentAsync"), Fact]
			public async Task DeleteCommentAsync_Should_return_NotFoundResult_when_CommentNotFoundException_is_thrown_Test()
			{
				// Arrange

				var expectedComment = new CommentForDeleteDto(1, true);

				var expectedResult = new Comment { Id = 1, CommentDescription = "Test 1", DateAddedUtc = DateTimeOffset.Now };

				CommentServiceMock
					.Setup(x => x.DeleteCommentAsync(expectedComment))
					.ThrowsAsync(new CommentNotFoundException(expectedResult));

				// Act

				var result = await ControllerUnderTest.DeleteCommentAsync(expectedComment);

				// Assert

				Assert.IsType<NotFoundResult>(result);
			}

			[Trait("Unit Tests", "DeleteCommentAsync"), Fact()]
			public async Task DeleteCommentAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				var expectedComment = new CommentForDeleteDto(1, true);

				const string expectedLog = "Something went wrong inside DeleteCommentAsync action: Some Error";

				const string expectedValue = "Internal server error";

				CommentServiceMock
					.Setup(x => x.DeleteCommentAsync(It.IsAny<CommentForDeleteDto>()))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.DeleteCommentAsync(expectedComment);

				// Assert

				result.Should().BeOfType<ObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;
				content.StatusCode.Should().Be(500);
				content.Value.Should().Be(expectedValue);
			}
		}
	}
}