using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Models
{
    public record EmployeeMaster
    {
        [Key]
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string MobileNumber { get; set; }
        public decimal Salary { get; set; }
    }
}
