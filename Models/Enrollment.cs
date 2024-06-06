namespace School.Models
{
    public class Enrollment
    {
        public int Id { get; set; }    
        public DateTime? Date { get; set; }
        public string? Status { get; set; }
        public int? StudentId { get; set; }
        public Student? Students { get; set; }
        public int? CourseId { get; set; }
        public Course? Courses { get; set; }
    }
}