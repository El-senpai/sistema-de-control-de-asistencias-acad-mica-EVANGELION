using System;
using System.Collections.Generic;
using System.IO;

namespace SistemaAsistenciaApp
{
    public class SistemaAsistencia
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();
        private List<Asistencia> asistencias = new List<Asistencia>();

        private string archivoEstudiantes = "estudiantes.txt";
        private string archivoAsistencias = "asistencias.txt";

        public void AgregarEstudiante(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
            GuardarEstudiantes();
        }

        public void RegistrarAsistencia(Asistencia asistencia)
        {
            asistencias.Add(asistencia);
            GuardarAsistencias();
        }

        public void MostrarEstudiantes()
        {
            foreach (var e in estudiantes)
            {
                Console.WriteLine($"Nombre: {e.Nombre} - Cédula: {e.Cedula} - Carrera: {e.Carrera}");
            }
        }

        public void MostrarAsistencias()
        {
            foreach (var a in asistencias)
            {
                Console.WriteLine($"Cédula: {a.CedulaEstudiante} - Fecha: {a.Fecha.ToShortDateString()} - Estado: {a.Estado}");
            }
        }

        private void GuardarEstudiantes()
        {
            using (StreamWriter sw = new StreamWriter(archivoEstudiantes))
            {
                foreach (var e in estudiantes)
                {
                    sw.WriteLine(e.ToString());
                }
            }
        }

        private void GuardarAsistencias()
        {
            using (StreamWriter sw = new StreamWriter(archivoAsistencias))
            {
                foreach (var a in asistencias)
                {
                    sw.WriteLine(a.ToString());
                }
            }
        }

        public void CargarDatos()
        {
            if (File.Exists(archivoEstudiantes))
            {
                foreach (var linea in File.ReadAllLines(archivoEstudiantes))
                {
                    var datos = linea.Split(',');
                    estudiantes.Add(new Estudiante(datos[0], datos[1], datos[2]));
                }
            }

            if (File.Exists(archivoAsistencias))
            {
                foreach (var linea in File.ReadAllLines(archivoAsistencias))
                {
                    var datos = linea.Split(',');
                    asistencias.Add(new Asistencia(datos[0], DateTime.Parse(datos[1]), datos[2]));
                }
            }
        }
    }
}