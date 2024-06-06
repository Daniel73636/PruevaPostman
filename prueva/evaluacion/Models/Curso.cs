using System.ComponentModel.DataAnnotations;

namespace evaluacion.Models
{
    public class Curso
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [Required]
        public string? Schedule { get; set; }
        [Required]
        public string? Duration { get; set; }
        [Required]
        public int? Capacity { get; set; }
    }
}