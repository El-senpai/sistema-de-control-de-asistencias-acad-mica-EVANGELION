using System;

namespace SistemaAsistencia
{
    public class Asistencia
    {
        private Estudiante estudiante;
        private DateTime fecha;
        private bool presente;

        public Estudiante Estudiante
        {
            get { return estudiante; }
            set { estudiante = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public bool Presente
        {
            get { return presente; }
            set { presente = value; }
        }

        public Asistencia(Estudiante estudiante, DateTime fecha, bool presente)
        {
            this.estudiante = estudiante;
            this.fecha = fecha;
            this.presente = presente;
        }

        public string MostrarAsistencia()
        {
            string estado = presente ? "Presente" : "Ausente";
            return $"{estudiante.Nombre} {estudiante.Apellido} - {fecha.ToShortDateString()} - {estado}";
        }
    }
}
