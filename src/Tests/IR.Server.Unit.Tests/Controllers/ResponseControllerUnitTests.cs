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

namespace IR.Server.Unit.Tests.Controllers
{
	public class ResponseControllerUnitTests
	{
		private ResponseController ControllerUnderTest { get; }

		private Mock<IResponseService> ResponseServiceMock { get; }

		private Mock<ILogger<ResponseController>> LoggerMock { get; }

		public ResponseControllerUnitTests()
		{
			LoggerMock = new Mock<ILogger<ResponseController>>();

			ResponseServiceMock = new Mock<IResponseService>();

			ControllerUnderTest = new(ResponseServiceMock.Object, LoggerMock.Object);
		}

		public class GetResponsesAsync : ResponseControllerUnitTests
		{
			[Fact(DisplayName = "GetResponsesAsync Returns All Responses")]
			public async Task GetResponsesAsync_Should_Return_All_Responses_TestAsync()
			{
				// Arrange

				var expectedResponses = new List<ResponseDto>
				{
					new ResponseDto{Id = 1, ResponseDescription = "Test1", ResponderId = new Guid().ToString(), ResponderName = "Tester", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, IsDeleted = false },
					new ResponseDto{Id = 2, ResponseDescription = "Test2", ResponderId = new Guid().ToString(), ResponderName = "Tester", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, IsDeleted = false },
					new ResponseDto{Id = 3, ResponseDescription = "Test3", ResponderId = new Guid().ToString(), ResponderName = "Tester", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, IsDeleted = false }
				};

				var expectedLog = "Returned all responses from database";

				ResponseServiceMock
					.Setup(x => x.GetResponsesAsync())
					.ReturnsAsync(expectedResponses);

				// Act

				var result = await ControllerUnderTest.GetResponsesAsync();

				// Assert

				result.Should().BeOfType<OkObjectResult>();

				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;

				Assert.Same(expectedResponses, content.Value);
			}

			[Fact(DisplayName = "GetResponsesAsync With Error")]
			public async Task GetResponsesAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				const string expectedLog = "Something went wrong inside GetResponsesAsync action: Some Error";
				const string expectedValue = "Internal server error";

				ResponseServiceMock
					.Setup(x => x.GetResponsesAsync())
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.GetResponsesAsync();

				// Assert

				result.Should().BeOfType<ObjectResult>();

				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;

				content.StatusCode.Should().Be(500);

				content.Value.Should().Be(expectedValue);
			}
		}

		public class GetResponseByIdAsync : ResponseControllerUnitTests
		{
			[Fact()]
			public async Task GetResponseByIdAsync_With_A_Valid_Id_Should_Return_OkObjectResult_with_a_Response_Test()
			{
				// Arrange

				var expectedResponse = new ResponseDto { Id = 1, ResponseDescription = "Test1", ResponderId = new Guid().ToString(), ResponderName = "Tester", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, IsDeleted = false };

				var expectedLog = "Returned response with Id: 1 from database";

				ResponseServiceMock
					.Setup(x => x.GetResponseByIdAsync(expectedResponse.Id))
					.ReturnsAsync(expectedResponse);

				// Act

				var result = await ControllerUnderTest.GetResponseByIdAsync(expectedResponse.Id);

				// Assert

				result.Should().BeOfType<OkObjectResult>();

				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;

				Assert.Same(expectedResponse, content.Value);
			}

			[Fact()]
			public async Task GetResponseByIdAsync_With_An_InValid_Id_Should_Return_NotFoundResult_when_ResponseNotFoundException_is_thrown_Test()
			{
				// Arrange

				const int badId = -1;

				ResponseServiceMock
					.Setup(x => x.GetResponseByIdAsync(badId))
					.ThrowsAsync(new ResponseNotFoundException(new Response { Id = badId }));

				// Act

				var result = await ControllerUnderTest.GetResponseByIdAsync(badId);

				// Assert

				Assert.IsType<NotFoundResult>(result);
			}

			[Fact()]
			public async Task GetResponseByIdAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				const long testId = 1;
				const string expectedLog = "Something went wrong inside ResponseByIdAsync action: Some Error";
				const string expectedValue = "Internal server error";

				ResponseServiceMock
					.Setup(x => x.GetResponseByIdAsync(testId))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.GetResponseByIdAsync(testId);

				// Assert

				result.Should().BeOfType<ObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;
				content.StatusCode.Should().Be(500);
				content.Value.Should().Be(expectedValue);
			}
		}

		public class CreateResponseAsync : ResponseControllerUnitTests
		{
			[Fact()]
			public async Task CreateResponseAsync_Should_Return_CreatedAtActionResult_With_The_created_Response_Test()
			{
				// Arrange

				var expectedCreatedAtActionName = nameof(ResponseController.GetResponseByIdAsync);
				var responseToCreate = new NewResponseDto { ResponseDescription = "Test  1" };
				var expectedResult = new ResponseDto { Id = 1, ResponseDescription = "Test  1" };

				ResponseServiceMock
					.Setup(x => x.CreateResponseAsync(responseToCreate))
					.ReturnsAsync(expectedResult);

				// Act

				var result = await ControllerUnderTest.CreateResponseAsync(responseToCreate);

				// Assert

				var createdResult = Assert.IsType<CreatedAtRouteResult>(result);
				Assert.Same(expectedResult, createdResult.Value);
				Assert.Equal(expectedCreatedAtActionName, createdResult.RouteName);
				Assert.Equal(expectedResult.Id, createdResult.RouteValues.GetValueOrDefault("id")
				);
			}

			[Fact()]
			public async Task CreateResponseAsync_With_Null_ResponseForCreationDto_Should_Return_BadRequest_Test()
			{
				// Arrange

				const string expectedLog = "Response object sent from client is null";

				// Act

				var result = await ControllerUnderTest.CreateResponseAsync(null);

				// Assert

				result.Should().BeOfType<BadRequestObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);
			}

			[Theory(DisplayName = "CreateResponseAsync With InValid NewResponseDto")]
			[InlineData("", "test", "test", "Invalid response object sent from client", "Response Is Required", "ResponseDescription")]
			[InlineData(null, "test", "test", "Invalid response object sent from client", "Response Is Required", "ResponseDescription")]
			[InlineData("test", "", "test", "Invalid response object sent from client", "Responder Id Is Required", "ResponderId")]
			[InlineData("test", null, "test", "Invalid response object sent from client", "Responder Id Is Required", "ResponderId")]
			[InlineData("test", "test", "", "Invalid response object sent from client", "Responder Name Is Required", "ResponderName")]
			[InlineData("test", "test", null, "Invalid response object sent from client", "Responder Name Is Required", "ResponderName")]
			public async Task CreateResponseAsync_With_Invalid_Data_Should_Return_Model_Errors_TestAsync(string responseText, string initiatorId, string initiatorName, string expectedLog, string expectedValidationError, string expectedValidationField)
			{
				// Arrange

				var response = new NewResponseDto() { ResponseDescription = responseText, ResponderId = initiatorId, ResponderName = initiatorName };

				MockHelpers.MockModelState(response, ControllerUnderTest);

				// Act

				var result = await ControllerUnderTest.CreateResponseAsync(response);

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
			public async Task CreateResponseAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				var responseToCreate = new NewResponseDto { ResponseDescription = "Test  1" };
				const string expectedLog = "Something went wrong inside CreateResponseAsync action: Some Error";
				const string expectedValue = "Internal server error";

				ResponseServiceMock
					.Setup(x => x.CreateResponseAsync(It.IsAny<NewResponseDto>()))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.CreateResponseAsync(responseToCreate);

				// Assert

				result.Should().BeOfType<ObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;
				content.StatusCode.Should().Be(500);
				content.Value.Should().Be(expectedValue);
			}
		}

		public class UpdateResponseAsync : ResponseControllerUnitTests
		{
			[Fact]
			public async Task UpdateResponseAsync_Should_return_NoContentResult_Test()
			{
				// Arrange

				ResponseForUpdateDto expectedResponse = new() { Id = 1, ResponseDescription = "Test 1 update", ResponderId = "test", ResponderName = "Tester", DateModifiedUtc = DateTimeOffset.UtcNow };

				ResponseServiceMock
					.Setup(x => x.UpdateResponseAsync(expectedResponse.Id, expectedResponse))
					.ReturnsAsync(true);

				// Act

				var result = await ControllerUnderTest.UpdateResponseAsync(expectedResponse.Id, expectedResponse);

				// Assert

				result.Should().BeOfType<NoContentResult>();
			}

			[Fact()]
			public async Task UpdateResponseAsync_With_Null_ResponseForCreationDto_Should_Return_BadRequest_Test()
			{
				// Arrange

				const string expectedLog = "Response object sent from client is null";

				// Act

				var result = await ControllerUnderTest.UpdateResponseAsync(0, null);

				// Assert

				result.Should().BeOfType<BadRequestObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);
			}

			[Fact]
			public async Task UpdateResponseAsync_Should_return_NotFoundResult_when_ResponseNotFoundException_is_thrown()
			{
				// Arrange

				ResponseForUpdateDto unExpectedResponse = new() { Id = 1, ResponseDescription = "Test 1 update", ResponderId = "test", ResponderName = "Tester", DateModifiedUtc = DateTimeOffset.UtcNow };

				var expectedResult = new Response { Id = 1, ResponseDescription = "Test 1", DateAddedUtc = DateTimeOffset.Now };

				ResponseServiceMock
					.Setup(x => x.UpdateResponseAsync(unExpectedResponse.Id, unExpectedResponse))
					.ThrowsAsync(new ResponseNotFoundException(expectedResult));

				// Act

				var result = await ControllerUnderTest.UpdateResponseAsync(unExpectedResponse.Id, unExpectedResponse);

				// Assert

				Assert.IsType<NotFoundResult>(result);
			}

			[Theory(DisplayName = "UpdateResponseAsync With InValid NewResponseDto")]
			[InlineData("", "test", "test", "Invalid response object sent from client", "Response Is Required", "ResponseDescription")]
			[InlineData(null, "test", "test", "Invalid response object sent from client", "Response Is Required", "ResponseDescription")]
			[InlineData("test", "", "test", "Invalid response object sent from client", "Responder Id Is Required", "ResponderId")]
			[InlineData("test", null, "test", "Invalid response object sent from client", "Responder Id Is Required", "ResponderId")]
			[InlineData("test", "test", "", "Invalid response object sent from client", "Responder Name Is Required", "ResponderName")]
			[InlineData("test", "test", null, "Invalid response object sent from client", "Responder Name Is Required", "ResponderName")]
			public async Task CreateResponseAsync_With_Invalid_Data_Should_Return_Model_Errors_TestAsync(string responseText, string responseerId, string responseerName, string expectedLog, string expectedValidationError, string expectedValidationField)
			{
				// Arrange

				var response = new ResponseForUpdateDto() { Id = 1, ResponseDescription = responseText, ResponderId = responseerId, ResponderName = responseerName, DateModifiedUtc = DateTimeOffset.UtcNow };

				MockHelpers.MockModelState(response, ControllerUnderTest);

				// Act

				var result = await ControllerUnderTest.UpdateResponseAsync(response.Id, response);

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
			public async Task CreateResponseAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				var responseToCreate = new NewResponseDto { ResponseDescription = "Test  1" };
				const string expectedLog = "Something went wrong inside CreateResponseAsync action: Some Error";
				const string expectedValue = "Internal server error";

				ResponseServiceMock
					.Setup(x => x.CreateResponseAsync(It.IsAny<NewResponseDto>()))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.CreateResponseAsync(responseToCreate);

				// Assert

				result.Should().BeOfType<ObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;
				content.StatusCode.Should().Be(500);
				content.Value.Should().Be(expectedValue);
			}

			[Fact()]
			public async Task UpdateResponseAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				var expectedResponse = new ResponseForUpdateDto() { Id = 1, ResponseDescription = "Test 1 update", ResponderId = "test", ResponderName = "Tester", DateModifiedUtc = DateTimeOffset.UtcNow };
				const string expectedLog = "Something went wrong inside UpdateResponseAsync action: Some Error";
				const string expectedValue = "Internal server error";

				ResponseServiceMock
					.Setup(x => x.UpdateResponseAsync(It.IsAny<long>(), It.IsAny<ResponseForUpdateDto>()))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.UpdateResponseAsync(expectedResponse.Id, expectedResponse);

				// Assert

				result.Should().BeOfType<ObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				var content = (ObjectResult)result;
				content.StatusCode.Should().Be(500);
				content.Value.Should().Be(expectedValue);
			}
		}

		public class DeleteResponseAsync : ResponseControllerUnitTests
		{
			[Fact]
			public async Task DeleteResponseAsync_With_Valid_Id_Should_return_NoContentResult_on_successful_delete_Test()
			{
				// Arrange

				var expectedResponse = new ResponseForDeleteDto(1, true);

				ResponseServiceMock
					.Setup(x => x.DeleteResponseAsync(expectedResponse))
					.ReturnsAsync(true);

				// Act

				var result = await ControllerUnderTest.DeleteResponseAsync(expectedResponse);

				// Assert

				result.Should().BeOfType<NoContentResult>();
			}

			[Fact()]
			public async Task DeleteResponseAsync_With_Null_ResponseForCreationDto_Should_Return_BadRequest_Test()
			{
				// Arrange

				const string expectedLog = "Response object sent from client is null";

				// Act

				var result = await ControllerUnderTest.DeleteResponseAsync(null);

				// Assert

				result.Should().BeOfType<BadRequestObjectResult>();
				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);
			}

			[Fact]
			public async Task DeleteResponseAsync_Should_return_NotFoundResult_when_ResponseNotFoundException_is_thrown_Test()
			{
				// Arrange

				var expectedResponse = new ResponseForDeleteDto(1, true);

				var expectedResult = new Response { Id = 1, ResponseDescription = "Test 1", DateAddedUtc = DateTimeOffset.Now };

				ResponseServiceMock
					.Setup(x => x.DeleteResponseAsync(expectedResponse))
					.ThrowsAsync(new ResponseNotFoundException(expectedResult));

				// Act

				var result = await ControllerUnderTest.DeleteResponseAsync(expectedResponse);

				// Assert

				Assert.IsType<NotFoundResult>(result);
			}

			[Fact()]
			public async Task DeleteResponseAsync_With_An_Exception_Should_Return_StatusCode_500_Test()
			{
				// Arrange

				var expectedResponse = new ResponseForDeleteDto(1, true);

				const string expectedLog = "Something went wrong inside DeleteResponseAsync action: Some Error";

				const string expectedValue = "Internal server error";

				ResponseServiceMock
					.Setup(x => x.DeleteResponseAsync(It.IsAny<ResponseForDeleteDto>()))
					.ThrowsAsync(new Exception("Some Error"));

				// Act

				var result = await ControllerUnderTest.DeleteResponseAsync(expectedResponse);

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