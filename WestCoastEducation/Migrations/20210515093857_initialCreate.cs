using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WestCoastEducation.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    CourseInformation = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Subject = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCanceled = table.Column<bool>(type: "bit", nullable: false),
                    AverageAttendance = table.Column<double>(type: "float", nullable: false),
                    AverageGrade = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    PersonalNumber = table.Column<string>(type: "VARCHAR(12)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(12)", nullable: true),
                    StreetNumber = table.Column<short>(type: "SMALLINT", nullable: false),
                    City = table.Column<string>(type: "VARCHAR(12)", nullable: true),
                    PostalCode = table.Column<string>(type: "VARCHAR(12)", nullable: true),
                    Country = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    IsEnrolledInSchool = table.Column<bool>(type: "bit", nullable: false),
                    AverageAttendance = table.Column<short>(type: "SMALLINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Course_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Student_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                column: "StudentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
