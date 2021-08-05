using IR.Shared.Data;
using IR.Shared.Models;

using System;
using System.Collections.Generic;

namespace IR.Server.Tests.Integration
{
	public static class Utilities
	{
		public static void InitializeDbForTests(DataContext db)
		{
			db.Issues.AddRange(GetSeedingIssues());
			db.Responses.AddRange(GetSeedingResponses());
			db.Comments.AddRange(GetSeedingComments());
			db.SaveChanges();
		}

		public static void ReinitializeDbForTests(DataContext db)
		{
			ClearDbForTests(db);
			InitializeDbForTests(db);
		}

		public static void ClearDbForTests(DataContext db)
		 {
			db.Issues.RemoveRange(db.Issues);
			db.Responses.RemoveRange(db.Responses);
			db.Comments.RemoveRange(db.Comments);
		}

		public static List<Issue> GetSeedingIssues()
		{
			return new List<Issue>()
			{
				new Issue() { IssueDescription = "Customer 1", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, InitiatorId = new Guid().ToString(), InitiatorName = "test.tester1@tester.com", IsDeleted = false, IsResolved = false },
				new Issue() { IssueDescription = "Customer 2", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, InitiatorId = new Guid().ToString(), InitiatorName = "test.tester2@tester.com", IsDeleted = false, IsResolved = false },
				new Issue() { IssueDescription = "Customer 3", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, InitiatorId = new Guid().ToString(), InitiatorName = "test.tester3@tester.com", IsDeleted = false, IsResolved = true }
			};
		}

		public static List<Response> GetSeedingResponses()
		{
			return new List<Response>()
			{
					new Response(){ ResponseDescription = "Response 1", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, IsDeleted = false, IssueId = 3, ResponderId = new Guid().ToString(), ResponderName = "test.tester4@tester.com" }
			};
		}

		public static List<Comment> GetSeedingComments()
		{
			return new List<Comment>()
			{
				new Comment() { CommentDescription = "Comment 1", CommenterId = new Guid().ToString(), IsDeleted = false, CommenterName = "test.tester@tester.com", DateAddedUtc = DateTimeOffset.UtcNow, DateModifiedUtc = DateTimeOffset.UtcNow, ResponseId = 1 }
			};
		}
	}
}
