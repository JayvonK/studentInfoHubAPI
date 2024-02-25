
namespace studentInfoHubAPI.Services;

    public class Student{
        public string StudentName {get; set;} = "No Student";
        public string StudentGrade {get; set;} = "N/A";
    }
    public interface IStudentService
    {
        List<Student> GetAllStudents();

        Student SearchStudent(string studentName);

        List<Student> UpdateStudent(string studentName, string newName, string newGrade);

        List<Student> DeleteStudent(string studentName);

        List<Student> AddStudent(string studentName, string studentGrade);

    }
