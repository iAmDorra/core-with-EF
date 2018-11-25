using Microsoft.EntityFrameworkCore;

namespace StudentProject
{
    public static class StudentsContextFactory
    {
        public static StudentsContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudentsContext>();
            optionsBuilder.UseSqlite(connectionString);

            // Ensure that the SQLite database and sechema is created!
            var context = new StudentsContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            return context;
        }
    }
}
