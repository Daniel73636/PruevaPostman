using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace evaluacion.Models
{
    public class Estudiante
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public string? Names { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? Email { get; set; }
        /*public List<Matricula> Matricula { get; set; }*/
    }
}