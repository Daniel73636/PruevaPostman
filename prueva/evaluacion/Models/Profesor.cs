using System.ComponentModel.DataAnnotations;

namespace evaluacion.Models
{
    public class Profesor
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Names { get; set; }
        [Required]
        public string? 	Specialty { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public int? YearsExperience { get; set; }
    }
}