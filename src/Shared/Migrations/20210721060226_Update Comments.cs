using Microsoft.EntityFrameworkCore.Migrations;

using System;
using System.Diagnostics.CodeAnalysis;

namespace IR.Shared.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class UpdateComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Responses_ResponseId1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ResponseId1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ResponseId1",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CommentorName",
                table: "Comments",
                newName: "CommenterName");

            migrationBuilder.RenameColumn(
                name: "CommentorId",
                table: "Comments",
                newName: "CommenterId");

            migrationBuilder.RenameColumn(
                name: "CommentText",
                table: "Comments",
                newName: "CommentDescription");

            migrationBuilder.AlterColumn<long>(
                name: "ResponseId",
                table: "Comments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateAddedUtc", "DateModifiedUtc", "InitiatorId" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 7, 21, 6, 2, 26, 553, DateTimeKind.Unspecified).AddTicks(1341), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 7, 21, 6, 2, 26, 553, DateTimeKind.Unspecified).AddTicks(1362), new TimeSpan(0, 0, 0, 0, 0)), "27b5baf6-190d-4ec3-92de-c15ff05c1043" });

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateAddedUtc", "DateModifiedUtc", "InitiatorId" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 7, 21, 6, 2, 26, 553, DateTimeKind.Unspecified).AddTicks(2340), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 7, 21, 6, 2, 26, 553, DateTimeKind.Unspecified).AddTicks(2343), new TimeSpan(0, 0, 0, 0, 0)), "4516c926-9928-42c5-91b7-a6dbc78d318d" });

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateAddedUtc", "DateModifiedUtc", "InitiatorId" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 7, 21, 6, 2, 26, 553, DateTimeKind.Unspecified).AddTicks(2353), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 7, 21, 6, 2, 26, 553, DateTimeKind.Unspecified).AddTicks(2354), new TimeSpan(0, 0, 0, 0, 0)), "9a745618-d06c-4415-9430-3f9f4425a70e" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ResponseId",
                table: "Comments",
                column: "ResponseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Responses_ResponseId",
                table: "Comments",
                column: "ResponseId",
                principalTable: "Responses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Responses_ResponseId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ResponseId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CommenterName",
                table: "Comments",
                newName: "CommentorName");

            migrationBuilder.RenameColumn(
                name: "CommenterId",
                table: "Comments",
                newName: "CommentorId");

            migrationBuilder.RenameColumn(
                name: "CommentDescription",
                table: "Comments",
                newName: "CommentText");

            migrationBuilder.AlterColumn<int>(
                name: "ResponseId",
                table: "Comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "ResponseId1",
                table: "Comments",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateAddedUtc", "DateModifiedUtc", "InitiatorId" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(7843), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(7863), new TimeSpan(0, 0, 0, 0, 0)), "a7884ff4-a88b-4b3b-b924-765e1b8e83a1" });

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateAddedUtc", "DateModifiedUtc", "InitiatorId" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(8854), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(8857), new TimeSpan(0, 0, 0, 0, 0)), "05ec0bb4-b590-4ac0-9276-9e4759411cb1" });

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateAddedUtc", "DateModifiedUtc", "InitiatorId" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(8868), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(8869), new TimeSpan(0, 0, 0, 0, 0)), "9f9a4952-2a57-4e76-b413-8dfa308cefe6" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ResponseId1",
                table: "Comments",
                column: "ResponseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Responses_ResponseId1",
                table: "Comments",
                column: "ResponseId1",
                principalTable: "Responses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}