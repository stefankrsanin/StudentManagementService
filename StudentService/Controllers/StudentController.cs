using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.Services.StudentService;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;   
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetSingleStudent(int id)
        {
            var student = students.Find(x => x.Id == id);
            if (student == null)
                return NotFound("This student doesn't exist");
            return Ok(student);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<List<Student>>> AddStudent(Student student)
        {
            students.Add(student);
            return Ok(students);
        }

        [HttpPut]
        public async Task<ActionResult<List<Student>>> UpdateStudent(int id, Student request)
        {
            var student = students.Find(x => x.Id == id);
            if (student == null)
                return NotFound("This student doesn't exist");

            student.FirstName = request.FirstName;
            student.LastName = request.LastName;
            student.Email = request.Email;
            student.FieldOfStudy = request.FieldOfStudy;
            student.IndexNumber = request.IndexNumber;

            return Ok(students);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int id)
        {
            var student = students.Find(x => x.Id == id);
            if (student == null)
                return NotFound("This student doesn't exist");

            students.Remove(student);
            return Ok(student);
        }
    }
}
