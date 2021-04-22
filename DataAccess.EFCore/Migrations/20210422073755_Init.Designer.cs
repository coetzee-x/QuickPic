﻿// <auto-generated />
using DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.EFCore.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210422073755_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Objective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Expectation")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Objectives");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Expectation = 8,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Expectation = 8,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 3,
                            Expectation = 5,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 4,
                            Expectation = 5,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 5,
                            Expectation = 2,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 6,
                            Expectation = 5,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 7,
                            Expectation = 30,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 8,
                            Expectation = 22,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 9,
                            Expectation = 5,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 10,
                            Expectation = 10,
                            QuestionId = 10
                        });
                });

            modelBuilder.Entity("Domain.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Text = "Internal Meetings"
                        },
                        new
                        {
                            Id = 2,
                            Text = "Client Meetings"
                        },
                        new
                        {
                            Id = 3,
                            Text = "Emails & Phone / Skype calls"
                        },
                        new
                        {
                            Id = 4,
                            Text = "Research"
                        },
                        new
                        {
                            Id = 5,
                            Text = "DB Design"
                        },
                        new
                        {
                            Id = 6,
                            Text = "Architecture Design and Planning"
                        },
                        new
                        {
                            Id = 7,
                            Text = "Back-end Development"
                        },
                        new
                        {
                            Id = 8,
                            Text = "Front-end Development"
                        },
                        new
                        {
                            Id = 9,
                            Text = "Integration"
                        },
                        new
                        {
                            Id = 10,
                            Text = "Testing"
                        });
                });

            modelBuilder.Entity("Domain.Models.Respondent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Respondents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Firstname = "John",
                            Lastname = "Smith",
                            Password = "password",
                            Username = "u1"
                        },
                        new
                        {
                            Id = 2,
                            Firstname = "Susan",
                            Lastname = "Birnam",
                            Password = "password",
                            Username = "u2"
                        },
                        new
                        {
                            Id = 3,
                            Firstname = "Carter",
                            Lastname = "Flamings",
                            Password = "password",
                            Username = "u3"
                        },
                        new
                        {
                            Id = 4,
                            Firstname = "Elrond",
                            Lastname = "Raven",
                            Password = "password",
                            Username = "u4"
                        },
                        new
                        {
                            Id = 5,
                            Firstname = "Frodo",
                            Lastname = "Smitherns",
                            Password = "password",
                            Username = "u5"
                        });
                });

            modelBuilder.Entity("Domain.Models.RespondentResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Answer")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("RespondentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("RespondentId");

                    b.ToTable("RespondentResults");
                });

            modelBuilder.Entity("Domain.Models.Objective", b =>
                {
                    b.HasOne("Domain.Models.Question", "Question")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Domain.Models.RespondentResult", b =>
                {
                    b.HasOne("Domain.Models.Question", "Question")
                        .WithMany("RespondentResults")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Respondent", "Respondent")
                        .WithMany("RespondentResults")
                        .HasForeignKey("RespondentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Respondent");
                });

            modelBuilder.Entity("Domain.Models.Question", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("RespondentResults");
                });

            modelBuilder.Entity("Domain.Models.Respondent", b =>
                {
                    b.Navigation("RespondentResults");
                });
#pragma warning restore 612, 618
        }
    }
}