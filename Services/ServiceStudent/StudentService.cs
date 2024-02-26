
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
        for(int i = 0; i < StudentsList.Count; i++){
            if(StudentsList[i].StudentName == studentName){
                StudentsList.Remove(StudentsList[i]);
            }
        }
        return StudentsList;
    }

    public List<Student> GetAllStudents()
    {
        return StudentsList;
    }

    public Student SearchStudent(string studentName)
    {
        Student noStudent = new();
        for(int i = 0; i < StudentsList.Count; i++){
            if(StudentsList[i].StudentName == studentName){
                return StudentsList[i];
            }
        }
        return noStudent ;
    }

    public List<Student> UpdateStudent(string studentName, string newName, string newGrade)
    {
        for(int i = 0; i < StudentsList.Count; i++){
            if(StudentsList[i].StudentName == studentName){
                StudentsList[i].StudentName = newName;
                StudentsList[i].StudentName = newGrade;
            }
        }
        return StudentsList;
    }
}
