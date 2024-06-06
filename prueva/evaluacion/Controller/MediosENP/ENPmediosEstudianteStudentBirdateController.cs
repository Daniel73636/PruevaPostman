using evaluacion.Services.ENPmediosServices;
using Microsoft.AspNetCore.Mvc;
using evaluacion.Models;

namespace evaluacion.Controller.MediosENP
{
    [ApiController]
    [Route("api/v1/Medios/[controller]")]
    public class ENPmediosEstudianteStudentBirdateController : ControllerBase
    {
        private readonly IENPMediosRepository _ENPMediosRepository;
        public ENPmediosEstudianteStudentBirdateController(IENPMediosRepository ENPMediosRepository){
            _ENPMediosRepository = ENPMediosRepository;
        }
        [HttpGet]
        [Route("{Date}")]
        public Estudiante StudentBirdate(DateTime BirthDate){
            return _ENPMediosRepository.StudentBirdate(BirthDate);
        }
    }
}