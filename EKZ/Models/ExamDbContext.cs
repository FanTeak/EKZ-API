using Microsoft.EntityFrameworkCore;

namespace EKZ.Models
{
    public class ExamDbContext: DbContext
    {
        public ExamDbContext(DbContextOptions<ExamDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups{ get; set; }
    }
}