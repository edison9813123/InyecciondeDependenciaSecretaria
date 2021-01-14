using System;
using Interfaces;
using Negocio;
using Entidades;
namespace InyecciondeDependenciasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IPersistencia persistencia = null; //Aqui se debe instanciar
           


            Secretaria secretaria = new Secretaria(persistencia);
            Estudiante estudiante = new Estudiante("Edison", "Molina");
            Curso curso = new Curso("Programacion");

            secretaria.Matricular(estudiante, curso);


        }
    }
}
