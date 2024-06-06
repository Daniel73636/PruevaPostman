using evaluacion.Services.ProfesoresServices;
using Microsoft.AspNetCore.Mvc;
using evaluacion.Models;

namespace evaluacion.Controller.Profesores
{
    [ApiController]
    [Route("api/v1/Profesores/controller")]
    public class ProfesoresUpdateController :ControllerBase
    {
        private readonly IProfesoresRepository _profesoresRepository;
        public ProfesoresUpdateController(IProfesoresRepository profesoresRepository){
            _profesoresRepository = profesoresRepository;
        }
        [HttpPut]
        public void Update([FromBody]Profesor profesor){
            _profesoresRepository.update(profesor);
        }
    }
}