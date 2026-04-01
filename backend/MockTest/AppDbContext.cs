using Microsoft.EntityFrameworkCore;
using ExamApi.Models;

namespace MockTest
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Result> Results { get; set; }
    }
}