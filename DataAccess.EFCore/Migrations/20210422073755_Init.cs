﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.EFCore.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Respondents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respondents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Objectives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Expectation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objectives_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RespondentResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    RespondentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespondentResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RespondentResults_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RespondentResults_Respondents_RespondentId",
                        column: x => x.RespondentId,
                        principalTable: "Respondents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "Internal Meetings" },
                    { 2, "Client Meetings" },
                    { 3, "Emails & Phone / Skype calls" },
                    { 4, "Research" },
                    { 5, "DB Design" },
                    { 6, "Architecture Design and Planning" },
                    { 7, "Back-end Development" },
                    { 8, "Front-end Development" },
                    { 9, "Integration" },
                    { 10, "Testing" }
                });

            migrationBuilder.InsertData(
                table: "Respondents",
                columns: new[] { "Id", "Firstname", "Lastname", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "John", "Smith", "password", "u1" },
                    { 2, "Susan", "Birnam", "password", "u2" },
                    { 3, "Carter", "Flamings", "password", "u3" },
                    { 4, "Elrond", "Raven", "password", "u4" },
                    { 5, "Frodo", "Smitherns", "password", "u5" }
                });

            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "Id", "Expectation", "QuestionId" },
                values: new object[,]
                {
                    { 1, 8, 1 },
                    { 2, 8, 2 },
                    { 3, 5, 3 },
                    { 4, 5, 4 },
                    { 5, 2, 5 },
                    { 6, 5, 6 },
                    { 7, 30, 7 },
                    { 8, 22, 8 },
                    { 9, 5, 9 },
                    { 10, 10, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_QuestionId",
                table: "Objectives",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_RespondentResults_QuestionId",
                table: "RespondentResults",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_RespondentResults_RespondentId",
                table: "RespondentResults",
                column: "RespondentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Objectives");

            migrationBuilder.DropTable(
                name: "RespondentResults");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Respondents");
        }
    }
}
