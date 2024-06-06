using Microsoft.AspNetCore.Mvc;
using evaluacion.Models;
using evaluacion.Services.MatriculasServices;

namespace evaluacion.Controller.Matriculas
{
    [ApiController]
    [Route("api/v1/Matriculas/[controller]")]
    public class MatriculasCreateController : ControllerBase
    {
        private readonly IMatriculasRepository _matriculasRepository;
        public MatriculasCreateController(IMatriculasRepository matriculasRepository){
            _matriculasRepository = matriculasRepository;
        }
        [HttpPost]
        public IActionResult  Create([FromBody] Matricula matricula){
            _matriculasRepository.Create(matricula);
            return Ok();
        }
    }
}