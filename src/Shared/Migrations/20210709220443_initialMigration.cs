using Microsoft.EntityFrameworkCore.Migrations;

using System;

namespace IR.Shared.Migrations
{
	public partial class initialMigration : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
					name: "Responses",
					columns: table => new
					{
						Id = table.Column<long>(type: "bigint", nullable: false)
									.Annotation("SqlServer:Identity", "1, 1"),
						ResponseDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
						ResponderId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
						ResponderName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
						IssueId = table.Column<int>(type: "int", nullable: false),
						DateAddedUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
						DateModifiedUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
						IsDeleted = table.Column<bool>(type: "bit", nullable: false)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_Responses", x => x.Id);
					});

			migrationBuilder.CreateTable(
					name: "Comments",
					columns: table => new
					{
						Id = table.Column<long>(type: "bigint", nullable: false)
									.Annotation("SqlServer:Identity", "1, 1"),
						CommentText = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
						CommentorId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
						CommentorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
						ResponseId = table.Column<int>(type: "int", nullable: false),
						ResponseId1 = table.Column<long>(type: "bigint", nullable: true),
						DateAddedUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
						DateModifiedUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
						IsDeleted = table.Column<bool>(type: "bit", nullable: false)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_Comments", x => x.Id);
						table.ForeignKey(
											name: "FK_Comments_Responses_ResponseId1",
											column: x => x.ResponseId1,
											principalTable: "Responses",
											principalColumn: "Id",
											onDelete: ReferentialAction.Restrict);
					});

			migrationBuilder.CreateTable(
					name: "Issues",
					columns: table => new
					{
						Id = table.Column<long>(type: "bigint", nullable: false)
									.Annotation("SqlServer:Identity", "1, 1"),
						IssueDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
						InitiatorId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
						InitiatorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
						DateResolvedUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
						IsResolved = table.Column<bool>(type: "bit", nullable: false),
						ResponseId = table.Column<long>(type: "bigint", nullable: true),
						DateAddedUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
						DateModifiedUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
						IsDeleted = table.Column<bool>(type: "bit", nullable: false)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_Issues", x => x.Id);
						table.ForeignKey(
											name: "FK_Issues_Responses_ResponseId",
											column: x => x.ResponseId,
											principalTable: "Responses",
											principalColumn: "Id",
											onDelete: ReferentialAction.Restrict);
					});

			migrationBuilder.InsertData(
					table: "Issues",
					columns: new[] { "Id", "DateAddedUtc", "DateModifiedUtc", "DateResolvedUtc", "InitiatorId", "InitiatorName", "IsDeleted", "IsResolved", "IssueDescription", "ResponseId" },
					values: new object[] { 1L, new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(7843), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(7863), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "a7884ff4-a88b-4b3b-b924-765e1b8e83a1", "Matthew", false, false, "Electronic Items", null });

			migrationBuilder.InsertData(
					table: "Issues",
					columns: new[] { "Id", "DateAddedUtc", "DateModifiedUtc", "DateResolvedUtc", "InitiatorId", "InitiatorName", "IsDeleted", "IsResolved", "IssueDescription", "ResponseId" },
					values: new object[] { 2L, new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(8854), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(8857), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "05ec0bb4-b590-4ac0-9276-9e4759411cb1", "Matthew", false, false, "Dresses", null });

			migrationBuilder.InsertData(
					table: "Issues",
					columns: new[] { "Id", "DateAddedUtc", "DateModifiedUtc", "DateResolvedUtc", "InitiatorId", "InitiatorName", "IsDeleted", "IsResolved", "IssueDescription", "ResponseId" },
					values: new object[] { 3L, new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(8868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(8869), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "9f9a4952-2a57-4e76-b413-8dfa308cefe6", "Matthew", false, false, "Grocery Items", null });

			migrationBuilder.CreateIndex(
					name: "IX_Comments_ResponseId1",
					table: "Comments",
					column: "ResponseId1");

			migrationBuilder.CreateIndex(
					name: "IX_Issues_ResponseId",
					table: "Issues",
					column: "ResponseId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
					name: "Comments");

			migrationBuilder.DropTable(
					name: "Issues");

			migrationBuilder.DropTable(
					name: "Responses");
		}
	}
}
