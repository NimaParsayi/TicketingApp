using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ticketing.Infrastructure.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddFormSchemaTypesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "FormSchemasFields",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "FormSchemasFields",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "FormSchemas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FormSchemaTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormSchemaTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormSchemas_TypeId",
                table: "FormSchemas",
                column: "TypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FormSchemas_FormSchemaTypes_TypeId",
                table: "FormSchemas",
                column: "TypeId",
                principalTable: "FormSchemaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormSchemas_FormSchemaTypes_TypeId",
                table: "FormSchemas");

            migrationBuilder.DropTable(
                name: "FormSchemaTypes");

            migrationBuilder.DropIndex(
                name: "IX_FormSchemas_TypeId",
                table: "FormSchemas");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "FormSchemas");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "FormSchemasFields",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "FormSchemasFields",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);
        }
    }
}
