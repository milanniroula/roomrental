using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.roomrental.Migrations
{
    public partial class renametypeidattributetypetbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttributeTypeId",
                table: "CategoryAttributes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AttrubuteTypeId",
                table: "CategoryAttributes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AttributeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttributeTypeId = table.Column<int>(nullable: false),
                    AttributeTypeName = table.Column<string>(nullable: true),
                    NormalisedTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAttributes_AttributeTypeId",
                table: "CategoryAttributes",
                column: "AttributeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAttributes_AttributeTypes_AttributeTypeId",
                table: "CategoryAttributes",
                column: "AttributeTypeId",
                principalTable: "AttributeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAttributes_AttributeTypes_AttributeTypeId",
                table: "CategoryAttributes");

            migrationBuilder.DropTable(
                name: "AttributeTypes");

            migrationBuilder.DropIndex(
                name: "IX_CategoryAttributes_AttributeTypeId",
                table: "CategoryAttributes");

            migrationBuilder.DropColumn(
                name: "AttributeTypeId",
                table: "CategoryAttributes");

            migrationBuilder.DropColumn(
                name: "AttrubuteTypeId",
                table: "CategoryAttributes");
        }
    }
}
