using evaluacion.Models;

namespace evaluacion.Services.ProfesoresServices
{
    public interface IProfesoresRepository
    {
         IEnumerable<Profesor> GetAll();
         Profesor GetById(int id);
         void Create(Profesor profesor);
         void update(Profesor profesor);
    }
}