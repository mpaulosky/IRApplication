using FluentAssertions;

using IR.Server.Controllers;
using IR.Shared.Dtos;
using IR.Shared.Infrastructure;
using IR.Shared.Interfaces;
using IR.Shared.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Moq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TestHelpers;

using Xunit;

namespace IR.Server.Unit.Tests.Controllers
{
	public class IssueControllerUnitTests
	{
		private IssueController ControllerUnderTest { get; }

		private Mock<IIssueService> IssueServiceMock { get; }

		private Mock<ILogger<IssueController>> LoggerMock { get; }

		public IssueControllerUnitTests()
		{
			LoggerMock = new Mock<ILogger<IssueController>>();

			IssueServiceMock = new Mock<IIssueService>();

			ControllerUnderTest = new IssueController(IssueServiceMock.Object, LoggerMock.Object);
		}

		public class GetIssuesAsync : IssueControllerUnitTests
		{
			[Fact(DisplayName = "GetIssuesAsync Returns All Issues")]
			public async Task GetIssuesAsync_Should_Return_All_Issues_TestAsync()
			{
				// Arrange

				var expectedIssues = new List<IssueDto>
				{
					new IssueDto{Id = 1, IssueDescription = "Test1", InitiatorName = "Tester", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, IsDeleted = false, IsResolved =  false },
					new IssueDto{Id = 2, IssueDescription = "Test2", InitiatorName = "Tester", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, IsDeleted = false, IsResolved =  false },
					new IssueDto{Id = 3, IssueDescription = "Test3", InitiatorName = "Tester", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, IsDeleted = false, IsResolved =  false }
				};

				var expectedLog = "Returned all issues from database";

				IssueServiceMock
					.Setup(x => x.GetIssuesAsync())
					.ReturnsAsync(expectedIssues);

				// Act

				var result = await ControllerUnderTest.GetIssuesAsync();

				// Assert

				result.Should().BeOfType<OkObjectResult>();

				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;

				Assert.Same(expectedIssues, content.Value);
			}

			[Fact(DisplayName = "GetIssuesAsync With Error")]
			public async Task GetIssuesAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				const string expectedLog = "Something went wrong inside GetIssuesAsync action: Some Error";
				const string expectedValue = "Internal server error";

				IssueServiceMock
					.Setup(x => x.GetIssuesAsync())
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.GetIssuesAsync();

				// Assert

				result.Should().BeOfType<ObjectResult>();

				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;

				content.StatusCode.Should().Be(500);

				content.Value.Should().Be(expectedValue);
			}
		}

		public class GetIssueByIdAsync : IssueControllerUnitTests
		{
			[Fact()]
			public async Task GetIssueByIdAsync_With_A_Valid_Id_Should_Return_OkObjectResult_with_a_Issue_Test()
			{
				// Arrange

				var expectedIssue = new IssueDto { Id = 1, IssueDescription = "Test1", InitiatorName = "Tester", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, IsDeleted = false, IsResolved = false };

				var expectedLog = "Returned issue with Id: 1 from database";

				IssueServiceMock
					.Setup(x => x.GetIssueByIdAsync(expectedIssue.Id))
					.ReturnsAsync(expectedIssue);

				// Act

				var result = await ControllerUnderTest.GetIssueByIdAsync(expectedIssue.Id);

				// Assert

				result.Should().BeOfType<OkObjectResult>();

				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;

				Assert.Same(expectedIssue, content.Value);
			}

			[Fact()]
			public async Task GetIssueByIdAsync_With_An_InValid_Id_Should_Return_NotFoundResult_when_IssueNotFoundException_is_thrown_Test()
			{
				// Arrange

				const int badId = -1;

				IssueServiceMock
					.Setup(x => x.GetIssueByIdAsync(badId))
					.ThrowsAsync(new IssueNotFoundException(new Issue { Id = badId }));

				// Act

				var result = await ControllerUnderTest.GetIssueByIdAsync(badId);

				// Assert

				Assert.IsType<NotFoundResult>(result);
			}

			[Fact()]
			public async Task GetIssueByIdAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				const long testId = 1;
				const string expectedLog = "Something went wrong inside IssueByIdAsync action: Some Error";
				const string expectedValue = "Internal server error";

				IssueServiceMock
					.Setup(x => x.GetIssueByIdAsync(testId))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.GetIssueByIdAsync(testId);

				// Assert

				result.Should().BeOfType<ObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;
				content.StatusCode.Should().Be(500);
				content.Value.Should().Be(expectedValue);
			}
		}

		public class CreateIssueAsync : IssueControllerUnitTests
		{
			[Fact()]
			public async Task CreateIssueAsync_Should_Return_CreatedAtActionResult_With_The_created_Issue_Test()
			{
				// Arrange

				var expectedCreatedAtActionName = nameof(IssueController.GetIssueByIdAsync);
				var issueToCreate = new NewIssueDto { IssueDescription = "Test  1" };
				var expectedResult = new IssueDto { Id = 1, IssueDescription = "Test  1" };

				IssueServiceMock
					.Setup(x => x.CreateIssueAsync(issueToCreate))
					.ReturnsAsync(expectedResult);

				// Act

				var result = await ControllerUnderTest.CreateIssueAsync(issueToCreate);

				// Assert

				var createdResult = Assert.IsType<CreatedAtRouteResult>(result);
				Assert.Same(expectedResult, createdResult.Value);
				Assert.Equal(expectedCreatedAtActionName, createdResult.RouteName);
				Assert.Equal(expectedResult.Id, createdResult.RouteValues.GetValueOrDefault("id")
				);
			}

			[Fact()]
			public async Task CreateIssueAsync_With_Null_IssueForCreationDto_Should_Return_BadRequest_Test()
			{
				// Arrange

				const string expectedLog = "Issue object sent from client is null";

				// Act

				var result = await ControllerUnderTest.CreateIssueAsync(null);

				// Assert

				result.Should().BeOfType<BadRequestObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);
			}

			[Theory(DisplayName = "CreateIssueAsync With InValid NewIssueDto")]
			[InlineData("", "test", "test", "Invalid issue object sent from client", "Description Is Required", "IssueDescription")]
			[InlineData(null, "test", "test", "Invalid issue object sent from client", "Description Is Required", "IssueDescription")]
			[InlineData("test", "", "test", "Invalid issue object sent from client", "Initiator Id Is Required", "InitiatorId")]
			[InlineData("test", null, "test", "Invalid issue object sent from client", "Initiator Id Is Required", "InitiatorId")]
			[InlineData("test", "test", "", "Invalid issue object sent from client", "Initiator Name Is Required", "InitiatorName")]
			[InlineData("test", "test", null, "Invalid issue object sent from client", "Initiator Name Is Required", "InitiatorName")]
			public async Task CreateIssueAsync_With_Invalid_Data_Should_Return_Model_Errors_TestAsync(string issueDescription, string initiatorId, string initiatorName, string expectedLog, string expectedValidationError, string expectedValidationField)
			{
				// Arrange

				var issue = new NewIssueDto() { IssueDescription = issueDescription, InitiatorId = initiatorId, InitiatorName = initiatorName };

				MockHelpers.MockModelState(issue, ControllerUnderTest);

				// Act

				var result = await ControllerUnderTest.CreateIssueAsync(issue);

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

			[Fact()]
			public async Task CreateIssueAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				var issueToCreate = new NewIssueDto { IssueDescription = "Test  1" };
				const string expectedLog = "Something went wrong inside CreateIssueAsync action: Some Error";
				const string expectedValue = "Internal server error";

				IssueServiceMock
					.Setup(x => x.CreateIssueAsync(It.IsAny<NewIssueDto>()))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.CreateIssueAsync(issueToCreate);

				// Assert

				result.Should().BeOfType<ObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;
				content.StatusCode.Should().Be(500);
				content.Value.Should().Be(expectedValue);
			}
		}

		public class UpdateIssueAsync : IssueControllerUnitTests
		{
			[Fact]
			public async Task UpdateIssueAsync_Should_return_NoContentResult_Test()
			{
				// Arrange

				IssueForUpdateDto expectedIssue = new() { Id = 1, IssueDescription = "Test 1 update", InitiatorId = "test", InitiatorName = "Tester", DateModifiedUtc = DateTimeOffset.UtcNow, DateResolvedUtc = null, IsResolved = false };

				IssueServiceMock
					.Setup(x => x.UpdateIssueAsync(expectedIssue.Id, expectedIssue))
					.ReturnsAsync(true);

				// Act

				var result = await ControllerUnderTest.UpdateIssueAsync(expectedIssue.Id, expectedIssue);

				// Assert

				result.Should().BeOfType<NoContentResult>();
			}

			[Fact()]
			public async Task UpdateIssueAsync_With_Null_IssueForCreationDto_Should_Return_BadRequest_Test()
			{
				// Arrange

				const string expectedLog = "Issue object sent from client is null";

				// Act

				var result = await ControllerUnderTest.UpdateIssueAsync(0, null);

				// Assert

				result.Should().BeOfType<BadRequestObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);
			}

			[Fact]
			public async Task UpdateIssueAsync_Should_return_NotFoundResult_when_IssueNotFoundException_is_thrown()
			{
				// Arrange

				IssueForUpdateDto unExpectedIssue = new() { Id = 1, IssueDescription = "Test 1 update", InitiatorId = "test", InitiatorName = "Tester", DateModifiedUtc = DateTimeOffset.UtcNow, DateResolvedUtc = null, IsResolved = false };

				var expectedResult = new Issue { Id = 1, IssueDescription = "Test 1", DateAddedUtc = DateTimeOffset.Now };

				IssueServiceMock
					.Setup(x => x.UpdateIssueAsync(unExpectedIssue.Id, unExpectedIssue))
					.ThrowsAsync(new IssueNotFoundException(expectedResult));

				// Act

				var result = await ControllerUnderTest.UpdateIssueAsync(unExpectedIssue.Id, unExpectedIssue);

				// Assert

				Assert.IsType<NotFoundResult>(result);
			}

			[Theory(DisplayName = "UpdateIssueAsync With InValid NewIssueDto")]
			[InlineData("", "test", "test", "Invalid issue object sent from client", "Description Is Required", "IssueDescription")]
			[InlineData(null, "test", "test", "Invalid issue object sent from client", "Description Is Required", "IssueDescription")]
			[InlineData("test", "", "test", "Invalid issue object sent from client", "Initiator Id Is Required", "InitiatorId")]
			[InlineData("test", null, "test", "Invalid issue object sent from client", "Initiator Id Is Required", "InitiatorId")]
			[InlineData("test", "test", "", "Invalid issue object sent from client", "Initiator Name Is Required", "InitiatorName")]
			[InlineData("test", "test", null, "Invalid issue object sent from client", "Initiator Name Is Required", "InitiatorName")]
			public async Task CreateIssueAsync_With_Invalid_Data_Should_Return_Model_Errors_TestAsync(string issueDescription, string initiatorId, string initiatorName, string expectedLog, string expectedValidationError, string expectedValidationField)
			{
				// Arrange

				var issue = new IssueForUpdateDto() { Id = 1, IssueDescription = issueDescription, InitiatorId = initiatorId, InitiatorName = initiatorName, DateModifiedUtc = DateTimeOffset.UtcNow };

				MockHelpers.MockModelState(issue, ControllerUnderTest);

				// Act

				var result = await ControllerUnderTest.UpdateIssueAsync(issue.Id, issue);

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

			[Fact()]
			public async Task CreateIssueAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				var issueToCreate = new NewIssueDto { IssueDescription = "Test  1" };
				const string expectedLog = "Something went wrong inside CreateIssueAsync action: Some Error";
				const string expectedValue = "Internal server error";

				IssueServiceMock
					.Setup(x => x.CreateIssueAsync(It.IsAny<NewIssueDto>()))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.CreateIssueAsync(issueToCreate);

				// Assert

				result.Should().BeOfType<ObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;
				content.StatusCode.Should().Be(500);
				content.Value.Should().Be(expectedValue);
			}

			[Fact()]
			public async Task UpdateIssueAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				var expectedIssue = new IssueForUpdateDto() { Id = 1, IssueDescription = "Test 1 update", InitiatorId = "test", InitiatorName = "Tester", DateModifiedUtc = DateTimeOffset.UtcNow, DateResolvedUtc = null, IsResolved = false };
				const string expectedLog = "Something went wrong inside UpdateIssueAsync action: Some Error";
				const string expectedValue = "Internal server error";

				IssueServiceMock
					.Setup(x => x.UpdateIssueAsync(It.IsAny<long>(), It.IsAny<IssueForUpdateDto>()))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.UpdateIssueAsync(expectedIssue.Id, expectedIssue);

				// Assert

				result.Should().BeOfType<ObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;
				content.StatusCode.Should().Be(500);
				content.Value.Should().Be(expectedValue);
			}
		}

		public class DeleteIssueAsync : IssueControllerUnitTests
		{
			[Fact]
			public async Task DeleteIssueAsync_With_Valid_Id_Should_return_NoContentResult_on_successful_delete_Test()
			{
				// Arrange

				var expectedIssue = new IssueForDeleteDto(1, true);

				IssueServiceMock
					.Setup(x => x.DeleteIssueAsync(expectedIssue))
					.ReturnsAsync(true);

				// Act

				var result = await ControllerUnderTest.DeleteIssueAsync(expectedIssue);

				// Assert

				result.Should().BeOfType<NoContentResult>();
			}

			[Fact()]
			public async Task DeleteIssueAsync_With_Null_IssueForCreationDto_Should_Return_BadRequest_Test()
			{
				// Arrange

				const string expectedLog = "Issue object sent from client is null";

				// Act

				var result = await ControllerUnderTest.DeleteIssueAsync(null);

				// Assert

				result.Should().BeOfType<BadRequestObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);
			}

			[Fact]
			public async Task DeleteIssueAsync_Should_return_NotFoundResult_when_IssueNotFoundException_is_thrown_Test()
			{
				// Arrange

				var expectedIssue = new IssueForDeleteDto(1, true);

				var expectedResult = new Issue { Id = 1, IssueDescription = "Test 1", DateAddedUtc = DateTimeOffset.Now };

				IssueServiceMock
					.Setup(x => x.DeleteIssueAsync(expectedIssue))
					.ThrowsAsync(new IssueNotFoundException(expectedResult));

				// Act

				var result = await ControllerUnderTest.DeleteIssueAsync(expectedIssue);

				// Assert

				Assert.IsType<NotFoundResult>(result);
			}

			[Fact()]
			public async Task DeleteIssueAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				var expectedIssue = new IssueForDeleteDto(1, true);

				const string expectedLog = "Something went wrong inside DeleteIssueAsync action: Some Error";

				const string expectedValue = "Internal server error";

				IssueServiceMock
					.Setup(x => x.DeleteIssueAsync(It.IsAny<IssueForDeleteDto>()))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.DeleteIssueAsync(expectedIssue);

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