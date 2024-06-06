using evaluacion.Services.ENPmediosServices;
using Microsoft.AspNetCore.Mvc;
using evaluacion.Models;


namespace evaluacion.Controller.MediosENP
{
    [ApiController]
    [Route("api/v1/Medios/[controller]")]
    public class ENPmediosMatriculaStudenMatriculeController : ControllerBase
    {
        private readonly IENPMediosRepository _ENPMediosRepository;
        public ENPmediosMatriculaStudenMatriculeController(IENPMediosRepository ENPMediosRepository){
            _ENPMediosRepository = ENPMediosRepository;
        }
        [HttpGet]
        [Route("{StudentId}")]
        public Matricula StudenMatricule(int StudentId){
            return _ENPMediosRepository.StudenMatricule(StudentId);
        }

    }
}