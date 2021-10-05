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
	public class IssueServiceUnitTests
	{
		private IIssueService ServiceUnderTest { get; }
		private Mock<IRepository> RepositoryMock { get; }
		private Issue[] Issues { get; }
		private Mock<ILogger<IssueService>> LoggerMock { get; }
		private IssueDto[] IssueDtos { get; }
		private IssueForDeleteDto IssueToDeleteDto { get; }

		protected IssueServiceUnitTests()
		{
			Issues = new[]
			{
				new Issue
				{
					Id = 1,
					IssueDescription = "Test 1",
					DateAddedUtc = DateTimeOffset.Now,
				},
				new Issue
				{
					Id = 2,
					IssueDescription = "Test 2",
					DateAddedUtc = DateTimeOffset.Now,
				},
				new Issue
				{
					Id = 3,
					IssueDescription = "Test 3",
					DateAddedUtc = DateTimeOffset.Now,
				}
			};
			IssueDtos = new[]
			{
				new IssueDto
				{
					Id = 1,
					IssueDescription = "Test 1",
					DateAddedUtc = DateTimeOffset.Now,
				},
				new IssueDto
				{
					Id = 2,
					IssueDescription = "Test 2",
					DateAddedUtc = DateTimeOffset.Now,
				},
				new IssueDto
				{
					Id = 3,
					IssueDescription = "Test 3",
					DateAddedUtc = DateTimeOffset.Now,
				}
			};

			IssueToDeleteDto = new IssueForDeleteDto(1, false);


			LoggerMock = new Mock<ILogger<IssueService>>();

			RepositoryMock = new Mock<IRepository>();
			ServiceUnderTest = new IssueService(RepositoryMock.Object, AutoMapperSingleton.Mapper, LoggerMock.Object);
		}

		public class GetAllIssuesAsync : IssueServiceUnitTests
		{
			[Fact()]
			public async Task GetAllIssuesAsync_Should_Return_All_Issues_Test()
			{
				// Arrange
				var issuesToReturn = Issues.AsQueryable();

				RepositoryMock
					.Setup(x => x.SelectAllAsync<Issue>())
					.ReturnsAsync(issuesToReturn);

				// Act

				var result = await ServiceUnderTest.GetIssuesAsync();

				// Assert

				var items = result.ToList();
				items.Count.Should().Be(3);
				items[0].IssueDescription.Should().Contain(IssueDtos[0].IssueDescription);
				items[1].IssueDescription.Should().Contain(IssueDtos[1].IssueDescription);
				items[2].IssueDescription.Should().Contain(IssueDtos[2].IssueDescription);
			}
		}

		public class GetIssueByIdAsync : IssueServiceUnitTests
		{
			[Fact()]
			public async Task GetIssueByIdAsync_With_Valid_Id_Should_Return_The_Expected_Issue_Test()
			{
				// Arrange

				const long id = 1;
				var expectedIssue = Issues[0];

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Issue>(expectedIssue.Id))
					.ReturnsAsync(Issues[0]);

				// Act

				var result = await ServiceUnderTest.GetIssueByIdAsync(id);

				// Assert

				result.Should().BeOfType<IssueDto>();
				result.Id.Should().Be(expectedIssue.Id);
				result.IssueDescription.Should().Contain(expectedIssue.IssueDescription);
			}

			[Fact()]
			public async Task GetIssueByIdAsync_With_Invalid_Id_Should_Return_Null_If_The_Issue_Does_Not_Exist_Test()
			{
				// Arrange

				var id = -1;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Issue>(id))
					.ReturnsAsync(default(Issue));

				// Act, Assert

				await Assert.ThrowsAsync<IssueNotFoundException>(() => ServiceUnderTest.GetIssueByIdAsync(id));
			}
		}

		public class IssueExitsAsync : IssueServiceUnitTests
		{
			[Fact()]
			public async Task IssueExistsAsync_Should_Return_True_If_The_Issue_Exists_Test()
			{
				// Arrange

				var id = 1;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Issue>(id))
					.ReturnsAsync(new Issue());

				// Act

				var result = await ServiceUnderTest.IssueExistsAsync(id);

				// Assert

				Assert.True(result);
			}

			[Fact()]
			public async Task IssueExistsAsync_Should_Return_False_If_The_Issue_Does_Not_Exist_Test()
			{
				// Arrange

				const long id = 0;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Issue>(id))
					.ReturnsAsync(default(Issue));

				// Act

				var result = await ServiceUnderTest.IssueExistsAsync(id);

				// Assert

				Assert.False(result);
			}
		}

		public class EnforceIssueExistenceAsync : IssueServiceUnitTests
		{
			[Fact()]
			public async Task EnforceUserExistenceAsync_Should_Return_User_If_The_User_Exists_Test()
			{
				// Arrange

				var issueId = Issues[0].Id;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Issue>(issueId))
					.ReturnsAsync(Issues[0]).Verifiable();

				// Act

				var result = await ServiceUnderTest.EnforceIssueExistenceAsync(issueId);

				// Assert

				result.Should().BeSameAs(Issues[0]);
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Issue>(issueId), Times.Once);
			}

			[Fact()]
			public async Task EnforceUserExistenceAsync_Should_Return_UserNotFoundException_If_The_User_Does_Not_Exist_Test()
			{
				// Arrange

				const long id = 1;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Issue>(id))
					.ReturnsAsync(default(Issue));

				// Act

				await Assert.ThrowsAsync<IssueNotFoundException>(() =>
					ServiceUnderTest.EnforceIssueExistenceAsync(id));

				// Assert

				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Issue>(id), Times.Once);
			}
		}

		public class CreateIssueAsync : IssueServiceUnitTests
		{
			[Fact]
			public async Task CreateIssueAsync_Where_Create_Fails_Should__return_a_IssueNotCreatedException_Test()
			{
				// Arrange

				var expectedLog = $"Creating new Issue Failed!";
				var testDate = DateTimeOffset.Now;
				var newId = new Guid().ToString();
				var newIssueDto = new NewIssueDto() { IssueDescription = "Test 4", InitiatorId = newId, InitiatorName = "Test", DateAddedUtc = testDate };

				RepositoryMock
					.Setup(x => x.CreateAsync(It.IsAny<Issue>()))
					.Throws(new Exception("Create Failed")).Verifiable();

				// Act

				await Assert.ThrowsAsync<IssueNotCreatedException>(() => ServiceUnderTest.CreateIssueAsync(newIssueDto));

				// Assert

				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				RepositoryMock.Verify(x => x.CreateAsync(It.IsAny<Issue>()), Times.Once);
			}

			[Fact]
			public async Task CreateIssueAsync_Should_create_and_return_the_specified_Issue_Test()
			{
				// Arrange

				var newIssueDto = new NewIssueDto()
				{ IssueDescription = "Test 5", InitiatorId = new Guid().ToString(), InitiatorName = "Test", DateAddedUtc = DateTimeOffset.Now };

				RepositoryMock
					.Setup(x => x.CreateAsync(It.IsAny<Issue>()))
					.Returns(() => Task.Run(() => { return 1; })).Verifiable();

				// Act

				var result = await ServiceUnderTest.CreateIssueAsync(newIssueDto);

				// Assert

				result.Should().NotBeNull();
				result.Should().BeOfType<IssueDto>();
				RepositoryMock.Verify(x => x.CreateAsync(It.IsAny<Issue>()), Times.Once);
			}
		}

		public class UpdateIssueAsync : IssueServiceUnitTests
		{
			[Fact()]
			public async Task UpdateIssueAsync_With_A_NonExisting_Issue_Should_Return_IssueNotFoundException_Test()
			{
				// Arrange

				var issueToUpdateDto = new IssueForUpdateDto() { Id = 1, IssueDescription = "Test 1 updated" };

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Issue>(issueToUpdateDto.Id))
					.ReturnsAsync(default(Issue)).Verifiable();

				// Act

				await Assert.ThrowsAsync<IssueNotFoundException>(() => ServiceUnderTest.UpdateIssueAsync(issueToUpdateDto.Id, issueToUpdateDto));

				// Assert

				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Issue>(issueToUpdateDto.Id), Times.Once);
			}

			[Fact]
			public async Task UpdateIssueAsync_Where_Repositroy_Fails_Should__return_a_IssueNotUpdatedException_Test()
			{
				// Arrange

				const long id = 1;
				var expectedLog = $"Updating Issue: {id} Failed!";
				var issueToUpdateDto = new IssueForUpdateDto
				{ Id = 1, IssueDescription = "Test 1 updated", DateModifiedUtc = DateTimeOffset.Now };

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Issue>(Issues[0].Id))
					.ReturnsAsync(Issues[0]).Verifiable();

				RepositoryMock
					.Setup(x => x.UpdateAsync(It.IsAny<Issue>()))
					.Throws(new Exception("Update Failed")).Verifiable();

				// Act

				await Assert.ThrowsAsync<IssueNotUpdatedException>(() => ServiceUnderTest.UpdateIssueAsync(issueToUpdateDto.Id, issueToUpdateDto));

				// Assert

				LoggerMock.VerifyLog(LogLevel.Error, expectedLog);
				RepositoryMock.Verify(x => x.UpdateAsync(It.IsAny<Issue>()), Times.Once);
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Issue>(IssueToDeleteDto.Id), Times.Once);
			}

			[Fact]
			public async Task UpdateIssueAsync_Should_Update_and_return_the_specified_Issue_Test()
			{
				// Arrange

				const long id = 1;

				var issueToUpdateDto = new IssueForUpdateDto()
				{ Id = 1, IssueDescription = "Test 1 updated", DateModifiedUtc = DateTimeOffset.Now };

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Issue>(id))
					.ReturnsAsync(Issues[0]).Verifiable();

				RepositoryMock
					.Setup(x => x.UpdateAsync(It.IsAny<Issue>()))
					.Returns(() => Task.Run(() => { return 1; })).Verifiable();

				// Act

				var result = await ServiceUnderTest.UpdateIssueAsync(issueToUpdateDto.Id, issueToUpdateDto);

				// Assert

				result.Should().BeTrue();
				RepositoryMock.Verify(x => x.UpdateAsync(It.IsAny<Issue>()), Times.Once);
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Issue>(IssueToDeleteDto.Id), Times.Once);
			}
		}

		public class DeleteIssueAsync : IssueServiceUnitTests
		{
			[Fact()]
			public async Task DeleteIssueAsync_With_A_NonExisting_Issue_Should_Return_IssueNotFoundException_Test()
			{
				// Arrange

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Issue>(IssueToDeleteDto.Id))
					.ReturnsAsync(default(Issue)).Verifiable();

				// Act

				await Assert.ThrowsAsync<IssueNotFoundException>(() => ServiceUnderTest.DeleteIssueAsync(IssueToDeleteDto));

				// Assert

				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Issue>(IssueToDeleteDto.Id), Times.Once);
			}

			[Fact]
			public async Task DeleteIssueAsync_Where_Delete_Fails_Should__return_a_IssueNotCreatedException_Test()
			{
				// Arrange

				var expectedLog = $"Delete Issue: {IssueToDeleteDto.Id} Failed!";

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Issue>(IssueToDeleteDto.Id))
					.ReturnsAsync(Issues[0]).Verifiable();

				RepositoryMock
					.Setup(x => x.UpdateAsync(It.IsAny<Issue>()))
					.ThrowsAsync(new Exception("Some Error")).Verifiable();

				// Act

				await Assert.ThrowsAsync<IssueNotDeletedException>(() => ServiceUnderTest.DeleteIssueAsync(IssueToDeleteDto));

				// Assert

				LoggerMock.VerifyLog(LogLevel.Error, expectedLog);
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Issue>(IssueToDeleteDto.Id), Times.Once);
				RepositoryMock.Verify(x => x.UpdateAsync(It.IsAny<Issue>()), Times.Once);
			}

			[Fact]
			public async Task DeleteIssueAsync_Should_Update_and_return_the_specified_Issue_Test()
			{
				// Arrange

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Issue>(IssueToDeleteDto.Id))
					.ReturnsAsync(Issues[0]).Verifiable();

				RepositoryMock
					.Setup(x => x.UpdateAsync(It.IsAny<Issue>()))
					.Returns(() => Task.Run(() => { return 1; })).Verifiable();

				// Act

				var result = await ServiceUnderTest.DeleteIssueAsync(IssueToDeleteDto);

				// Assert

				result.Should().BeTrue();
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Issue>(IssueToDeleteDto.Id), Times.Once);
				RepositoryMock.Verify(x => x.UpdateAsync(It.IsAny<Issue>()), Times.Once);
			}
		}
	}
}