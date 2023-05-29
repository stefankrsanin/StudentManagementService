using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.Models;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private static List<Student> students = new List<Student>
            {
                new Student
                {   Id = 1,
                    FirstName = "Stefan",
                    LastName = "Krsanin",
                    Email = "stefankrsanin@gmail.com",
                    FieldOfStudy = ".NET",
                    IndexNumber = "1"
                },
                new Student
                {   Id = 2,
                    FirstName = "Luka",
                    LastName = "Golubovic",
                    Email = "lukagolubovic@gmail.com",
                    FieldOfStudy = "Java",
                    IndexNumber = "2"
                }
            };

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
