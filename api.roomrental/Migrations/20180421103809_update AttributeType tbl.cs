using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.roomrental.Migrations
{
    public partial class updateAttributeTypetbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NormalisedAdCategoryTypeName",
                table: "AttributeTypes");

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                table: "AttributeTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttributeTypes_TypeId",
                table: "AttributeTypes",
                column: "TypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttributeTypes_TypeName",
                table: "AttributeTypes",
                column: "TypeName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AttributeTypes_TypeId",
                table: "AttributeTypes");

            migrationBuilder.DropIndex(
                name: "IX_AttributeTypes_TypeName",
                table: "AttributeTypes");

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                table: "AttributeTypes",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "NormalisedAdCategoryTypeName",
                table: "AttributeTypes",
                nullable: true);
        }
    }
}
