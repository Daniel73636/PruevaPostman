using evaluacion.Models;

namespace evaluacion.Services.EstudiantesServices
{
    public interface IEstudiantesRepository
    {
         IEnumerable<Estudiante> GetAll();
         Estudiante GetById(int id);
         void Create(Estudiante estudiante);
         void update(Estudiante estudiante);
        
    }
}