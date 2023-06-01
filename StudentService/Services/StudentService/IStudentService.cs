namespace StudentService.Services.StudentService
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student? GetSingleStudent(int id);
        List<Student> AddStudent(Student student);
        List<Student>? UpdateStudent(int id, Student request);
        List<Student>? DeleteStudent(int id);
    }
}
