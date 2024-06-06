using evaluacion.Data;
using evaluacion.Models;
using evaluacion.Services;
using Microsoft.EntityFrameworkCore;


namespace evaluacion.Services.CursosServices
{
    public class CursosRepository : ICursosRepository
    {
        private readonly PruevaDbContext _context;
        public CursosRepository(PruevaDbContext context){
            _context = context;
        }
        public void Create(Curso curso){
            _context.courses.Add(curso);
            _context.SaveChanges();
        }
        public IEnumerable<Curso> GetAll(){
            /*var estudiantes = _context.students.Include( u => u.Matricula).ToList();*/
            return _context.courses.ToList();
        }
        public Curso GetById(int id){
            return _context.courses.Find(id);
        }
        public void update(Curso curso){
            _context.courses.Update(curso);
            _context.SaveChanges();
        }

    }
}