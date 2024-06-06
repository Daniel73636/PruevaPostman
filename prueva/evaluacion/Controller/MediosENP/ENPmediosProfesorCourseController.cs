using evaluacion.Services.ENPmediosServices;
using Microsoft.AspNetCore.Mvc;
using evaluacion.Models;


namespace evaluacion.Controller.MediosENP
{
    [ApiController]
    [Route("api/v1/Medios/[controller]")]
    public class ENPmediosProfesorCourseController : ControllerBase
    {
        private readonly IENPMediosRepository _ENPMediosRepository;
        public ENPmediosProfesorCourseController(IENPMediosRepository ENPMediosRepository){
            _ENPMediosRepository = ENPMediosRepository;
        }
        [HttpGet]
        [Route("{TeacherId}")]
        public Curso ProfesorCourse(int TeacherId){
            return _ENPMediosRepository.ProfesorCourse(TeacherId);
        }
    }
}