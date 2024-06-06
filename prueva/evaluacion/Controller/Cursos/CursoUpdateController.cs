using evaluacion.Models;
using evaluacion.Services.CursosServices;
using Microsoft.AspNetCore.Mvc;


namespace evaluacion.Controller
{
    [ApiController]
    [Route("api/v1/Cursos/[controller]")]
    public class CursoUpdateController : ControllerBase
    {
        private readonly ICursosRepository _cursosRepository;
        public CursoUpdateController(ICursosRepository cursosRepository){
            _cursosRepository = cursosRepository;
        }
        [HttpPut]
        public void Update([FromBody]Curso curso){
            _cursosRepository.update(curso);
        }
    }
}