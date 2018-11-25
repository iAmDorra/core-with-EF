using Microsoft.EntityFrameworkCore;

namespace StudentProject
{
    public class StudentsContext : DbContext
    {
        public StudentsContext(DbContextOptions<StudentsContext> options)
            : base(options)
        { }

        public DbSet<Student> Students { get; set; }
    }
}
