using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.roomrental.Migrations
{
    public partial class renameAttributeTypetbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAttributes_AttributeTypes_AttributeTypeTypeId",
                table: "CategoryAttributes");

            migrationBuilder.DropTable(
                name: "AttributeTypes");

            migrationBuilder.CreateTable(
                name: "AttributeValueTypes",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false),
                    TypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeValueTypes", x => x.TypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValueTypes_TypeId",
                table: "AttributeValueTypes",
                column: "TypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValueTypes_TypeName",
                table: "AttributeValueTypes",
                column: "TypeName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAttributes_AttributeValueTypes_AttributeTypeTypeId",
                table: "CategoryAttributes",
                column: "AttributeTypeTypeId",
                principalTable: "AttributeValueTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAttributes_AttributeValueTypes_AttributeTypeTypeId",
                table: "CategoryAttributes");

            migrationBuilder.DropTable(
                name: "AttributeValueTypes");

            migrationBuilder.CreateTable(
                name: "AttributeTypes",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false),
                    TypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeTypes", x => x.TypeId);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAttributes_AttributeTypes_AttributeTypeTypeId",
                table: "CategoryAttributes",
                column: "AttributeTypeTypeId",
                principalTable: "AttributeTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
