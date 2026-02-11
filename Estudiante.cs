using System;

namespace SistemaAsistencia
{
    public class Estudiante : Persona
    {
        private string carnet;
        private string carrera;

        public string Carnet
        {
            get { return carnet; }
            set { carnet = value; }
        }

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public Estudiante(string nombre, string apellido, string carnet, string carrera)
            : base(nombre, apellido)
        {
            this.carnet = carnet;
            this.carrera = carrera;
        }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() +
                   $" | Carnet: {carnet} | Carrera: {carrera}";
        }
    }
}
