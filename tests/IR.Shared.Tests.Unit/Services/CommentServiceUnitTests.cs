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
	public class CommentServiceUnitTests
	{
		private ICommentService ServiceUnderTest { get; }
		private Mock<IRepository> RepositoryMock { get; }
		private Comment[] Comments { get; }
		private Mock<ILogger<CommentService>> LoggerMock { get; }
		private CommentDto[] CommentDtos { get; }
		private CommentForDeleteDto CommentToDeleteDto { get; }

		protected CommentServiceUnitTests()
		{
			Comments = new[]
			{
				new Comment
				{
					Id = 1,
					CommentDescription = "Test 1",
					DateAddedUtc = DateTimeOffset.Now,
				},
				new Comment
				{
					Id = 2,
					CommentDescription = "Test 2",
					DateAddedUtc = DateTimeOffset.Now,
				},
				new Comment
				{
					Id = 3,
					CommentDescription = "Test 3",
					DateAddedUtc = DateTimeOffset.Now,
				}
			};
			CommentDtos = new[]
			{
				new CommentDto
				{
					Id = 1,
					CommentDescription = "Test 1",
					DateAddedUtc = DateTimeOffset.Now,
				},
				new CommentDto
				{
					Id = 2,
					CommentDescription = "Test 2",
					DateAddedUtc = DateTimeOffset.Now,
				},
				new CommentDto
				{
					Id = 3,
					CommentDescription = "Test 3",
					DateAddedUtc = DateTimeOffset.Now,
				}
			};

			CommentToDeleteDto = new CommentForDeleteDto(1, false);


			LoggerMock = new Mock<ILogger<CommentService>>();

			RepositoryMock = new Mock<IRepository>();
			ServiceUnderTest = new CommentService(RepositoryMock.Object, AutoMapperSingleton.Mapper, LoggerMock.Object);
		}

		public class GetAllCommentsAsync : CommentServiceUnitTests
		{
			[Fact()]
			public async Task GetAllCommentsAsync_Should_Return_All_Comments_Test()
			{
				// Arrange
				var issuesToReturn = Comments.AsQueryable();

				RepositoryMock
					.Setup(x => x.SelectAllAsync<Comment>())
					.ReturnsAsync(issuesToReturn);

				// Act

				var result = await ServiceUnderTest.GetCommentsAsync();

				// Assert

				var items = result.ToList();
				items.Count.Should().Be(3);
				items[0].CommentDescription.Should().Contain(CommentDtos[0].CommentDescription);
				items[1].CommentDescription.Should().Contain(CommentDtos[1].CommentDescription);
				items[2].CommentDescription.Should().Contain(CommentDtos[2].CommentDescription);
			}
		}

		public class GetCommentByIdAsync : CommentServiceUnitTests
		{
			[Fact()]
			public async Task GetCommentByIdAsync_With_Valid_Id_Should_Return_The_Expected_Comment_Test()
			{
				// Arrange

				const long id = 1;
				var expectedComment = Comments[0];

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Comment>(expectedComment.Id))
					.ReturnsAsync(Comments[0]);

				// Act

				var result = await ServiceUnderTest.GetCommentByIdAsync(id);

				// Assert

				result.Should().BeOfType<CommentDto>();
				result.Id.Should().Be(expectedComment.Id);
				result.CommentDescription.Should().Contain(expectedComment.CommentDescription);
			}

			[Fact()]
			public async Task GetCommentByIdAsync_With_Invalid_Id_Should_Return_Null_If_The_Comment_Does_Not_Exist_Test()
			{
				// Arrange

				var id = -1;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Comment>(id))
					.ReturnsAsync(default(Comment));

				// Act, Assert

				await Assert.ThrowsAsync<CommentNotFoundException>(() => ServiceUnderTest.GetCommentByIdAsync(id));
			}
		}

		public class CommentExitsAsync : CommentServiceUnitTests
		{
			[Fact()]
			public async Task CommentExistsAsync_Should_Return_True_If_The_Comment_Exists_Test()
			{
				// Arrange

				var id = 1;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Comment>(id))
					.ReturnsAsync(new Comment());

				// Act

				var result = await ServiceUnderTest.CommentExistsAsync(id);

				// Assert

				Assert.True(result);
			}

			[Fact()]
			public async Task CommentExistsAsync_Should_Return_False_If_The_Comment_Does_Not_Exist_Test()
			{
				// Arrange

				const long id = 0;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Comment>(id))
					.ReturnsAsync(default(Comment));

				// Act

				var result = await ServiceUnderTest.CommentExistsAsync(id);

				// Assert

				Assert.False(result);
			}
		}

		public class EnforceCommentExistenceAsync : CommentServiceUnitTests
		{
			[Fact()]
			public async Task EnforceUserExistenceAsync_Should_Return_User_If_The_User_Exists_Test()
			{
				// Arrange

				var issueId = Comments[0].Id;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Comment>(issueId))
					.ReturnsAsync(Comments[0]).Verifiable();

				// Act

				var result = await ServiceUnderTest.EnforceCommentExistenceAsync(issueId);

				// Assert

				result.Should().BeSameAs(Comments[0]);
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Comment>(issueId), Times.Once);
			}

			[Fact()]
			public async Task EnforceUserExistenceAsync_Should_Return_UserNotFoundException_If_The_User_Does_Not_Exist_Test()
			{
				// Arrange

				const long id = 1;

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Comment>(id))
					.ReturnsAsync(default(Comment));

				// Act

				await Assert.ThrowsAsync<CommentNotFoundException>(() =>
					ServiceUnderTest.EnforceCommentExistenceAsync(id));

				// Assert

				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Comment>(id), Times.Once);
			}
		}

		public class CreateCommentAsync : CommentServiceUnitTests
		{
			[Fact]
			public async Task CreateCommentAsync_Where_Create_Fails_Should__return_a_CommentNotCreatedException_Test()
			{
				// Arrange

				var expectedLog = $"Creating new Comment Failed!";
				var testDate = DateTimeOffset.Now;
				var newId = new Guid().ToString();
				var newCommentDto = new NewCommentDto() { CommentDescription = "Test 4", CommenterId = newId, CommenterName = "Test", DateAddedUtc = testDate };

				RepositoryMock
					.Setup(x => x.CreateAsync(It.IsAny<Comment>()))
					.Throws(new Exception("Create Failed")).Verifiable();

				// Act

				await Assert.ThrowsAsync<CommentNotCreatedException>(() => ServiceUnderTest.CreateCommentAsync(newCommentDto));

				// Assert

				LoggerMock.Invocations.Count.Should().Be(1);
				LoggerMock.Invocations[0].Arguments[2].ToString().Should().Contain(expectedLog);

				RepositoryMock.Verify(x => x.CreateAsync(It.IsAny<Comment>()), Times.Once);
			}

			[Fact]
			public async Task CreateCommentAsync_Should_create_and_return_the_specified_Comment_Test()
			{
				// Arrange

				var newCommentDto = new NewCommentDto()
				{ CommentDescription = "Test 5", CommenterId = new Guid().ToString(), CommenterName = "Test", DateAddedUtc = DateTimeOffset.Now };

				RepositoryMock
					.Setup(x => x.CreateAsync(It.IsAny<Comment>()))
					.Returns(() => Task.Run(() => { return 1; })).Verifiable();

				// Act

				var result = await ServiceUnderTest.CreateCommentAsync(newCommentDto);

				// Assert

				result.Should().NotBeNull();
				result.Should().BeOfType<CommentDto>();
				RepositoryMock.Verify(x => x.CreateAsync(It.IsAny<Comment>()), Times.Once);
			}
		}

		public class UpdateCommentAsync : CommentServiceUnitTests
		{
			[Fact()]
			public async Task UpdateCommentAsync_With_A_NonExisting_Comment_Should_Return_CommentNotFoundException_Test()
			{
				// Arrange

				var issueToUpdateDto = new CommentForUpdateDto() { Id = 1, CommentDescription = "Test 1 updated" };

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Comment>(issueToUpdateDto.Id))
					.ReturnsAsync(default(Comment)).Verifiable();

				// Act

				await Assert.ThrowsAsync<CommentNotFoundException>(() => ServiceUnderTest.UpdateCommentAsync(issueToUpdateDto.Id, issueToUpdateDto));

				// Assert

				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Comment>(issueToUpdateDto.Id), Times.Once);
			}

			[Fact]
			public async Task UpdateCommentAsync_Where_Repositroy_Fails_Should__return_a_CommentNotUpdatedException_Test()
			{
				// Arrange

				const long id = 1;
				var expectedLog = $"Updating Comment: {id} Failed!";
				var issueToUpdateDto = new CommentForUpdateDto
				{ Id = 1, CommentDescription = "Test 1 updated", DateModifiedUtc = DateTimeOffset.Now };

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Comment>(Comments[0].Id))
					.ReturnsAsync(Comments[0]).Verifiable();

				RepositoryMock
					.Setup(x => x.UpdateAsync(It.IsAny<Comment>()))
					.Throws(new Exception("Update Failed")).Verifiable();

				// Act

				await Assert.ThrowsAsync<CommentNotUpdatedException>(() => ServiceUnderTest.UpdateCommentAsync(issueToUpdateDto.Id, issueToUpdateDto));

				// Assert

				LoggerMock.VerifyLog(LogLevel.Error, expectedLog);
				RepositoryMock.Verify(x => x.UpdateAsync(It.IsAny<Comment>()), Times.Once);
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Comment>(CommentToDeleteDto.Id), Times.Once);
			}

			[Fact]
			public async Task UpdateCommentAsync_Should_Update_and_return_the_specified_Comment_Test()
			{
				// Arrange

				const long id = 1;

				var issueToUpdateDto = new CommentForUpdateDto()
				{ Id = 1, CommentDescription = "Test 1 updated", DateModifiedUtc = DateTimeOffset.Now };

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Comment>(id))
					.ReturnsAsync(Comments[0]).Verifiable();

				RepositoryMock
					.Setup(x => x.UpdateAsync(It.IsAny<Comment>()))
					.Returns(() => Task.Run(() => { return 1; })).Verifiable();

				// Act

				var result = await ServiceUnderTest.UpdateCommentAsync(issueToUpdateDto.Id, issueToUpdateDto);

				// Assert

				result.Should().BeTrue();
				RepositoryMock.Verify(x => x.UpdateAsync(It.IsAny<Comment>()), Times.Once);
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Comment>(CommentToDeleteDto.Id), Times.Once);
			}
		}

		public class DeleteCommentAsync : CommentServiceUnitTests
		{
			[Fact()]
			public async Task DeleteCommentAsync_With_A_NonExisting_Comment_Should_Return_CommentNotFoundException_Test()
			{
				// Arrange

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Comment>(CommentToDeleteDto.Id))
					.ReturnsAsync(default(Comment)).Verifiable();

				// Act

				await Assert.ThrowsAsync<CommentNotFoundException>(() => ServiceUnderTest.DeleteCommentAsync(CommentToDeleteDto));

				// Assert

				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Comment>(CommentToDeleteDto.Id), Times.Once);
			}

			[Fact]
			public async Task DeleteCommentAsync_Where_Delete_Fails_Should__return_a_CommentNotCreatedException_Test()
			{
				// Arrange

				var expectedLog = $"Delete Comment: {CommentToDeleteDto.Id} Failed!";

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Comment>(CommentToDeleteDto.Id))
					.ReturnsAsync(Comments[0]).Verifiable();

				RepositoryMock
					.Setup(x => x.UpdateAsync(It.IsAny<Comment>()))
					.ThrowsAsync(new Exception("Some Error")).Verifiable();

				// Act

				await Assert.ThrowsAsync<CommentNotDeletedException>(() => ServiceUnderTest.DeleteCommentAsync(CommentToDeleteDto));

				// Assert

				LoggerMock.VerifyLog(LogLevel.Error, expectedLog);
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Comment>(CommentToDeleteDto.Id), Times.Once);
				RepositoryMock.Verify(x => x.UpdateAsync(It.IsAny<Comment>()), Times.Once);
			}

			[Fact]
			public async Task DeleteCommentAsync_Should_Update_and_return_the_specified_Comment_Test()
			{
				// Arrange

				RepositoryMock
					.Setup(x => x.SelectByIdAsync<Comment>(CommentToDeleteDto.Id))
					.ReturnsAsync(Comments[0]).Verifiable();

				RepositoryMock
					.Setup(x => x.UpdateAsync(It.IsAny<Comment>()))
					.Returns(() => Task.Run(() => { return 1; })).Verifiable();

				// Act

				var result = await ServiceUnderTest.DeleteCommentAsync(CommentToDeleteDto);

				// Assert

				result.Should().BeTrue();
				RepositoryMock
					.Verify(x => x.SelectByIdAsync<Comment>(CommentToDeleteDto.Id), Times.Once);
				RepositoryMock.Verify(x => x.UpdateAsync(It.IsAny<Comment>()), Times.Once);
			}
		}
	}
}