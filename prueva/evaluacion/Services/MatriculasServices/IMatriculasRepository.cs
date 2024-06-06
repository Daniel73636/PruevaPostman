using evaluacion.Models;

namespace evaluacion.Services.MatriculasServices
{
    public interface IMatriculasRepository 
    {
         IEnumerable<Matricula> GetAll();
         Matricula GetById(int id);
         void Create(Matricula matricula);
         void update(Matricula matricula);
    }
}