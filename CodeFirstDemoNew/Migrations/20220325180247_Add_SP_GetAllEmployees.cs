using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDemoNew.Migrations
{
    public partial class Add_SP_GetAllEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE OR ALTER PROCEDURE GetAllEmployees
                As
                BEGIN
                SELECT
                  e.Id,
                  e.EmpName,
                  e.MobileNumber,
                  s.Amount
                FROM
                  EmployeeMaster AS e
                  JOIN SalaryMaster AS s ON e.SalaryId = s.Id
                END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
