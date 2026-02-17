using System;

namespace SistemaAsistenciaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaAsistencia sistema = new SistemaAsistencia();
            sistema.CargarDatos();

            int opcion;

            do
            {
                Console.WriteLine("\nSISTEMA DE ASISTENCIA");
                Console.WriteLine("1. Agregar Estudiante");
                Console.WriteLine("2. Registrar Asistencia");
                Console.WriteLine("3. Mostrar Estudiantes");
                Console.WriteLine("4. Mostrar Asistencias");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Cédula: ");
                        string cedula = Console.ReadLine();
                        Console.Write("Carrera: ");
                        string carrera = Console.ReadLine();

                        sistema.AgregarEstudiante(new Estudiante(nombre, cedula, carrera));
                        break;

                    case 2:
                        Console.Write("Cédula del estudiante: ");
                        string ced = Console.ReadLine();
                        Console.Write("Estado (Presente/Ausente): ");
                        string estado = Console.ReadLine();

                        sistema.RegistrarAsistencia(new Asistencia(ced, DateTime.Now, estado));
                        break;

                    case 3:
                        sistema.MostrarEstudiantes();
                        break;

                    case 4:
                        sistema.MostrarAsistencias();
                        break;
                }

            } while (opcion != 5);
        }
    }
}