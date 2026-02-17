using System;

namespace SistemaAsistenciaApp
{
    public class Persona
    {
        private string nombre;
        private string cedula;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public Persona(string nombre, string cedula)
        {
            this.nombre = nombre;
            this.cedula = cedula;
        }
    }
}