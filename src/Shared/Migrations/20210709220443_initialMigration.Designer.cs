﻿// <auto-generated />
using System;

using IR.Shared.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IR.Shared.Migrations
{
	[DbContext(typeof(DataContext))]
    [Migration("20210709220443_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IR.Shared.Models.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CommentorId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CommentorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset>("DateAddedUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DateModifiedUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ResponseId")
                        .HasColumnType("int");

                    b.Property<long?>("ResponseId1")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ResponseId1");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("IR.Shared.Models.Issue", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DateAddedUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DateModifiedUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DateResolvedUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("InitiatorId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("InitiatorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsResolved")
                        .HasColumnType("bit");

                    b.Property<string>("IssueDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<long?>("ResponseId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ResponseId");

                    b.ToTable("Issues");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateAddedUtc = new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(7843), new TimeSpan(0, 0, 0, 0, 0)),
                            DateModifiedUtc = new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(7863), new TimeSpan(0, 0, 0, 0, 0)),
                            DateResolvedUtc = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            InitiatorId = "a7884ff4-a88b-4b3b-b924-765e1b8e83a1",
                            InitiatorName = "Matthew",
                            IsDeleted = false,
                            IsResolved = false,
                            IssueDescription = "Electronic Items"
                        },
                        new
                        {
                            Id = 2L,
                            DateAddedUtc = new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(8854), new TimeSpan(0, 0, 0, 0, 0)),
                            DateModifiedUtc = new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(8857), new TimeSpan(0, 0, 0, 0, 0)),
                            DateResolvedUtc = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            InitiatorId = "05ec0bb4-b590-4ac0-9276-9e4759411cb1",
                            InitiatorName = "Matthew",
                            IsDeleted = false,
                            IsResolved = false,
                            IssueDescription = "Dresses"
                        },
                        new
                        {
                            Id = 3L,
                            DateAddedUtc = new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(8868), new TimeSpan(0, 0, 0, 0, 0)),
                            DateModifiedUtc = new DateTimeOffset(new DateTime(2021, 7, 9, 22, 4, 42, 980, DateTimeKind.Unspecified).AddTicks(8869), new TimeSpan(0, 0, 0, 0, 0)),
                            DateResolvedUtc = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            InitiatorId = "9f9a4952-2a57-4e76-b413-8dfa308cefe6",
                            InitiatorName = "Matthew",
                            IsDeleted = false,
                            IsResolved = false,
                            IssueDescription = "Grocery Items"
                        });
                });

            modelBuilder.Entity("IR.Shared.Models.Response", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DateAddedUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DateModifiedUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("IssueId")
                        .HasColumnType("int");

                    b.Property<string>("ResponderId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ResponderName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ResponseDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("IR.Shared.Models.Comment", b =>
                {
                    b.HasOne("IR.Shared.Models.Response", null)
                        .WithMany("Comments")
                        .HasForeignKey("ResponseId1");
                });

            modelBuilder.Entity("IR.Shared.Models.Issue", b =>
                {
                    b.HasOne("IR.Shared.Models.Response", "Response")
                        .WithMany()
                        .HasForeignKey("ResponseId");

                    b.Navigation("Response");
                });

            modelBuilder.Entity("IR.Shared.Models.Response", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
