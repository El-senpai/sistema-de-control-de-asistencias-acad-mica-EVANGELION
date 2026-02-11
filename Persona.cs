using System;

namespace SistemaAsistencia
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public virtual string MostrarInformacion()
        {
            return $"Nombre: {nombre} {apellido}";
        }
    }
}
