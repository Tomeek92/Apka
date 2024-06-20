using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApkaAnalizatorInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZAplikacjiKrzysztofa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    InsertName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DateTimeInsert = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NumberProtocol = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZAplikacjiKrzysztofa", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZAplikacjiKrzysztofa");
        }
    }
}
