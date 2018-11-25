namespace StudentProject
{
    public class AddStudentActivity
    {
        public void Execute()
        {
            string connectionString = ConfigurationSettings.GetConnectionString();

            // Create a Student instance
            var user = new Student() { Name = "Carlos", LastName = "Mendible" };

            // Add and Save the student in the database
            using (var context = StudentsContextFactory.Create(connectionString))
            {
                context.Add(user);
                context.SaveChanges();
            }
        }
    }
}
