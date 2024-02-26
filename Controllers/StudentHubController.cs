using Microsoft.AspNetCore.Mvc;
using studentInfoHubAPI.Services;

namespace studentInfoHubAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentHubController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentHubController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    [Route("GetAllStudents")]
    public List<Student> GetAllStudents() {
        return _studentService.GetAllStudents();
    }

    [HttpGet]
    [Route("SearchStudent/{studentName}")]
    public Student SearchStudent(string studentName) {
        return _studentService.SearchStudent(studentName);
    }

    [HttpDelete]
    [Route("DeleteStudent/{studentName}")]
    public List<Student> DeleteStudent(string studentName) {
        return _studentService.DeleteStudent(studentName);
    }

    [HttpPost]
    [Route("AddStudent/Name/{studentName}/Grade/{studentGrade}")]
    public List<Student> AddStudent(string studentName, string studentGrade) {
        return _studentService.AddStudent(studentName, studentGrade);
    }

    [HttpPut]
    [Route("UpdateStudent/StudentName/{studentName}/NewName/{newName}/NewGrade/{newGrade}")]
    public List<Student> UpdateStudent(string studentName, string newName, string newGrade) {
        return _studentService.UpdateStudent(studentName, newName, newGrade);
    }
}
