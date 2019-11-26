using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MODTrainingService.Migrations
{
    public partial class trainMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentors",
                columns: table => new
                {
                    Mentor_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mentor_FirstName = table.Column<string>(nullable: false),
                    Mentor_LastName = table.Column<string>(nullable: true),
                    Mentor_University = table.Column<string>(nullable: true),
                    Mentor_MobileNo = table.Column<long>(nullable: false),
                    Mentor_LinkedInUrl = table.Column<string>(nullable: true),
                    Mentor_YearsOfExperience = table.Column<int>(nullable: false),
                    Mentor_FromTimeSlot = table.Column<string>(nullable: true),
                    Mentor_ToTimeSlot = table.Column<string>(nullable: true),
                    Mentor_Avaliability = table.Column<bool>(nullable: false),
                    Mentor_Active = table.Column<bool>(nullable: true),
                    Mentor_PrimarySkill = table.Column<string>(nullable: true),
                    Mentor_EmailId = table.Column<string>(nullable: false),
                    Mentor_Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentors", x => x.Mentor_Id);
                });

            migrationBuilder.CreateTable(
                name: "Technologys",
                columns: table => new
                {
                    Skill_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Skill_Name = table.Column<string>(nullable: true),
                    Skill_TOC = table.Column<string>(nullable: true),
                    Skill_Fees = table.Column<double>(nullable: true),
                    Skill_Duration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologys", x => x.Skill_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Name = table.Column<string>(nullable: false),
                    User_Email = table.Column<string>(nullable: false),
                    User_Password = table.Column<string>(nullable: true),
                    User_MobileNo = table.Column<long>(nullable: false),
                    User_Active = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Payment_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(nullable: false),
                    Mentor_Id = table.Column<int>(nullable: false),
                    Payment_Amount = table.Column<double>(nullable: false),
                    Skill_Name = table.Column<string>(nullable: true),
                    Mentor_Amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Payment_Id);
                    table.ForeignKey(
                        name: "FK_Payments_Mentors_Mentor_Id",
                        column: x => x.Mentor_Id,
                        principalTable: "Mentors",
                        principalColumn: "Mentor_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Training_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(nullable: false),
                    Mentor_Id = table.Column<int>(nullable: false),
                    Skill_Id = table.Column<int>(nullable: false),
                    Training_StartDate = table.Column<DateTime>(nullable: false),
                    Training_EndDate = table.Column<DateTime>(nullable: false),
                    Training_TimeSlot = table.Column<string>(nullable: false),
                    Training_Status = table.Column<string>(nullable: false),
                    Training_Progress = table.Column<string>(nullable: true),
                    Training_Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Training_Id);
                    table.ForeignKey(
                        name: "FK_Trainings_Mentors_Mentor_Id",
                        column: x => x.Mentor_Id,
                        principalTable: "Mentors",
                        principalColumn: "Mentor_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trainings_Technologys_Skill_Id",
                        column: x => x.Skill_Id,
                        principalTable: "Technologys",
                        principalColumn: "Skill_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trainings_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Mentor_Id",
                table: "Payments",
                column: "Mentor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_User_Id",
                table: "Payments",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_Mentor_Id",
                table: "Trainings",
                column: "Mentor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_Skill_Id",
                table: "Trainings",
                column: "Skill_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_User_Id",
                table: "Trainings",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Mentors");

            migrationBuilder.DropTable(
                name: "Technologys");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
