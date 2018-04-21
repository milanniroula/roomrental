using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.roomrental.Migrations
{
    public partial class renamecolmns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAttributes_AttributeValueTypes_AttributeTypeTypeId",
                table: "CategoryAttributes");

            migrationBuilder.DropIndex(
                name: "IX_CategoryAttributes_AttributeTypeTypeId",
                table: "CategoryAttributes");

            migrationBuilder.DropColumn(
                name: "AttributeTypeTypeId",
                table: "CategoryAttributes");

            migrationBuilder.RenameColumn(
                name: "AttrubuteTypeId",
                table: "CategoryAttributes",
                newName: "AttributeValueTypeId");

            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "AttributeValueTypes",
                newName: "ValueTypeName");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "AttributeValueTypes",
                newName: "ValueTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeValueTypes_TypeName",
                table: "AttributeValueTypes",
                newName: "IX_AttributeValueTypes_ValueTypeName");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeValueTypes_TypeId",
                table: "AttributeValueTypes",
                newName: "IX_AttributeValueTypes_ValueTypeId");

            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "AttributeValueDataTypes",
                newName: "ValueDataTypeName");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "AttributeValueDataTypes",
                newName: "ValueDataTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeValueDataTypes_TypeName",
                table: "AttributeValueDataTypes",
                newName: "IX_AttributeValueDataTypes_ValueDataTypeName");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeValueDataTypes_TypeId",
                table: "AttributeValueDataTypes",
                newName: "IX_AttributeValueDataTypes_ValueDataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAttributes_AttributeValueTypeId",
                table: "CategoryAttributes",
                column: "AttributeValueTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAttributes_AttributeValueTypes_AttributeValueTypeId",
                table: "CategoryAttributes",
                column: "AttributeValueTypeId",
                principalTable: "AttributeValueTypes",
                principalColumn: "ValueTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAttributes_AttributeValueTypes_AttributeValueTypeId",
                table: "CategoryAttributes");

            migrationBuilder.DropIndex(
                name: "IX_CategoryAttributes_AttributeValueTypeId",
                table: "CategoryAttributes");

            migrationBuilder.RenameColumn(
                name: "AttributeValueTypeId",
                table: "CategoryAttributes",
                newName: "AttrubuteTypeId");

            migrationBuilder.RenameColumn(
                name: "ValueTypeName",
                table: "AttributeValueTypes",
                newName: "TypeName");

            migrationBuilder.RenameColumn(
                name: "ValueTypeId",
                table: "AttributeValueTypes",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeValueTypes_ValueTypeName",
                table: "AttributeValueTypes",
                newName: "IX_AttributeValueTypes_TypeName");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeValueTypes_ValueTypeId",
                table: "AttributeValueTypes",
                newName: "IX_AttributeValueTypes_TypeId");

            migrationBuilder.RenameColumn(
                name: "ValueDataTypeName",
                table: "AttributeValueDataTypes",
                newName: "TypeName");

            migrationBuilder.RenameColumn(
                name: "ValueDataTypeId",
                table: "AttributeValueDataTypes",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeValueDataTypes_ValueDataTypeName",
                table: "AttributeValueDataTypes",
                newName: "IX_AttributeValueDataTypes_TypeName");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeValueDataTypes_ValueDataTypeId",
                table: "AttributeValueDataTypes",
                newName: "IX_AttributeValueDataTypes_TypeId");

            migrationBuilder.AddColumn<int>(
                name: "AttributeTypeTypeId",
                table: "CategoryAttributes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAttributes_AttributeTypeTypeId",
                table: "CategoryAttributes",
                column: "AttributeTypeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAttributes_AttributeValueTypes_AttributeTypeTypeId",
                table: "CategoryAttributes",
                column: "AttributeTypeTypeId",
                principalTable: "AttributeValueTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
