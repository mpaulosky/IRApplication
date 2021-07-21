﻿// <auto-generated />
using System;
using IR.Shared.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IR.Shared.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("CommentDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CommenterId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CommenterName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset>("DateAddedUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DateModifiedUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("ResponseId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ResponseId");

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
                            DateAddedUtc = new DateTimeOffset(new DateTime(2021, 7, 21, 6, 2, 26, 553, DateTimeKind.Unspecified).AddTicks(1341), new TimeSpan(0, 0, 0, 0, 0)),
                            DateModifiedUtc = new DateTimeOffset(new DateTime(2021, 7, 21, 6, 2, 26, 553, DateTimeKind.Unspecified).AddTicks(1362), new TimeSpan(0, 0, 0, 0, 0)),
                            DateResolvedUtc = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            InitiatorId = "27b5baf6-190d-4ec3-92de-c15ff05c1043",
                            InitiatorName = "Matthew",
                            IsDeleted = false,
                            IsResolved = false,
                            IssueDescription = "Electronic Items"
                        },
                        new
                        {
                            Id = 2L,
                            DateAddedUtc = new DateTimeOffset(new DateTime(2021, 7, 21, 6, 2, 26, 553, DateTimeKind.Unspecified).AddTicks(2340), new TimeSpan(0, 0, 0, 0, 0)),
                            DateModifiedUtc = new DateTimeOffset(new DateTime(2021, 7, 21, 6, 2, 26, 553, DateTimeKind.Unspecified).AddTicks(2343), new TimeSpan(0, 0, 0, 0, 0)),
                            DateResolvedUtc = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            InitiatorId = "4516c926-9928-42c5-91b7-a6dbc78d318d",
                            InitiatorName = "Matthew",
                            IsDeleted = false,
                            IsResolved = false,
                            IssueDescription = "Dresses"
                        },
                        new
                        {
                            Id = 3L,
                            DateAddedUtc = new DateTimeOffset(new DateTime(2021, 7, 21, 6, 2, 26, 553, DateTimeKind.Unspecified).AddTicks(2353), new TimeSpan(0, 0, 0, 0, 0)),
                            DateModifiedUtc = new DateTimeOffset(new DateTime(2021, 7, 21, 6, 2, 26, 553, DateTimeKind.Unspecified).AddTicks(2354), new TimeSpan(0, 0, 0, 0, 0)),
                            DateResolvedUtc = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            InitiatorId = "9a745618-d06c-4415-9430-3f9f4425a70e",
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
                        .HasForeignKey("ResponseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
