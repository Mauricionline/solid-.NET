using DependencyInversion.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    IStudentRepository studentRepository;
    ILogbook logbook = new Logbook();
    public StudentController(IStudentRepository repository, ILogbook logBook)
    {
        studentRepository = repository;
        logbook = logBook;
    }
    

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        studentRepository.Add(student);
        logbook.Add($"The Student {student.Fullname} have been added");
    }
}
