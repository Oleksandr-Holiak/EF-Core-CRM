using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_CRM.Migrations
{
    /// <inheritdoc />
    public partial class TablesnamechangedandrenamedpropertyinCustomertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customer",
                newName: "FullName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Customer",
                newName: "Name");
        }
    }
}
