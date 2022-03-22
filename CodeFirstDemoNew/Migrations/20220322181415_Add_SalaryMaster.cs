using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDemoNew.Migrations
{
    public partial class Add_SalaryMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "EmployeeMaster");

            migrationBuilder.AddColumn<int>(
                name: "SalaryId",
                table: "EmployeeMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SalaryMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryMaster", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMaster_SalaryId",
                table: "EmployeeMaster",
                column: "SalaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMaster_SalaryMaster_SalaryId",
                table: "EmployeeMaster",
                column: "SalaryId",
                principalTable: "SalaryMaster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMaster_SalaryMaster_SalaryId",
                table: "EmployeeMaster");

            migrationBuilder.DropTable(
                name: "SalaryMaster");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeMaster_SalaryId",
                table: "EmployeeMaster");

            migrationBuilder.DropColumn(
                name: "SalaryId",
                table: "EmployeeMaster");

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "EmployeeMaster",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
