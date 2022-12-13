using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Depart_name = table.Column<string>(maxLength: 45, nullable: false),
                    Employee_count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spending_Types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Spending_name = table.Column<string>(maxLength: 45, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spending_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 45, nullable: false),
                    SurName = table.Column<string>(maxLength: 45, nullable: false),
                    LastName = table.Column<string>(maxLength: 45, nullable: false),
                    Id_Dep = table.Column<int>(nullable: false),
                    Salary = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_Id_Dep",
                        column: x => x.Id_Dep,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "limit_Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Dep = table.Column<int>(nullable: false),
                    Id_Spend_type = table.Column<int>(nullable: false),
                    Limit_value_in_order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_limit_Values", x => x.Id);
                    table.ForeignKey(
                        name: "FK_limit_Values_Departments_Id_Dep",
                        column: x => x.Id_Dep,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_limit_Values_Spending_Types_Id_Spend_type",
                        column: x => x.Id_Spend_type,
                        principalTable: "Spending_Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spendings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Dep = table.Column<int>(nullable: false),
                    Id_Spend_type = table.Column<int>(nullable: false),
                    DateT = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    Summa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spendings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spendings_Departments_Id_Dep",
                        column: x => x.Id_Dep,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spendings_Spending_Types_Id_Spend_type",
                        column: x => x.Id_Spend_type,
                        principalTable: "Spending_Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Id_Dep",
                table: "Employees",
                column: "Id_Dep");

            migrationBuilder.CreateIndex(
                name: "IX_limit_Values_Id_Dep",
                table: "limit_Values",
                column: "Id_Dep");

            migrationBuilder.CreateIndex(
                name: "IX_limit_Values_Id_Spend_type",
                table: "limit_Values",
                column: "Id_Spend_type");

            migrationBuilder.CreateIndex(
                name: "IX_Spendings_Id_Dep",
                table: "Spendings",
                column: "Id_Dep");

            migrationBuilder.CreateIndex(
                name: "IX_Spendings_Id_Spend_type",
                table: "Spendings",
                column: "Id_Spend_type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "limit_Values");

            migrationBuilder.DropTable(
                name: "Spendings");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Spending_Types");
        }
    }
}
