using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Models
{
    public class InsuranceContext : DbContext
    {
        public DbSet<Insuree> Insurees { get; set; }

        public InsuranceContext(DbContextOptions<InsuranceContext> options) : base(options) { }
    }
}