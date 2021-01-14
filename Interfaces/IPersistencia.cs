using Entidades;
namespace Interfaces
{
     public interface IPersistencia
    {
         bool Grabar(Estudiante estudiante);

         bool Grabar(Curso curso);

         bool Grabar(EstudiantePorCurso estudiantePorCurso);
       
    }
}
