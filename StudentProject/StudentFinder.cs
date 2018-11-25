using System.Linq;

namespace StudentProject
{
    public class StudentFinder
    {
        public Student Find()
        {
            string connectionString = ConfigurationSettings.GetConnectionString();
            using (var context = StudentsContextFactory.Create(connectionString))
            {
                var students = context.Students.Where(s => s.Name == "Carlos");
                return students.FirstOrDefault();
            }
        }
    }
}
