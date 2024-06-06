using evaluacion.Models;
using evaluacion.Services.CursosServices;
using Microsoft.AspNetCore.Mvc;

namespace evaluacion.Controller
{
    [ApiController]
    [Route("api/v1/Cursos/[controller]")]
    public class CursosCreateController : ControllerBase
    {
        private readonly ICursosRepository _cursosRepository;
        public CursosCreateController(ICursosRepository cursosRepository){
            _cursosRepository = cursosRepository;
        }
        [HttpPost]
        public IActionResult  Create([FromBody] Curso curso){
            _cursosRepository.Create(curso);
            return Ok();
        }
    }
}