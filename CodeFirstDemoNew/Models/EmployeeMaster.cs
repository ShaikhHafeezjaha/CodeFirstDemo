using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDemo.Models
{
    public record EmployeeMaster
    {
        [Key]
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string MobileNumber { get; set; }

        [ForeignKey("SalaryMaster")]
        public int SalaryId { get; set; }
        public SalaryMaster SalaryMaster { get; set; }
    }
}
