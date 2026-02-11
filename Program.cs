using System;

namespace SistemaAsistencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante est1 = new Estudiante("Julio", "Lechado", "2025001", "Ingeniería en Sistemas");

            Asistencia asistencia1 = new Asistencia(est1, DateTime.Now, true);

            Console.WriteLine("SISTEMA DE CONTROL DE ASISTENCIA");
            Console.WriteLine(est1.MostrarInformacion());
            Console.WriteLine(asistencia1.MostrarAsistencia());

            Console.ReadKey();
        }
    }
}
