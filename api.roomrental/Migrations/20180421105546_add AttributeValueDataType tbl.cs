using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.roomrental.Migrations
{
    public partial class addAttributeValueDataTypetbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttributeValueDataTypes",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false),
                    TypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeValueDataTypes", x => x.TypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValueDataTypes_TypeId",
                table: "AttributeValueDataTypes",
                column: "TypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValueDataTypes_TypeName",
                table: "AttributeValueDataTypes",
                column: "TypeName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttributeValueDataTypes");
        }
    }
}
