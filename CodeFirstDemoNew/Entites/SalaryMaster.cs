using CodeFirstDemo.Extentions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Entites
{
    public record SalaryMaster
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public SalaryType SalaryType { get; set; }

        public ICollection<EmployeeMaster> EmployeeMasters { get; set; }
    }
}
