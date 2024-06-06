using evaluacion.Services.ProfesoresServices;
using Microsoft.AspNetCore.Mvc;
using evaluacion.Models;


namespace evaluacion.Controller.Profesores
{
    [ApiController]
    [Route("api/v1/Profesores/controller")]
    public class ProfesoresCreateController : ControllerBase
    {
        private readonly IProfesoresRepository _profesoresRepository;
        public ProfesoresCreateController(IProfesoresRepository profesoresRepository){
            _profesoresRepository = profesoresRepository;
        }
        [HttpPost]
        public IActionResult  Create([FromBody] Profesor profesor){
            _profesoresRepository.Create(profesor);
            return Ok();
        }
    }
}