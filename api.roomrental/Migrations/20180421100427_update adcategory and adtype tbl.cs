using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.roomrental.Migrations
{
    public partial class updateadcategoryandadtypetbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AdCategories_CategoryName",
                table: "AdCategories");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AdTypes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AdCategories");

            migrationBuilder.RenameColumn(
                name: "NormaliseName",
                table: "AdTypes",
                newName: "NormalisedAdType");

            migrationBuilder.RenameColumn(
                name: "NormalisedCategoryName",
                table: "AdCategories",
                newName: "NormalisedAdCategoryName");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "AdCategories",
                newName: "AdCategoryName");

            migrationBuilder.AddColumn<string>(
                name: "AdTypeName",
                table: "AdTypes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_AdTypes_AdTypeId",
                table: "AdTypes",
                column: "AdTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdTypes_AdTypeName",
                table: "AdTypes",
                column: "AdTypeName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdCategories_AdCategoryName",
                table: "AdCategories",
                column: "AdCategoryName",
                unique: true,
                filter: "[AdCategoryName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AdTypes_AdTypeId",
                table: "AdTypes");

            migrationBuilder.DropIndex(
                name: "IX_AdTypes_AdTypeName",
                table: "AdTypes");

            migrationBuilder.DropIndex(
                name: "IX_AdCategories_AdCategoryName",
                table: "AdCategories");

            migrationBuilder.DropColumn(
                name: "AdTypeName",
                table: "AdTypes");

            migrationBuilder.RenameColumn(
                name: "NormalisedAdType",
                table: "AdTypes",
                newName: "NormaliseName");

            migrationBuilder.RenameColumn(
                name: "NormalisedAdCategoryName",
                table: "AdCategories",
                newName: "NormalisedCategoryName");

            migrationBuilder.RenameColumn(
                name: "AdCategoryName",
                table: "AdCategories",
                newName: "CategoryName");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AdTypes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AdCategories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AdCategories_CategoryName",
                table: "AdCategories",
                column: "CategoryName",
                unique: true,
                filter: "[CategoryName] IS NOT NULL");
        }
    }
}
