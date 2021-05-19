using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WestCoastEducation.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Courses");

            migrationBuilder.EnsureSchema(
                name: "Students");

            migrationBuilder.CreateTable(
                name: "Course",
                schema: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    CourseInformation = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Subject = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    CourseActiveStatus = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                schema: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "VARCHAR(14)", nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(14)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalNumber = table.Column<string>(type: "VARCHAR(12)", maxLength: 12, nullable: false),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    StreetNumber = table.Column<short>(type: "SMALLINT", nullable: false),
                    City = table.Column<string>(type: "VARCHAR(12)", nullable: true),
                    StreetName = table.Column<string>(type: "VARCHAR(12)", nullable: true),
                    PostalCode = table.Column<string>(type: "VARCHAR(12)", nullable: true),
                    Country = table.Column<string>(type: "VARCHAR(60)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course",
                schema: "Courses");

            migrationBuilder.DropTable(
                name: "Student",
                schema: "Students");
        }
    }
}
