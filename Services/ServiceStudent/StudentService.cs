
namespace studentInfoHubAPI.Services.ServiceStudent;

public class StudentService : IStudentService
{

    public List<Student> StudentsList = new();
    public List<Student> AddStudent(string studentName, string studentGrade)
    {
        Student newStudent = new();
        newStudent.StudentGrade = studentGrade;
        newStudent.StudentName = studentName;
        StudentsList.Add(newStudent);
        return StudentsList;
    }

    public List<Student> DeleteStudent(string studentName)
    {
        return StudentsList;
    }

    public List<Student> GetAllStudents()
    {
        return StudentsList;
    }

    public Student SearchStudent(string studentName)
    {
        throw new NotImplementedException();
    }

    public List<Student> UpdateStudent(string studentName, string newName, string newGrade)
    {
        return StudentsList;
    }
}
