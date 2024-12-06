using Microsoft.EntityFrameworkCore;
using LOANMANAGEMENTAPI.Models;

namespace LOANMANAGEMENTAPI.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Borrowers> Borrowers { get; set; }
        public DbSet<Interest_Paid> InterestPaid { get; set; }
        public DbSet<Outstanding_Amount> Outstanding { get; set; }

        public DbSet<Loans> Loans { get; set; }

        public DbSet<History> History { get; set; }

    }
}