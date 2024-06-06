using evaluacion.Services.EstudiantesServices;
using Microsoft.AspNetCore.Mvc;
using evaluacion.Models;

namespace evaluacion.Controller
{
    [ApiController]
    [Route("api/v1/Estudiantes/[controller]")]
    public class EstudiantesController : ControllerBase
    {
        private readonly IEstudiantesRepository _estudiantesRepository;
        public EstudiantesController(IEstudiantesRepository estudiantesRepository){
            _estudiantesRepository = estudiantesRepository;
        }
        [HttpGet]
        public IEnumerable<Estudiante> GetAll(){
            return _estudiantesRepository.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public Estudiante GetById(int id){
            return _estudiantesRepository.GetById(id);
        }
    }
}