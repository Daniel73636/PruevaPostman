using evaluacion.Models;
using evaluacion.Data;


namespace evaluacion.Services.MatriculasServices
{
    public class MatriculasRepository : IMatriculasRepository
    {
        private readonly PruevaDbContext _contex;
        public MatriculasRepository(PruevaDbContext context){
            _contex = context;
        }
        public void Create(Matricula matricula)
        {
            _contex.enrollments.Add(matricula);
            _contex.SaveChanges();
        }

        public IEnumerable<Matricula> GetAll()
        {
           return _contex.enrollments.ToList();
        }

        public Matricula GetById(int id)
        {
            return _contex.enrollments.Find(id);
        }

        public void update(Matricula matricula)
        {
            _contex.enrollments.Update(matricula);
            _contex.SaveChanges();
        }

    }
}