using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.roomrental.Migrations
{
    public partial class renamecols : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAttributes_AttributeTypes_AttributeTypeId",
                table: "CategoryAttributes");

            migrationBuilder.DropIndex(
                name: "IX_AdCategories_AdCategoryName",
                table: "AdCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttributeTypes",
                table: "AttributeTypes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AttributeTypes");

            migrationBuilder.RenameColumn(
                name: "AttributeTypeId",
                table: "CategoryAttributes",
                newName: "AttributeTypeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAttributes_AttributeTypeId",
                table: "CategoryAttributes",
                newName: "IX_CategoryAttributes_AttributeTypeTypeId");

            migrationBuilder.RenameColumn(
                name: "NormalisedAdTypeName",
                table: "AdTypes",
                newName: "NormalisedTypeName");

            migrationBuilder.RenameColumn(
                name: "AdTypeName",
                table: "AdTypes",
                newName: "TypeName");

            migrationBuilder.RenameIndex(
                name: "IX_AdTypes_AdTypeName",
                table: "AdTypes",
                newName: "IX_AdTypes_TypeName");

            migrationBuilder.RenameColumn(
                name: "NormalisedAdCategoryName",
                table: "AdCategories",
                newName: "NormalisedCategoryName");

            migrationBuilder.RenameColumn(
                name: "AdCategoryName",
                table: "AdCategories",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "NormalisedTypeName",
                table: "AttributeTypes",
                newName: "TypeName");

            migrationBuilder.RenameColumn(
                name: "AttributeTypeName",
                table: "AttributeTypes",
                newName: "NormalisedAdCategoryTypeName");

            migrationBuilder.RenameColumn(
                name: "AttributeTypeId",
                table: "AttributeTypes",
                newName: "TypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttributeTypes",
                table: "AttributeTypes",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AdCategories_CategoryName",
                table: "AdCategories",
                column: "CategoryName",
                unique: true,
                filter: "[CategoryName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAttributes_AttributeTypes_AttributeTypeTypeId",
                table: "CategoryAttributes",
                column: "AttributeTypeTypeId",
                principalTable: "AttributeTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAttributes_AttributeTypes_AttributeTypeTypeId",
                table: "CategoryAttributes");

            migrationBuilder.DropIndex(
                name: "IX_AdCategories_CategoryName",
                table: "AdCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttributeTypes",
                table: "AttributeTypes");

            migrationBuilder.RenameColumn(
                name: "AttributeTypeTypeId",
                table: "CategoryAttributes",
                newName: "AttributeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAttributes_AttributeTypeTypeId",
                table: "CategoryAttributes",
                newName: "IX_CategoryAttributes_AttributeTypeId");

            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "AdTypes",
                newName: "AdTypeName");

            migrationBuilder.RenameColumn(
                name: "NormalisedTypeName",
                table: "AdTypes",
                newName: "NormalisedAdTypeName");

            migrationBuilder.RenameIndex(
                name: "IX_AdTypes_TypeName",
                table: "AdTypes",
                newName: "IX_AdTypes_AdTypeName");

            migrationBuilder.RenameColumn(
                name: "NormalisedCategoryName",
                table: "AdCategories",
                newName: "NormalisedAdCategoryName");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "AdCategories",
                newName: "AdCategoryName");

            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "AttributeTypes",
                newName: "NormalisedTypeName");

            migrationBuilder.RenameColumn(
                name: "NormalisedAdCategoryTypeName",
                table: "AttributeTypes",
                newName: "AttributeTypeName");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "AttributeTypes",
                newName: "AttributeTypeId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AttributeTypes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttributeTypes",
                table: "AttributeTypes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AdCategories_AdCategoryName",
                table: "AdCategories",
                column: "AdCategoryName",
                unique: true,
                filter: "[AdCategoryName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAttributes_AttributeTypes_AttributeTypeId",
                table: "CategoryAttributes",
                column: "AttributeTypeId",
                principalTable: "AttributeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
