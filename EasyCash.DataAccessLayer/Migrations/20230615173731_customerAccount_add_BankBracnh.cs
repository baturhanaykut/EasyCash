using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCash.DataAccessLayer.Migrations
{
    public partial class customerAccount_add_BankBracnh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BankBranch",
                table: "CustomerAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankBranch",
                table: "CustomerAccounts");
        }
    }
}
