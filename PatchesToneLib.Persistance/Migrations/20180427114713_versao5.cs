using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PatchesToneLib.Persistance.Migrations
{
    public partial class versao5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "Created",
            //    table: "Patches");

            //migrationBuilder.DropColumn(
            //    name: "Updated",
            //    table: "Patches");

            migrationBuilder.AddColumn<byte[]>(
                name: "File",
                table: "Patches",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "File",
                table: "Patches");

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "Created",
            //    table: "Patches",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "Updated",
            //    table: "Patches",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
