using System;

namespace SistemaAsistenciaApp
{
    public class Estudiante : Persona
    {
        private string carrera;

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public Estudiante(string nombre, string cedula, string carrera)
            : base(nombre, cedula)
        {
            this.carrera = carrera;
        }

        public override string ToString()
        {
            return $"{Nombre},{Cedula},{Carrera}";
        }
    }
}