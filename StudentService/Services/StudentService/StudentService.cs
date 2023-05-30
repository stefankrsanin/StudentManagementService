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
            throw new NotImplementedException();
        }

        public List<Student> DeleteStudent(int id)
        {
            var student = students.Find(x => x.Id == id);
            if (student == null)
                return null;

            students.Remove(student);
            return students;
        }

        public List<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public Student GetSingleStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> UpdateStudent(int id, Student request)
        {
            throw new NotImplementedException();
        }
    }
}
