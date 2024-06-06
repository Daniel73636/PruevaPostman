using evaluacion.Models;
using evaluacion.Data;
using Microsoft.EntityFrameworkCore;

namespace evaluacion.Services.ENPmediosServices
{
    public class ENPMediosRepository : IENPMediosRepository
    {
        private readonly PruevaDbContext _contex;
        public ENPMediosRepository(PruevaDbContext contex){
            _contex = contex;
        }

        public Matricula FiltraFecha(DateTime Date)
        {
            return _contex.enrollments.Find(Date);
        }

        public Curso ProfesorCourse(int TeacherId)
        {
            return _contex.courses.Find(TeacherId);
        }

        public Matricula StudenMatricule(int StudentId)
        {
            return _contex.enrollments.Find(StudentId);
        }

        public Estudiante StudentBirdate(DateTime BirthDate)
        {
            return _contex.students.Find(BirthDate);
        }

    }
}