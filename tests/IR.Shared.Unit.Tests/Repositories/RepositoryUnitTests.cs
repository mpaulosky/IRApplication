using FluentAssertions;

using IR.Shared.Data;
using IR.Shared.Interfaces;
using IR.Shared.Models;
using IR.Shared.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TestHelpers;

using Xunit;

namespace IR.Shared.Unit.Tests.Repositories
{
	public class RepositoryUnitTests
	{
		protected IRepository RepositoryUnderTest { get; set; }

		protected List<Issue> IssueList { get; }

		protected RepositoryUnitTests()
		{
			IssueList = new List<Issue>
			{
				new Issue {Id = 1, IssueDescription = "Test 1", DateAddedUtc = DateTimeOffset.Now},
				new Issue {Id = 2, IssueDescription = "Test 2", DateAddedUtc = DateTimeOffset.Now},
				new Issue {Id = 3, IssueDescription = "Test 3", DateAddedUtc = DateTimeOffset.Now}
			};
		}

		public class SelectAllAsync : RepositoryUnitTests
		{
			[Fact()]
			public async Task SelectAllAsync_Should_return_all_issues_TestAsync()
			{
				// Arrange

				var options = MockHelpers.SetDbContextOptions("select_all");

				using (var context = new DataContext(options))
				{
					context.AddRange(IssueList);
					context.SaveChanges();
				}

				using (var context = new DataContext(options))
				{
					RepositoryUnderTest = new Repository<DataContext>(context);

					// Act

					var result = await RepositoryUnderTest.SelectAllAsync<Issue>();

					// Assert

					var items = result.ToList();
					items.Count.Should().Be(3);
					items[0].Id.Should().Be(IssueList[0].Id);
					items[1].Id.Should().Be(IssueList[1].Id);
					items[2].Id.Should().Be(IssueList[2].Id);
				}
			}
		}

		public class SelectByIdAsync : RepositoryUnitTests
		{
			[Fact()]
			public async Task SelectByIdAsync_Should_return_the_expected_Issue_TestAsync()
			{
				// Arrange

				var options = MockHelpers.SetDbContextOptions("select_by_id");

				using (var context = new DataContext(options))
				{
					context.AddRange(IssueList);
					context.SaveChanges();
				}

				using (var context = new DataContext(options))
				{
					RepositoryUnderTest = new Repository<DataContext>(context);


					// Act

					var result = await RepositoryUnderTest.SelectByIdAsync<Issue>(IssueList[1].Id);

					// Assert

					result.Should().NotBeNull();
					result.Id.Should().Be(IssueList[1].Id);
				}
			}

			[Fact()]
			public async Task SelectByIdAsync_Should_return_null_if_the_issue_does_not_exist_TestAsync()
			{
				// Arrange

				const int invalidId = 5;

				var options = MockHelpers.SetDbContextOptions("select_by_id_invalid_id");

				using (var context = new DataContext(options))
				{
					context.AddRange(IssueList);
					context.SaveChanges();
				}

				using (var context = new DataContext(options))
				{
					RepositoryUnderTest = new Repository<DataContext>(context);


					// Act
					var result = await RepositoryUnderTest.SelectByIdAsync<Issue>(invalidId);

					// Assert
					Assert.Null(result);
				}
			}
		}

		public class CreateAsync : RepositoryUnitTests
		{
			[Fact()]
			public async Task CreateAsync_Should_Set_the_Id_to_next_available_TestAsync()
			{
				// Arrange

				var options = MockHelpers.SetDbContextOptions("create");

				using (var context = new DataContext(options))
				{
					context.AddRange(IssueList);
					context.SaveChanges();
				}

				using (var context = new DataContext(options))
				{
					RepositoryUnderTest = new Repository<DataContext>(context);

					var newIssue = new Issue { IssueDescription = "Test 5", DateAddedUtc = DateTimeOffset.Now };

					// Act

					await RepositoryUnderTest.CreateAsync(newIssue);

					// Assert

					newIssue.Id.Should().NotBe(0);
					newIssue.Id.Should().Be(4);
				}
			}
		}

		public class UpdateAsync : RepositoryUnitTests
		{
			[Fact()]
			public async Task UpdateAsync_Should_Set_the_Entity_State_as_Modified_Test()
			{
				// Arrange

				var updatedIssue = new Issue { Id = 1, IssueDescription = "Test 1 Updated", DateAddedUtc = DateTimeOffset.Now };

				var options = MockHelpers.SetDbContextOptions("update");

				using (var context = new DataContext(options))
				{
					context.AddRange(IssueList);
					context.SaveChanges();
				}

				using (var context = new DataContext(options))
				{
					RepositoryUnderTest = new Repository<DataContext>(context);


					// Act

					await RepositoryUnderTest.UpdateAsync(updatedIssue);
				}

				using (var context = new DataContext(options))
				{
					RepositoryUnderTest = new Repository<DataContext>(context);

					var result = await RepositoryUnderTest.SelectByIdAsync<Issue>(updatedIssue.Id);

					// Assert

					result.Should().NotBeNull();
					result.Id.Should().Be(1);
					result.IssueDescription.Should().Be(updatedIssue.IssueDescription);
				}
			}
		}

		public class DeleteAsync : RepositoryUnitTests
		{
			[Fact()]
			public async Task DeleteAsync_Should_Set_the_Entity_State_as_Deleted_Test()
			{
				// Arrange

				var options = MockHelpers.SetDbContextOptions("delete");

				using (var context = new DataContext(options))
				{
					context.AddRange(IssueList);
					context.SaveChanges();
				}

				using (var context = new DataContext(options))
				{
					RepositoryUnderTest = new Repository<DataContext>(context);

					// Act

					await RepositoryUnderTest.DeleteAsync(IssueList[0]);
				}

				using (var context = new DataContext(options))
				{
					RepositoryUnderTest = new Repository<DataContext>(context);


					var result = await RepositoryUnderTest.SelectByIdAsync<Issue>(IssueList[0].Id);

					// Assert

					result.Should().BeNull();
				}
			}
		}
	}
}