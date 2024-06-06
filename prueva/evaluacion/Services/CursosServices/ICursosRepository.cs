using evaluacion.Models;

namespace evaluacion.Services.CursosServices
{
    public interface ICursosRepository
    {
         IEnumerable<Curso> GetAll();
         Curso GetById(int id);
         void Create(Curso curso);
         void update(Curso curso);
    }
}