using System.Text.Json.Serialization;

namespace School.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Names { get; set; }
        public string? Specialty { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int YearsExperience { get; set; }
        [JsonIgnore]
        public List<Course>? Courses { get; set; }
    }
}