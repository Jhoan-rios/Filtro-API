using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace School.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string? Names { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        [JsonIgnore]
        public List<Enrollment>? Enrollments { get; set; }
    }
} 