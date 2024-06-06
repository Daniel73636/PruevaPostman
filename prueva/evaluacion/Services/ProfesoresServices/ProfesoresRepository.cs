using System.Reflection.Metadata.Ecma335;
using evaluacion.Data;
using evaluacion.Models;

namespace evaluacion.Services.ProfesoresServices
{
    public class ProfesoresRepository : IProfesoresRepository
    {
        private readonly PruevaDbContext _contex;
        public ProfesoresRepository(PruevaDbContext context){
            _contex = context;
        }
        public void Create(Profesor profesor)
        {
            _contex.teachers.Add(profesor);
            _contex.SaveChanges();
        }

        public IEnumerable<Profesor> GetAll()
        {
            return _contex.teachers.ToList();
        }

        public Profesor GetById(int id)
        {
            return _contex.teachers.Find(id);
        }

        public void update(Profesor profesor)
        {
            _contex.teachers.Update(profesor);
            _contex.SaveChanges();
        }

    }
}