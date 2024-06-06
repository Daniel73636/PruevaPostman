using Microsoft.AspNetCore.Mvc;
using evaluacion.Data;
using evaluacion.Models;
using evaluacion.Services.MatriculasServices;

namespace evaluacion.Controller.Matriculas
{
    [ApiController]
    [Route("api/v1/Matriculas/[controller]")]
    public class MatriculasUpdateController : ControllerBase
    {
        private readonly IMatriculasRepository _matriculasRepository;
        public MatriculasUpdateController(IMatriculasRepository matriculasRepository){
            _matriculasRepository = matriculasRepository;
        }
        [HttpPut]
        public void Update([FromBody]Matricula matricula){
            _matriculasRepository.update(matricula);
        }
    }
}