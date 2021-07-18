using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using IR.Shared.Data;
using IR.Shared.Models;

using Microsoft.AspNetCore.Mvc;
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
		/// <summary>
		/// Create DbSet Mock
		/// </summary>
		/// <typeparam name="T">The Entity</typeparam>
		/// <param name="elements"></param>
		/// <returns>A Mock DbSet of type T</returns>
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

		/// <summary>
		/// Create Mocked DataContext
		/// </summary>
		/// <param name="options">DbContextOptions</param>
		/// <returns>A Task of type DataContext</returns>
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

		/// <summary>
		/// Seed Data
		/// </summary>
		/// <param name="options"></param>
		/// <returns>Task</returns>
		public static async Task SeedData(DbContextOptions<DataContext> options)
		{
			using var context = new DataContext(options);

			await context.Issues.AddRangeAsync(Issues(3));

			await context.SaveChangesAsync();
		}

		/// <summary>
		/// Set DbContext Options
		/// </summary>
		/// <param name="dbName"></param>
		/// <returns>DbContextOptions</returns>
		public static DbContextOptions<DataContext> SetDbContextOptions(string dbName)
		{
			// Create In Memory Database
			var options = new DbContextOptionsBuilder<DataContext>()
				.UseInMemoryDatabase(databaseName: dbName)
				.Options;
			return options;
		}

		/// <summary>
		/// Mock Model State
		/// </summary>
		/// <typeparam name="TModel">The entity model</typeparam>
		/// <typeparam name="TController">The Controller</typeparam>
		/// <param name="model">An Entity Model</param>
		/// <param name="controller">A Controller</param>
		public static void MockModelState<TModel, TController>(TModel model, TController controller) where TController : ControllerBase
		{
			var validationContext = new ValidationContext(model, null, null);
			var validationResults = new List<ValidationResult>();
			Validator.TryValidateObject(model, validationContext, validationResults, true);
			foreach (var validationResult in validationResults)
			{
				controller.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
			}
		}
	}
}