using Interfaces;
using Entidades;

namespace Negocio
{
    public class Secretaria
    {
        
        public IPersistencia Persistencia { get; set; }

        public Secretaria(IPersistencia persistencia)
        {
            this.Persistencia = persistencia; 
        }
        
        
        public string Matricular(Estudiante estudiante, Curso curso)
        {
            
            Persistencia.Grabar(estudiante);
            Persistencia.Grabar(curso);
            Persistencia.Grabar(new EstudiantePorCurso { EstudianteId = estudiante.Id, CursoId = curso.Id });

            return string.Format("El estudiante  {0} {1} se matriculó en el curso de {2}"
                , estudiante.Nombre
                , estudiante.Apellido
                , curso.Nombre);
        }
    }
}
