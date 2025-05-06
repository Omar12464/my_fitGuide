using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class add1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "userAllergies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "AllergyId",
                table: "userAllergies",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userAllergies_Allergy_AllergyId",
                table: "userAllergies");

            migrationBuilder.DropIndex(
                name: "IX_userAllergies_AllergyId",
                table: "userAllergies");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "userAllergies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AllergyId",
                table: "userAllergies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_userAllergies_UserId_AllergyId",
                table: "userAllergies",
                columns: new[] { "UserId", "AllergyId" },
                unique: true);
        }
    }
}
