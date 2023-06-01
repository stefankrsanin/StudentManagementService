using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.Services.StudentService;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;   
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            return _studentService.GetAllStudents();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetSingleStudent(int id)
        {
            var result = _studentService.GetSingleStudent(id);
            if (result == null)
                NotFound("This student doesn't exist");
            return result;
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<List<Student>>> AddStudent(Student student)
        {
            var result = _studentService.AddStudent(student);
            return result;
        }

        [HttpPut]
        public async Task<ActionResult<List<Student>>> UpdateStudent(int id, Student request)
        {
            var result = _studentService.UpdateStudent(id, request);
            if (result == null)
                NotFound("This student doesn't exist");
            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int id)
        {
          var result = _studentService.DeleteStudent(id);
            if (result == null)
                NotFound("This student doesn't exist");
            return result;
        }
    }
}
