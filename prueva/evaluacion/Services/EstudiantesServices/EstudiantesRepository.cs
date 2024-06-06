using evaluacion.Data;
using evaluacion.Models;

namespace evaluacion.Services.EstudiantesServices
{
    public class EstudiantesRepository : IEstudiantesRepository
    {
        private readonly PruevaDbContext _contex;
        public EstudiantesRepository(PruevaDbContext context){
            _contex = context;
        }

        public void Create(Estudiante estudiante)
        {
            _contex.students.Add(estudiante);
            _contex.SaveChanges();
        }

        public IEnumerable<Estudiante> GetAll()
        {
            return _contex.students.ToList();
        }

        public Estudiante GetById(int id){
            return _contex.students.Find(id);
        }

        public void update(Estudiante estudiante)
        {
            _contex.students.Update(estudiante);
            _contex.SaveChanges();
        }

    }
}