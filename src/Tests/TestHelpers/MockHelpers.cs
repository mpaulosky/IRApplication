using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using IR.Shared.Data;
using IR.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace TestHelpers
{
	/// <summary>
	///   <![CDATA[https://github.com/dotnet/aspnetcore/blob/master/src/Identity/test/Shared/MockHelpers.cs]]>
	/// </summary>
	[ExcludeFromCodeCoverage]
	public static class MockHelpers
	{
		public static Mock<DbSet<T>> CreateDbSetMock<T>(IEnumerable<T> elements) where T : class
		{
			var elementsAsQueryable = elements.AsQueryable();
			var dbSetMock = new Mock<DbSet<T>>();

			dbSetMock.As<IQueryable<T>>().Setup(m => m.Provider).Returns(elementsAsQueryable.Provider);
			dbSetMock.As<IQueryable<T>>().Setup(m => m.Expression).Returns(elementsAsQueryable.Expression);
			dbSetMock.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(elementsAsQueryable.ElementType);
			dbSetMock.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(elementsAsQueryable.GetEnumerator());

			return dbSetMock;
		}

		/// <summary>
		///   Issues
		/// </summary>
		/// <param name="countOfIssues">int number of Issues wanted for testing</param>
		/// <returns>This returns a list of Issues for testing purposes.</returns>
		public static List<Issue> Issues(int countOfIssues)
		{
			var issues = new List<Issue>();

			for (var i = 0; i < countOfIssues; i++)
			{
				var issue = new Issue {Id = i, IssueDescription = $"{i} Issue description", DateAddedUtc = DateTimeOffset.Now};
				issues.Add(issue);
			}

			return issues;
		}


		public static async Task<DataContext> CreateMockedDataContext(DbContextOptions<DataContext> options)
		{
			try
			{
				// Create Mocked Context by Seeding Data
				await using var context = new DataContext(options);
				await context.Database.EnsureDeletedAsync();
				await context.Database.EnsureCreatedAsync();

				if (context.Issues.Any())
				{
					context.Issues.RemoveRange(Issues(3));
					await context.SaveChangesAsync();

					await context.Issues.AddRangeAsync(Issues(3));
					await context.SaveChangesAsync();
				}
				else
				{
					await context.Issues.AddRangeAsync(Issues(3));

					await context.SaveChangesAsync();
				}

				return context;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return null;
			}
		}

		public static async Task SeedData(DbContextOptions<DataContext> options)
		{
			using var context = new DataContext(options);

			await context.Issues.AddRangeAsync(Issues(3));

			await context.SaveChangesAsync();
		}

		public static DbContextOptions<DataContext> SetDbContextOptions(string dbName)
		{
			// Create In Memory Database
			var options = new DbContextOptionsBuilder<DataContext>()
				.UseInMemoryDatabase(databaseName: dbName)
				.Options;
			return options;
		}
	}
}