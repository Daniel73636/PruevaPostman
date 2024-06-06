using evaluacion.Services.MatriculasServices;
using Microsoft.AspNetCore.Mvc;
using evaluacion.Models;

namespace evaluacion.Controller.Matriculas
{
    [ApiController]
    [Route("api/v1/Matriculas/[controller]")]
    public class MatriculasController : ControllerBase
    {
        private readonly IMatriculasRepository _matriculasRepository;
        public MatriculasController(IMatriculasRepository matriculasRepository){
            _matriculasRepository = matriculasRepository;
        }
        [HttpGet]
        public IEnumerable<Matricula> GetAll(){
            return _matriculasRepository.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public Matricula GetById(int id){
            return _matriculasRepository.GetById(id);
        }
    }
}