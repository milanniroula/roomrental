using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.roomrental.Migrations
{
    public partial class addattributeoptionidtoattributevalueoptiontbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeValueOption_CategoryAttributes_CategoryAttributeId",
                table: "AttributeValueOption");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttributeValueOption",
                table: "AttributeValueOption");

            migrationBuilder.RenameTable(
                name: "AttributeValueOption",
                newName: "AttributeValueOptions");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeValueOption_CategoryAttributeId",
                table: "AttributeValueOptions",
                newName: "IX_AttributeValueOptions_CategoryAttributeId");

            migrationBuilder.AddColumn<int>(
                name: "AttributeValueOptionId",
                table: "AttributeValueOptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttributeValueOptions",
                table: "AttributeValueOptions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeValueOptions_CategoryAttributes_CategoryAttributeId",
                table: "AttributeValueOptions",
                column: "CategoryAttributeId",
                principalTable: "CategoryAttributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeValueOptions_CategoryAttributes_CategoryAttributeId",
                table: "AttributeValueOptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttributeValueOptions",
                table: "AttributeValueOptions");

            migrationBuilder.DropColumn(
                name: "AttributeValueOptionId",
                table: "AttributeValueOptions");

            migrationBuilder.RenameTable(
                name: "AttributeValueOptions",
                newName: "AttributeValueOption");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeValueOptions_CategoryAttributeId",
                table: "AttributeValueOption",
                newName: "IX_AttributeValueOption_CategoryAttributeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttributeValueOption",
                table: "AttributeValueOption",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeValueOption_CategoryAttributes_CategoryAttributeId",
                table: "AttributeValueOption",
                column: "CategoryAttributeId",
                principalTable: "CategoryAttributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
