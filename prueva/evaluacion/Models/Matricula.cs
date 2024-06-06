using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace evaluacion.Models
{
    public class Matricula
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public DateTime Date {get; set;}
        [Required]
        public int? StudentId {get; set; }
        [Required]
        public int? CourseId {get; set; }
        [Required]
        public string? Status {get; set; }
        /*public Estudiante? Estudiante {get; set;}*/
    }
}