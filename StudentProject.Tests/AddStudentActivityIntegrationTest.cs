using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace StudentProject.Tests
{
    [TestClass]
    public class AddStudentActivityIntegrationTest
    {
        [TestMethod]
        public void Should_add_new_student()
        {
            var activity = new AddStudentActivity();
            activity.Execute();
            var studentFinder = new StudentFinder();
            var student = studentFinder.Find();
            Check.That(student).IsNotNull();
        }
    }
}
