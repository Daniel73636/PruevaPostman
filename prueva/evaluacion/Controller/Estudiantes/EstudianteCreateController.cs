using evaluacion.Services.EstudiantesServices;
using Microsoft.AspNetCore.Mvc;
using evaluacion.Models;

namespace evaluacion.Controller
{
    [ApiController]
    [Route("api/v1/Estudiantes/[controller]")]
    public class EstudianteCreateController : ControllerBase
    {
        private readonly IEstudiantesRepository _estudiantesRepository;
        public EstudianteCreateController(IEstudiantesRepository estudiantesRepository){
            _estudiantesRepository = estudiantesRepository;
        }
        [HttpPost]
        public IActionResult  Create([FromBody] Estudiante estudiante){
            _estudiantesRepository.Create(estudiante);
            return Ok();
        }
    }
}