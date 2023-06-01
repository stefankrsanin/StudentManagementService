using StudentService.Models;

namespace StudentService.Services.StudentService
{
    public class StudentService : IStudentService
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
        public List<Student> AddStudent(Student student)
        {
            students.Add(student);
            return students;
        }

        public List<Student>? DeleteStudent(int id)
        {
            var student = students.Find(x => x.Id == id);
            if (student == null)
                return null;

            students.Remove(student);
            return students;
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student? GetSingleStudent(int id)
        {
            var student = students.Find(x => x.Id == id);
            if (student == null)
                return null;
            return student;
        }

        public List<Student>? UpdateStudent(int id, Student request)
        {
            Console.WriteLine("Test commit");
            var student = students.Find(x => x.Id == id);
            if (student == null)
                return null;

            student.FirstName = request.FirstName;
            student.LastName = request.LastName;
            student.Email = request.Email;
            student.FieldOfStudy = request.FieldOfStudy;
            student.IndexNumber = request.IndexNumber;

            return students;
        }
    }
}
