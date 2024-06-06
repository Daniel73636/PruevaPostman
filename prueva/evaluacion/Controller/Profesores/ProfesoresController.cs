using evaluacion.Services.ProfesoresServices;
using Microsoft.AspNetCore.Mvc;
using evaluacion.Models;

namespace evaluacion.Controller.Profesores
{
    [ApiController]
    [Route("api/v1/Profesores/controller")]
    public class ProfesoresController : ControllerBase
    {
        private readonly IProfesoresRepository _profesoresRepository;
        public ProfesoresController(IProfesoresRepository profesoresRepository){
            _profesoresRepository = profesoresRepository;
        }
        [HttpGet]
        public IEnumerable<Profesor> GetAll(){
            return _profesoresRepository.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public Profesor GetById(int id){
            return _profesoresRepository.GetById(id);
        }

    }
}