using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace School.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Name no puede ser nulo")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "El campo Description no puede ser nulo")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "El campo Schedule no puede ser nulo")]
        public string? Schedule { get; set; }
        [Required(ErrorMessage = "El campo Duration no puede ser nulo")]
        public string? Duration { get; set; }
        [Required(ErrorMessage = "El campo Capacity no puede ser nulo")]
        public int Capacity { get; set; }
        [Required(ErrorMessage = "El campo TeacherId no puede ser nulo")]
        public int TeacherId { get; set; }
        public Teacher? Teachers { get; set; }
        [JsonIgnore]
        public List<Enrollment>? Enrollments { get; set; }
    }
}