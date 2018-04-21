using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.roomrental.Migrations
{
    public partial class categorytblpropertyupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryAttributeId",
                table: "AdCategories");

            migrationBuilder.RenameColumn(
                name: "NormaliseCategoryName",
                table: "AdCategories",
                newName: "NormalisedCategoryName");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "AdCategories",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdCategories_CategoryId",
                table: "AdCategories",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdCategories_CategoryName",
                table: "AdCategories",
                column: "CategoryName",
                unique: true,
                filter: "[CategoryName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AdCategories_CategoryId",
                table: "AdCategories");

            migrationBuilder.DropIndex(
                name: "IX_AdCategories_CategoryName",
                table: "AdCategories");

            migrationBuilder.RenameColumn(
                name: "NormalisedCategoryName",
                table: "AdCategories",
                newName: "NormaliseCategoryName");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "AdCategories",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryAttributeId",
                table: "AdCategories",
                nullable: false,
                defaultValue: 0);
        }
    }
}
