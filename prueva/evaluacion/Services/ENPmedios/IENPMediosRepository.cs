using evaluacion.Models;
namespace evaluacion.Services.ENPmediosServices
{
    public interface IENPMediosRepository
    {
         Matricula FiltraFecha(DateTime Date);
         Curso ProfesorCourse(int TeacherId);
         Matricula StudenMatricule(int StudentId);
         Estudiante StudentBirdate(DateTime BirthDate);
    }
}