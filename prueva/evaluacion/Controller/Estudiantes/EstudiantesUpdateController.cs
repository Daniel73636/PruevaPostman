using evaluacion.Models;
using evaluacion.Services.EstudiantesServices;
using Microsoft.AspNetCore.Mvc;

namespace evaluacion.Controller.Estudiantes
{
    [ApiController]
    [Route("api/v1/Estudiantes/[controller]")]
    public class EstudiantesUpdateController : ControllerBase
    {
        private readonly IEstudiantesRepository _estudiantesRepository;
        public EstudiantesUpdateController(IEstudiantesRepository estudiantesRepository){
            _estudiantesRepository = estudiantesRepository;
        }
        [HttpPut]
        public void Update([FromBody]Estudiante estudiante){
            _estudiantesRepository.update(estudiante);
        }
    }
}