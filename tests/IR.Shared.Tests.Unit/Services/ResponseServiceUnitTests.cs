using FluentAssertions;

using IR.Shared.Dtos;
using IR.Shared.Infrastructure;
using IR.Shared.Interfaces;
using IR.Shared.Models;
using IR.Shared.Services;

using Microsoft.Extensions.Logging;

using Moq;

using System;
using System.Linq;
using System.Threading.Tasks;

using TestHelpers;

using Xunit;

namespace IR.Shared.Tests.Unit.Services
{
	public class ResponseServiceUnitTests
	{
		private IResponseService ServiceUnderTest { get; }
		private Mock<IRepository> RepositoryMock { get; }
		private Response[] Responses { get; }
		private Mock<ILogger<ResponseService>> LoggerMock { get; }
		private ResponseDto[] ResponseDtos { get; }
		private ResponseForDeleteDto ResponseToDeleteDto { get; }

		protected ResponseServiceUnitTests()
		{
			Responses = new[]
			{
				new Response
				{
					Id = 1,
					ResponseDescription = "Test 1",
					DateAddedUtc = DateTimeOffset.Now,
				},
				new Response
				{
					Id = 2,
					ResponseDescription = "Test 2",
					DateAddedUtc = DateTimeOffset.Now,
				},
				new Response
				{
					Id = 3,
					ResponseDescription = "Test 3",
					DateAddedUtc = DateTimeOffset.Now,
				}
			};
			ResponseDtos = new[]
			{
				new ResponseDto
				{
					Id = 1,
					ResponseDescription = "Test 1",
					DateAddedUtc = DateTimeOffset.Now,
				},
				new ResponseDto
				{
					Id = 2,
					ResponseDescription = "Test 2",
					DateAddedUtc = DateTimeOffset.Now,
				},
				new ResponseDto
				{
					Id = 3,
					ResponseDescription = "Test 3",
					DateAddedUtc = DateTimeOffset.Now,
				}
			};

			ResponseToDeleteDto = new ResponseForDeleteDto(1, false);


			LoggerMock = new Mock<ILogger<ResponseService>>();

			RepositoryMock = new Mock<IRepository>();
			ServiceUnderTest = new ResponseService(RepositoryMock.Object, AutoMapperSingleton.Mapper, LoggerMock.Object);
		}

		public class GetAllResponsesAsync : ResponseServiceUnitTests
		{
			[Fact()]
			public async Task GetAllResponsesAsync_Should_Return_All_Responses_Test()
			{
				// Arrange
				var issuesToReturn = Responses.AsEnumerable();

				RepositoryMock
					.Setup(x => x.SelectAllAsync<Response>())
					.ReturnsAsync(issuesToReturn);

				// Act

				var result = await ServiceUnderTest.GetResponsesAsync();

				// Assert

				var items = result.ToList();
				items.Count.Should().Be(3);
				items[0].ResponseDescription.Should().Contain(ResponseDtos[0].ResponseDescription);
				items[1].ResponseDescription.Should().Contain(ResponseDtos[1].ResponseDescription);
				items[2].ResponseDescription.Should().Contain(ResponseDtos[2].ResponseDescription);
			}
		}

		public class GetResponseByIdAsync : ResponseServiceUnitTests
		{
			[Fact()]
			public async Task GetResponseByIdAsync_With_Valid_Id_Should_Return_The_Expected_Response_Test()
			{
				// Arrange

				const long id = 1;
				var expectedResponse = Responses[0];

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Response>(expectedResponse.Id))
					.ReturnsAsync(Responses[0]);

				// Act

				var result = await ServiceUnderTest.GetResponseByIdAsync(id);

				// Assert

				result.Should().BeOfType<ResponseDto>();
				result.Id.Should().Be(expectedResponse.Id);
				result.ResponseDescription.Should().Contain(expectedResponse.ResponseDescription);
			}

			[Fact()]
			public async Task GetResponseByIdAsync_With_Invalid_Id_Should_Return_Null_If_The_Response_Does_Not_Exist_Test()
			{
				// Arrange

				var id = -1;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Response>(id))
					.ReturnsAsync(default(Response));

				// Act, Assert

				await Assert.ThrowsAsync<ResponseNotFoundException>(() => ServiceUnderTest.GetResponseByIdAsync(id));
			}
		}

		public class ResponseExitsAsync : ResponseServiceUnitTests
		{
			[Fact()]
			public async Task ResponseExistsAsync_Should_Return_True_If_The_Response_Exists_Test()
			{
				// Arrange

				var id = 1;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Response>(id))
					.ReturnsAsync(new Response());

				// Act

				var result = await ServiceUnderTest.ResponseExistsAsync(id);

				// Assert

				Assert.True(result);
			}

			[Fact()]
			public async Task ResponseExistsAsync_Should_Return_False_If_The_Response_Does_Not_Exist_Test()
			{
				// Arrange

				const long id = 0;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Response>(id))
					.ReturnsAsync(default(Response));

				// Act

				var result = await ServiceUnderTest.ResponseExistsAsync(id);

				// Assert

				Assert.False(result);
			}
		}

		public class EnforceResponseExistenceAsync : ResponseServiceUnitTests
		{
			[Fact()]
			public async Task EnforceUserExistenceAsync_Should_Return_User_If_The_User_Exists_Test()
			{
				// Arrange

				var issueId = Responses[0].Id;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Response>(issueId))
					.ReturnsAsync(Responses[0]).Verifiable();

				// Act

				var result = await ServiceUnderTest.EnforceResponseExistenceAsync(issueId);

				// Assert

				result.Should().BeSameAs(Responses[0]);
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Response>(issueId), Times.Once);
			}

			[Fact()]
			public async Task EnforceUserExistenceAsync_Should_Return_UserNotFoundException_If_The_User_Does_Not_Exist_Test()
			{
				// Arrange

				const long id = 1;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Response>(id))
					.ReturnsAsync(default(Response));

				// Act

				await Assert.ThrowsAsync<ResponseNotFoundException>(() =>
					ServiceUnderTest.EnforceResponseExistenceAsync(id));

				// Assert

				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Response>(id), Times.Once);
			}
		}

		public class CreateResponseAsync : ResponseServiceUnitTests
		{
			[Fact]
			public async Task CreateResponseAsync_Where_Create_Fails_Should__return_a_ResponseNotCreatedException_Test()
			{
				// Arrange

				var expectedLog = $"Creating new Response Failed!";
				var testDate = DateTimeOffset.Now;
				var newId = new Guid().ToString();
				var newResponseDto = new NewResponseDto() { ResponseDescription = "Test 4", ResponderId = newId, ResponderName = "Test", DateAddedUtc = testDate };

				RepositoryMock
					.Setup(x => x.CreateAsync(It.IsAny<Response>()))
					.Throws(new Exception("Create Failed")).Verifiable();

				// Act

				await Assert.ThrowsAsync<ResponseNotCreatedException>(() => ServiceUnderTest.CreateResponseAsync(newResponseDto));

				// Assert

				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				RepositoryMock.Verify(x => x.CreateAsync(It.IsAny<Response>()), Times.Once);
			}

			[Fact]
			public async Task CreateResponseAsync_Should_create_and_return_the_specified_Response_Test()
			{
				// Arrange

				var newResponseDto = new NewResponseDto()
				{ ResponseDescription = "Test 5", ResponderId = new Guid().ToString(), ResponderName = "Test", DateAddedUtc = DateTimeOffset.Now };

				RepositoryMock
					.Setup(x => x.CreateAsync(It.IsAny<Response>()))
					.Returns(() => Task.Run(() => { return 1; })).Verifiable();

				// Act

				var result = await ServiceUnderTest.CreateResponseAsync(newResponseDto);

				// Assert

				result.Should().NotBeNull();
				result.Should().BeOfType<ResponseDto>();
				RepositoryMock.Verify(x => x.CreateAsync(It.IsAny<Response>()), Times.Once);
			}
		}

		public class UpdateResponseAsync : ResponseServiceUnitTests
		{
			[Fact()]
			public async Task UpdateResponseAsync_With_A_NonExisting_Response_Should_Return_ResponseNotFoundException_Test()
			{
				// Arrange

				var issueToUpdateDto = new ResponseForUpdateDto() { Id = 1, ResponseDescription = "Test 1 updated" };

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Response>(issueToUpdateDto.Id))
					.ReturnsAsync(default(Response)).Verifiable();

				// Act

				await Assert.ThrowsAsync<ResponseNotFoundException>(() => ServiceUnderTest.UpdateResponseAsync(issueToUpdateDto.Id, issueToUpdateDto));

				// Assert

				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Response>(issueToUpdateDto.Id), Times.Once);
			}

			[Fact]
			public async Task UpdateResponseAsync_Where_Repositroy_Fails_Should__return_a_ResponseNotUpdatedException_Test()
			{
				// Arrange

				const long id = 1;
				var expectedLog = $"Updating Response: {id} Failed!";
				var issueToUpdateDto = new ResponseForUpdateDto
				{ Id = 1, ResponseDescription = "Test 1 updated", DateModifiedUtc = DateTimeOffset.Now };

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Response>(Responses[0].Id))
					.ReturnsAsync(Responses[0]).Verifiable();

				RepositoryMock
					.Setup(x => x.UpdateAsync(It.IsAny<Response>()))
					.Throws(new Exception("Update Failed")).Verifiable();

				// Act

				await Assert.ThrowsAsync<ResponseNotUpdatedException>(() => ServiceUnderTest.UpdateResponseAsync(issueToUpdateDto.Id, issueToUpdateDto));

				// Assert

				LoggerMock.VerifyLog(LogLevel.Error, expectedLog);
				RepositoryMock.Verify(x => x.UpdateAsync(It.IsAny<Response>()), Times.Once);
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Response>(ResponseToDeleteDto.Id), Times.Once);
			}

			[Fact]
			public async Task UpdateResponseAsync_Should_Update_and_return_the_specified_Response_Test()
			{
				// Arrange

				const long id = 1;

				var issueToUpdateDto = new ResponseForUpdateDto()
				{ Id = 1, ResponseDescription = "Test 1 updated", DateModifiedUtc = DateTimeOffset.Now };

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Response>(id))
					.ReturnsAsync(Responses[0]).Verifiable();

				RepositoryMock
					.Setup(x => x.UpdateAsync(It.IsAny<Response>()))
					.Returns(() => Task.Run(() => { return 1; })).Verifiable();

				// Act

				var result = await ServiceUnderTest.UpdateResponseAsync(issueToUpdateDto.Id, issueToUpdateDto);

				// Assert

				result.Should().BeTrue();
				RepositoryMock.Verify(x => x.UpdateAsync(It.IsAny<Response>()), Times.Once);
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Response>(ResponseToDeleteDto.Id), Times.Once);
			}
		}

		public class DeleteResponseAsync : ResponseServiceUnitTests
		{
			[Fact()]
			public async Task DeleteResponseAsync_With_A_NonExisting_Response_Should_Return_ResponseNotFoundException_Test()
			{
				// Arrange

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Response>(ResponseToDeleteDto.Id))
					.ReturnsAsync(default(Response)).Verifiable();

				// Act

				await Assert.ThrowsAsync<ResponseNotFoundException>(() => ServiceUnderTest.DeleteResponseAsync(ResponseToDeleteDto));

				// Assert

				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Response>(ResponseToDeleteDto.Id), Times.Once);
			}

			[Fact]
			public async Task DeleteResponseAsync_Where_Delete_Fails_Should__return_a_ResponseNotCreatedException_Test()
			{
				// Arrange

				var expectedLog = $"Delete Response: {ResponseToDeleteDto.Id} Failed!";

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Response>(ResponseToDeleteDto.Id))
					.ReturnsAsync(Responses[0]).Verifiable();

				RepositoryMock
					.Setup(x => x.UpdateAsync(It.IsAny<Response>()))
					.ThrowsAsync(new Exception("Some Error")).Verifiable();

				// Act

				await Assert.ThrowsAsync<ResponseNotDeletedException>(() => ServiceUnderTest.DeleteResponseAsync(ResponseToDeleteDto));

				// Assert

				LoggerMock.VerifyLog(LogLevel.Error, expectedLog);
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Response>(ResponseToDeleteDto.Id), Times.Once);
				RepositoryMock.Verify(x => x.UpdateAsync(It.IsAny<Response>()), Times.Once);
			}

			[Fact]
			public async Task DeleteResponseAsync_Should_Update_and_return_the_specified_Response_Test()
			{
				// Arrange

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Response>(ResponseToDeleteDto.Id))
					.ReturnsAsync(Responses[0]).Verifiable();

				RepositoryMock
					.Setup(x => x.UpdateAsync(It.IsAny<Response>()))
					.Returns(() => Task.Run(() => { return 1; })).Verifiable();

				// Act

				var result = await ServiceUnderTest.DeleteResponseAsync(ResponseToDeleteDto);

				// Assert

				result.Should().BeTrue();
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Response>(ResponseToDeleteDto.Id), Times.Once);
				RepositoryMock.Verify(x => x.UpdateAsync(It.IsAny<Response>()), Times.Once);
			}
		}
	}
}