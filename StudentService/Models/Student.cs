namespace StudentService.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FieldOfStudy { get; set; } = string.Empty;
        public string IndexNumber { get; set; } = string.Empty;

    }
}
