using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.roomrental.Migrations
{
    public partial class renamecolinAdTypestbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NormalisedAdType",
                table: "AdTypes",
                newName: "NormalisedAdTypeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NormalisedAdTypeName",
                table: "AdTypes",
                newName: "NormalisedAdType");
        }
    }
}
