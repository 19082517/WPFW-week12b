using Microsoft.EntityFrameworkCore;
using WPFW_week12b.Models;

namespace WPFW_week12b.Data
{
    public class MijnContext : DbContext
    {
        public MijnContext(DbContextOptions options) : base(options) {}
        public DbSet<Student> students { get; set; }
    }
}