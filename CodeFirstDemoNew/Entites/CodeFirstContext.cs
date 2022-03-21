using CodeFirstDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.Entites
{
    public class CodeFirstContext : DbContext
    {
        public CodeFirstContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<EmployeeMaster> EmployeeMaster { get; set; }
    }
}
