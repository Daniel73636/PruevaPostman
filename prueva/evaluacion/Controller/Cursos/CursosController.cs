using evaluacion.Services.CursosServices;
using Microsoft.AspNetCore.Mvc;
using evaluacion.Models;
using evaluacion.Data;

namespace evaluacion.Controller
{
    [ApiController]
    [Route("api/v1/Cursos/[controller]")]
    public class CursosController : ControllerBase
    {
        private readonly ICursosRepository _cursosRepository;
        public CursosController(ICursosRepository cursosRepository){
            _cursosRepository = cursosRepository;
        }
        [HttpGet]
        public IEnumerable<Curso> GetAll(){
            return _cursosRepository.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public Curso GetById(int id){
            return _cursosRepository.GetById(id);
        }
    }
}