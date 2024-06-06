using evaluacion.Services.ENPmediosServices;
using Microsoft.AspNetCore.Mvc;
using evaluacion.Models;

namespace evaluacion.Controller.MediosENP
{
    [ApiController]
    [Route("api/v1/Medios/[controller]")]
    public class ENPmediosCursoFiltraFechaController : ControllerBase
    {
        private readonly IENPMediosRepository _ENPMediosRepository;
        public ENPmediosCursoFiltraFechaController(IENPMediosRepository ENPMediosRepository){
            _ENPMediosRepository = ENPMediosRepository;
        }
        [HttpGet]
        [Route("{Date}")]
        public Matricula FiltraFecha(DateTime Date){
            return _ENPMediosRepository.FiltraFecha(Date);
        }
    }
}