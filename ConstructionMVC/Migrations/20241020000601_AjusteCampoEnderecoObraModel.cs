using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConstructionMVC.Migrations
{
    /// <inheritdoc />
    public partial class AjusteCampoEnderecoObraModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Obras",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Obras");
        }
    }
}
