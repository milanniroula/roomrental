using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.roomrental.Migrations
{
    public partial class renamecategorytbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdPost_Categories_CategoryId",
                table: "AdPost");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.CreateTable(
                name: "AdCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false),
                    NormaliseCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdCategories", x => x.CategoryId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AdPost_AdCategories_CategoryId",
                table: "AdPost",
                column: "CategoryId",
                principalTable: "AdCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdPost_AdCategories_CategoryId",
                table: "AdPost");

            migrationBuilder.DropTable(
                name: "AdCategories");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false),
                    NormaliseCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AdPost_Categories_CategoryId",
                table: "AdPost",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
